using Entities.Models;
using Entities.ViewModels;
using MongoDB.Driver;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Adavigo.CMS.Service;

namespace WEB.Adavigo.CMS.PQ.Service
{
    public class BillWaterSportService
    {
        private readonly IConfiguration configuration;
        private IMongoCollection<BillWaterSportViewCount> BillWaterSportmongoCollection;
        public BillWaterSportService(IConfiguration _Configuration)
        {
            configuration = _Configuration;

        }
        public async Task<int> AddBillWaterSport(BillWaterSportViewCount model)
        {
            try
            {
                string url = "mongodb://" + configuration["DataBaseConfig:MongoServer:user"] + ":" + configuration["DataBaseConfig:MongoServer:pwd"] + "@" + configuration["DataBaseConfig:MongoServer:Host"] + ":" + configuration["DataBaseConfig:MongoServer:Port"] + "/" + configuration["DataBaseConfig:MongoServer:catalog_log"];
                var client = new MongoClient(url);
                IMongoDatabase db = client.GetDatabase(configuration["DataBaseConfig:MongoServer:catalog_log"]);
                IMongoCollection<BillWaterSportViewCount> affCollection = db.GetCollection<BillWaterSportViewCount>(configuration["DataBaseConfig:MongoServer:bill_Watersport"]);
       
                await affCollection.InsertOneAsync(model);
                return 1;

            }
            catch (Exception ex)
            {
                Utilities.LogHelper.InsertLogTelegram("AddBillWaterSport - BillWaterSportService: " + ex);
                return 0;
            }
        }
        public long BillWaterSportCount()
        {
            var listBillWaterSportView = new List<BillWaterSportViewCount>();
            try
            {
                int total = 0;
                var db = MongodbService.GetDatabase();
                var collection = db.GetCollection<BillWaterSportViewCount>("BillWaterSportNo");
                var filter = Builders<BillWaterSportViewCount>.Filter.Empty;
                filter &= Builders<BillWaterSportViewCount>.Filter.Gte("date", DateTime.Now.Date);
                filter &= Builders<BillWaterSportViewCount>.Filter.Lte("date", DateTime.Now);

                var S = Builders<BillWaterSportViewCount>.Sort.Descending("_id");


                listBillWaterSportView = collection.Find(filter).Sort(S).ToList();
                total = (int)collection.Find(filter).Count();
                return total;

            }
            catch (Exception ex)
            {
                Utilities.LogHelper.InsertLogTelegram("AddBillWaterSport - BillWaterSportService: " + ex);
                return 0;
            }
        }
    }
}
