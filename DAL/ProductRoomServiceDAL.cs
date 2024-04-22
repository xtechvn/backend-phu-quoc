using DAL.Generic;
using DAL.StoreProcedure;
using Entities.Models;
using Entities.ViewModels.PricePolicy;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace DAL
{
    public class ProductRoomServiceDAL : GenericService<ProductRoomService>
    {
        private static DbWorker _DbWorker;
        public ProductRoomServiceDAL(string connection) : base(connection)
        {
            _DbWorker = new DbWorker(connection);
        }
     
        public async Task<List<ProductRoomService>> GetByCampaignID(int campaign_id)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var find = _DbContext.ProductRoomService.Where(x=>x.CampaignId==campaign_id).ToList();
                    return find;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetByCampaignID - ProductRoomServiceDAL: " + ex);
                return null;
            }
        }
        public async Task<List<string>> GetContractExists()
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var find = _DbContext.ProductRoomService.Select(x=>x.ContractNo).Distinct().ToList();
                    return find;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetContractExists - ProductRoomServiceDAL: " + ex);
                return new List<string>();
            }
        }
        public async Task<ProductRoomService> GetByDetail(int campaign_id, string contract_no, string package_id, string room_id)
        {
            ProductRoomService productRoomService = null;

            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var find =  _DbContext.ProductRoomService.FirstOrDefault(x => x.CampaignId==campaign_id && x.ContractNo==contract_no && x.PackageId==package_id && x.RoomId==room_id);
                    return find;
                }
               
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetByDetail - ProductRoomServiceDAL: " + ex);
                
            }
            return productRoomService;
        }
        public async Task<ProductRoomService> GetByID(int id)
        {
            ProductRoomService productRoomService = null;

            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var find =  _DbContext.ProductRoomService.FirstOrDefault(x => x.Id==id);
                    return find;
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetByID - ProductRoomServiceDAL: " + ex);

            }
            return productRoomService;
        }
       
    }
}
