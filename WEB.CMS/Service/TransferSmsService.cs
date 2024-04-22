using Entities.Models;
using Entities.ViewModels.TransferSms;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace WEB.Adavigo.CMS.Service
{
    public class TransferSmsService
    {
        public List<TransactionSMS> SearchTransactionSMs(TransferSmsSearchModel searchModel, out long total, int pageIndex = 1, int pageSize = 10)
        {
            var listTransaction = new List<TransactionSMS>();
            try
            {
                var db = MongodbService.GetDatabase();

                total = 0;
                var collection = db.GetCollection<TransactionSMS>("TransactionSMS");
                var filter = Builders<TransactionSMS>.Filter.Empty;
                if (searchModel.Amount != -1)
                {
                    filter &= Builders<TransactionSMS>.Filter.Eq(n => n.Amount, searchModel.Amount);
                }
                if (!string.IsNullOrEmpty(searchModel.BankName) && !string.IsNullOrEmpty(searchModel.BankName.Trim()))
                {
                    //filter &= Builders<TransactionSMS>.Filter.Eq("BankName", searchModel.BankName.Trim().ToUpper());
                    filter &= Builders<TransactionSMS>.Filter.Regex("BankName", new BsonRegularExpression(".*" + searchModel.BankName.Trim().ToUpper() + ".*"));
                }
                if (!string.IsNullOrEmpty(searchModel.OrderNo) && !string.IsNullOrEmpty(searchModel.OrderNo.Trim()))
                {
                    //filter &= Builders<TransactionSMS>.Filter.Eq("BookingCode", searchModel.BookingCode.Trim().ToUpper());
                    filter &= Builders<TransactionSMS>.Filter.Regex("OrderNo", new BsonRegularExpression(".*" + searchModel.OrderNo.Trim().ToUpper() + ".*"));
                }
                if (!string.IsNullOrEmpty(searchModel.FromDateStr))
                {
                    filter &= Builders<TransactionSMS>.Filter.Gte("ReceiveTime", searchModel.FromDate);
                }
                if (!string.IsNullOrEmpty(searchModel.ToDateStr))
                {
                    filter &= Builders<TransactionSMS>.Filter.Lte("ReceiveTime", searchModel.ToDate);
                }
                if (searchModel.StatusSuccess && searchModel.StatusFail)
                {
                    filter &= Builders<TransactionSMS>.Filter.Where(n => n.StatusPush == true || n.StatusPush == false);
                }
                else
                {
                    if (searchModel.StatusFail)
                    {
                        filter &= Builders<TransactionSMS>.Filter.Eq(n => n.StatusPush, false);
                    }
                    if (searchModel.StatusSuccess)
                    {
                        filter &= Builders<TransactionSMS>.Filter.Eq(n => n.StatusPush, true);
                    }
                }
                var S = Builders<TransactionSMS>.Sort.Descending("_id");
                total = collection.Find(filter).Count();
                if (pageSize > 0)
                {
                    listTransaction = collection.Find(filter).Sort(S)
                        .Skip((pageIndex - 1) * pageSize).Limit(pageSize)
                        .ToList();
                }
                else
                {
                    listTransaction = collection.Find(filter).Sort(S).ToList();
                }
            }
            catch (Exception ex)
            {
                total = 0;
                LogHelper.InsertLogTelegram("SearchTransactionSMs - TransferSmsService. " + JsonConvert.SerializeObject(ex));
            }
            return listTransaction;
        }
    }
}
