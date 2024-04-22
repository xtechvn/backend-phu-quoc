using DAL;
using Entities.ConfigModels;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.PricePolicy;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace Repositories.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly CampaignDAL _campaignDAL;
        private readonly ProductRoomServiceDAL _productRoomServiceDAL;
        private readonly PriceDetailDAL _priceDetailDAL;
        private readonly RoomFunDAL _roomFunDAL;
        private readonly RoomPackageDAL _roomPackageDAL;
        private readonly ServicePiceRoomDAL _servicePiceRoomDAL;

        public CampaignRepository(IOptions<DataBaseConfig> dataBaseConfig, IOptions<MailConfig> mailConfig)
        {
            _campaignDAL = new CampaignDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _productRoomServiceDAL = new ProductRoomServiceDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _priceDetailDAL = new PriceDetailDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _roomFunDAL= new RoomFunDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _roomPackageDAL= new RoomPackageDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
            _servicePiceRoomDAL= new ServicePiceRoomDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
        }
        public GenericViewModel<PricePolicyListingModel> GetPagingList(PricePolicySearchModel searchModel, int currentPage, int pageSize)
        {
            var model = new GenericViewModel<PricePolicyListingModel>();
            try
            {
                DataTable dt = _campaignDAL.GetPagingList(searchModel, currentPage, pageSize);
                if (dt != null && dt.Rows.Count > 0)
                {
                    model.ListData = (from row in dt.AsEnumerable()
                                      select new PricePolicyListingModel
                                      {
                                          Id = Convert.ToInt32(row["Id"]),
                                          FromDate = Convert.ToDateTime(!row["FromDate"].Equals(DBNull.Value) ? row["FromDate"] : null),
                                          ToDate = Convert.ToDateTime(!row["ToDate"].Equals(DBNull.Value) ? row["ToDate"] : null),
                                          CampaignCode = row["CampaignCode"].ToString(),
                                          CampaignDescription = row["CampaignDescription"].ToString(),
                                          Profit = Convert.ToDouble(row["Profit"].Equals(DBNull.Value) ? "0" : row["Profit"]),
                                          UpdateLast = Convert.ToDateTime(!row["UpdateLast"].Equals(DBNull.Value) ? row["UpdateLast"] : null),
                                          ClientTypeName = row["ClientTypeName"].ToString(),
                                          ServiceTypeName = row["ServiceTypeName"].ToString(),
                                          UnitName = row["UnitName"].ToString(),
                                          StatusName = row["StatusName"].ToString(),
                                          ServiceType = Convert.ToInt32(row["ServiceType"].Equals(DBNull.Value) ? "0" : row["ServiceType"]),
                                          ProviderID= row["ProviderID"].ToString()
                                      }).ToList();

                    model.CurrentPage = currentPage;
                    model.PageSize = pageSize;
                    model.TotalRecord = Convert.ToInt32(dt.Rows[0]["TotalRow"]);
                    model.TotalPage = (int)Math.Ceiling((double)model.TotalRecord / pageSize);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPagingList - CampaignRepository: " + ex);
            }
            return model;
        }
       
        public async Task<Campaign> GetDetailByCode(string campaign_code)
        {
            return await _campaignDAL.GetDetailByCode(campaign_code);
        }
        public async Task<Campaign> GetDetailByID(int id)
        {
            return await _campaignDAL.GetDetailByID(id);
        }
        public async Task<int> AddNew(Campaign campaign)
        {
            return await _campaignDAL.AddNew(campaign);
        }

        public async Task<int> Update(Campaign campaign)
        {
            return await _campaignDAL.Update(campaign);
        }

        public int Delete(int campaignId)
        {
            return _campaignDAL.Delete(campaignId);
        }

        public Task<int> CreateOrUpdateHotelCampaign(HotelPricePolicyDetailViewModel full_detail, int user_id)
        {
            return _campaignDAL.CreateOrUpdateHotelCampaign(full_detail, user_id);
        }

        public async Task<HotelPricePolicyDetailViewModel> GetPolicyDetailViewByCampaignID(int campaign_id)
        {
            HotelPricePolicyDetailViewModel result = new HotelPricePolicyDetailViewModel();
            try
            {
                result.CampaignDetail = await _campaignDAL.GetDetailByID(campaign_id); 
                if (result.CampaignDetail != null && result.CampaignDetail.Id > 0)
                {
                    List<ProductRoomService> productRoomServices = await _productRoomServiceDAL.GetByCampaignID(result.CampaignDetail.Id);
                    List<PriceDetail> priceDetails = _priceDetailDAL.GetAll();
                    List<RoomFun> roomFuns = _roomFunDAL.GetAll();
                    List<RoomPackage> roomPackages = _roomPackageDAL.GetAll();
                    List<ServicePiceRoom> servicePiceRooms = _servicePiceRoomDAL.GetAll();
                    if (productRoomServices != null && productRoomServices.Count > 0)
                    {
                        result.ListPricePolicy = new List<HotelPricePolicyDetail>();
                        foreach (var roomservice in productRoomServices)
                        {
                            ProductRoomServiceCMSViewModel roomservice_viewmodel = new ProductRoomServiceCMSViewModel()
                            {
                                AllotmentsId=roomservice.AllotmentsId,
                                CampaignId=roomservice.CampaignId,
                                ContractNo=roomservice.ContractNo,
                                PackageId=roomservice.PackageId,
                                GroupProviderType = roomservice.GroupProviderType,
                                ProviderId=roomservice.ProviderId,
                                RoomId=roomservice.RoomId, 
                            };
                            RoomFun roomFun = roomFuns.Where(x => x.HotelId == roomservice_viewmodel.ProviderId && x.AllotmentName==roomservice_viewmodel.ContractNo).FirstOrDefault();
                            if (roomFun != null)
                            {
                                RoomPackage package = roomPackages.Where(x => x.PackageId == roomservice_viewmodel.PackageId && x.RoomFunId == roomFun.Id).FirstOrDefault();
                                if (package != null)
                                {
                                    roomservice_viewmodel.PackageName = package.Code;
                                    ServicePiceRoom servicePiceRoom = servicePiceRooms.Where(x => x.RoomId == roomservice_viewmodel.RoomId && x.RoomPackageId == package.Id).FirstOrDefault();
                                    if (servicePiceRoom != null)
                                    {
                                        roomservice_viewmodel.ProviderName = "";
                                        roomservice_viewmodel.RoomName = servicePiceRoom.RoomName;
                                        roomservice_viewmodel.RoomCode = servicePiceRoom.RoomCode;
                                        roomservice_viewmodel.BasePrice = (double)servicePiceRoom.Price;
                                        roomservice_viewmodel.AllotmentsId = roomFun.AllotmentId;
                                        roomservice_viewmodel.ContractNo = roomFun.AllotmentName;
                                    }
                                }
                            }
                            var price_details = priceDetails.Where(x => x.ProductServiceId == roomservice.Id).ToList();
                            foreach (var price_detail in price_details)
                            {
                                switch (price_detail.UnitId)
                                {
                                    case (int)HotelUnitID.Percent:
                                        {
                                            price_detail.AmountLast = price_detail.Price + Math.Round((double)(price_detail.Price * price_detail.Profit / 100), 0);
                                        }
                                        break;
                                    case (int)HotelUnitID.VND:
                                        {
                                            price_detail.AmountLast = price_detail.Price + price_detail.Profit;
                                        }
                                        break;
                                    default:
                                        {
                                            price_detail.AmountLast = price_detail.Price;
                                        }
                                        break;
                                }
                            }
                            result.ListPricePolicy.Add(new HotelPricePolicyDetail()
                            {
                                ProductService = roomservice_viewmodel,
                                PriceDetail = price_details
                            });
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPolicyDetailViewByCampaignID - CampaignRepository: " + ex);
            }
            return result;
        }
    }
}
