using DAL.Generic;
using DAL.StoreProcedure;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.PricePolicy;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace DAL
{
    public class CampaignDAL : GenericService<Campaign>
    {
        private static DbWorker _DbWorker;
        public CampaignDAL(string connection) : base(connection)
        {
            _DbWorker = new DbWorker(connection);
        }
        public DataTable GetPagingList(PricePolicySearchModel searchModel, int currentPage, int pageSize)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[9];

                objParam[0] = new SqlParameter("@CampaignCode", searchModel.CampaignCode ?? string.Empty);
                objParam[1] = new SqlParameter("@CampaignDescription", searchModel.CampaignDescription ?? string.Empty);
                if (searchModel.FromDate != DateTime.MinValue)
                    objParam[2] = new SqlParameter("@FromDate", searchModel.FromDate);
                else
                    objParam[2] = new SqlParameter("@FromDate", DBNull.Value);
                if (searchModel.ToDate != DateTime.MinValue)
                    objParam[3] = new SqlParameter("@ToDate", searchModel.ToDate);
                else
                    objParam[3] = new SqlParameter("@ToDate", DBNull.Value);

                objParam[4] = new SqlParameter("@CampaginStatus", searchModel.CampaginStatus);
                objParam[5] = new SqlParameter("@ClientType", searchModel.ClientType);
                objParam[6] = new SqlParameter("@ServiceType", searchModel.ServiceType);

                objParam[7] = new SqlParameter("@CurentPage", currentPage);
                objParam[8] = new SqlParameter("@PageSize", pageSize);


                return _DbWorker.GetDataTable(ProcedureConstants.Campaign_Search, objParam);
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPagingList - CampaignDAL: " + ex.ToString());
            }
            return null;
        }

        public async Task<Campaign> GetDetailByCode(string campaign_code)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    return await _DbContext.Campaign.AsNoTracking().FirstOrDefaultAsync(s => s.CampaignCode == campaign_code);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetDetailByCode - CampaignDAL: " + ex.ToString());
                return null;
            }
        }
        public async Task<Campaign> GetDetailByID(int id)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    return await _DbContext.Campaign.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetDetailByID - CampaignDAL: " + ex.ToString());
                return null;
            }
        }
        
        public async Task<int> AddNew(Campaign campaign)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var add = _DbContext.Campaign.Add(campaign);
                    await _DbContext.SaveChangesAsync();
                    return campaign.Id;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("AddNew - CampaignDAL: " + ex.ToString());
                return -1;
            }
        }
        public async Task<int> Update(Campaign campaign)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var add = _DbContext.Campaign.Update(campaign);
                    await _DbContext.SaveChangesAsync();
                    return campaign.Id;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Update - CampaignDAL: " + ex.ToString());
                return -1;
            }
        }
        public int Delete(int campaignId)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var entity = _DbContext.Campaign.FirstOrDefault(n => n.Id == campaignId);
                    _DbContext.Campaign.Remove(entity);
                    _DbContext.SaveChanges();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Delete - CampaignDAL: " + ex.ToString());
                return -1;
            }
        }
        public async Task<int> CreateOrUpdateHotelCampaign(HotelPricePolicyDetailViewModel full_detail, int user_id)
        {
            int result = (int)ResponseType.FAILED;
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var id_campaign = full_detail.CampaignDetail.Id;
                    bool change_contract_type = false;
                    //-- If New Campaign
                    if (full_detail.CampaignDetail.Id > 0)
                    {
                        var exists = _DbContext.Campaign.FirstOrDefault(n => n.CampaignCode == full_detail.CampaignDetail.CampaignCode);
                        //exists.ClientTypeId = full_detail.CampaignDetail.ClientTypeId;
                        exists.Description = full_detail.CampaignDetail.Description;
                        exists.Status = full_detail.CampaignDetail.Status;
                        exists.UpdateLast = DateTime.Now;
                        exists.UserUpdateId = user_id;
                        exists.FromDate = full_detail.CampaignDetail.FromDate;
                        exists.ToDate = full_detail.CampaignDetail.ToDate;
                        if (exists.ContractType != full_detail.CampaignDetail.ContractType) change_contract_type = true;
                        exists.ContractType = full_detail.CampaignDetail.ContractType;
                        _DbContext.Campaign.Update(exists);
                        _DbContext.SaveChanges();

                        id_campaign = exists.Id;
                    }
                    else
                    {
                        var campaign = new Campaign();
                        campaign.CampaignCode = full_detail.CampaignDetail.CampaignCode;
                        campaign.UserCreateId = user_id;
                        campaign.CreateDate = DateTime.Now;
                        campaign.FromDate = new DateTime(DateTime.Now.Year, 01, 01);
                        campaign.ToDate = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
                        campaign.ClientTypeId = full_detail.CampaignDetail.ClientTypeId;
                        campaign.Description = full_detail.CampaignDetail.Description;
                        campaign.Status = full_detail.CampaignDetail.Status;
                        campaign.UpdateLast = DateTime.Now;
                        campaign.ContractType = full_detail.CampaignDetail.ContractType;
                        campaign.UserUpdateId = user_id;
                        campaign.FromDate = full_detail.CampaignDetail.FromDate;
                        campaign.ToDate = full_detail.CampaignDetail.ToDate;

                        _DbContext.Campaign.Add(campaign);
                        _DbContext.SaveChanges();
                        id_campaign = campaign.Id;
                    }

                    if (id_campaign < 1)
                    {
                        LogHelper.InsertLogTelegram("CreateOrUpdateHotelCampaign - CampaignDAL: Cannot Get ID campaign with - [" + JsonConvert.SerializeObject(full_detail.CampaignDetail) + "]");
                        return result;
                    }
                    //-- Delete All PriceDetail and ProductroomSerivce if change contract_type:
                    if (change_contract_type)
                    {
                        var exists_to_del = _DbContext.ProductRoomService.Where(n => n.CampaignId == id_campaign).ToList();
                        if (exists_to_del != null && exists_to_del.Count > 0)
                        {
                            foreach (var exists_item in exists_to_del)
                            {
                                var exists_to_del_2 = _DbContext.PriceDetail.Where(n => n.ProductServiceId == exists_item.Id).ToList();
                                foreach (var exists_item_2 in exists_to_del_2)
                                {
                                    _DbContext.PriceDetail.Remove(exists_item_2);
                                }
                                _DbContext.ProductRoomService.Remove(exists_item);
                            }

                        }
                    }
                    if (full_detail.ListPricePolicy != null && full_detail.ListPricePolicy.Count > 0)
                    {
                        //-- Delete All PriceDetail and ProductroomSerivce if change provider:

                        var exists_to_del = _DbContext.ProductRoomService.Where(n => n.CampaignId == id_campaign).ToList();
                        if (exists_to_del != null && exists_to_del.Count > 0 && exists_to_del[0].ProviderId != full_detail.ListPricePolicy[0].ProductService.ProviderId)
                        {
                            foreach (var exists_item in exists_to_del)
                            {
                                var exists_to_del_2 = _DbContext.PriceDetail.Where(n => n.ProductServiceId == exists_item.Id).ToList();
                                foreach (var exists_item_2 in exists_to_del_2)
                                {
                                    _DbContext.PriceDetail.Remove(exists_item_2);
                                }
                                _DbContext.ProductRoomService.Remove(exists_item);

                            }

                        }
                        //-- Delete All PriceDetail and ProductroomSerivce if change contract_type:
                        _DbContext.SaveChanges();
                        foreach (var product_service_room in full_detail.ListPricePolicy)
                        {
                            int product_service_id = product_service_room.ProductService.Id;

                            var exists = _DbContext.ProductRoomService.FirstOrDefault(n => n.Id == product_service_room.ProductService.Id);
                            if (exists == null || exists.Id < 1)
                            {
                                exists = _DbContext.ProductRoomService.FirstOrDefault(n => n.CampaignId == id_campaign && n.AllotmentsId == product_service_room.ProductService.AllotmentsId && n.PackageId == product_service_room.ProductService.PackageId
                                     && n.RoomId == product_service_room.ProductService.RoomId);
                                if (exists == null || exists.Id < 1)
                                {
                                    var product_service_detail = product_service_room.ProductService;
                                    ProductRoomService detail = new ProductRoomService()
                                    {
                                        AllotmentsId = product_service_detail.AllotmentsId,
                                        CampaignId = id_campaign,
                                        ContractNo = product_service_detail.ContractNo,
                                        GroupProviderType = product_service_detail.GroupProviderType,
                                        PackageId = product_service_detail.PackageId,
                                        ProviderId = product_service_detail.ProviderId,
                                        RoomId = product_service_detail.RoomId
                                    };
                                    _DbContext.ProductRoomService.Add(detail);
                                    _DbContext.SaveChanges();
                                    product_service_id = detail.Id;
                                }
                                else
                                {
                                    product_service_id = exists.Id;
                                }
                            }
                            if (product_service_id < 1)
                            {
                                LogHelper.InsertLogTelegram("CreateOrUpdateHotelCampaign - CampaignDAL: Cannot Get ID ProductRoomServices with - [" + JsonConvert.SerializeObject(product_service_room.ProductService + "]"));
                                return result;
                            }
                            if (product_service_room.PriceDetail != null && product_service_room.PriceDetail.Count > 0)
                            {
                                var exists_list_policy = _DbContext.PriceDetail.Where(x => x.ProductServiceId == product_service_id).ToList();
                                var excute_policy_list = new List<PriceDetail>();
                                foreach (var price_detail in product_service_room.PriceDetail)
                                {
                                    // Check & add/update PriceDetail
                                    PriceDetail priceDetail_exists = _DbContext.PriceDetail.Where(x => x.Id == price_detail.Id).FirstOrDefault();
                                    if (priceDetail_exists != null && priceDetail_exists.Id > 0)
                                    {
                                        priceDetail_exists.Price = price_detail.Price;
                                        priceDetail_exists.Profit = price_detail.Profit;
                                        priceDetail_exists.UnitId = price_detail.UnitId;
                                        priceDetail_exists.UserUpdateId = price_detail.UserUpdateId;
                                        priceDetail_exists.MonthList = price_detail.MonthList;
                                        priceDetail_exists.DayList = price_detail.DayList;
                                        priceDetail_exists.AmountLast = price_detail.AmountLast;
                                        priceDetail_exists.FromDate = price_detail.FromDate;
                                        priceDetail_exists.ToDate = price_detail.ToDate;
                                        priceDetail_exists.ProductServiceId = product_service_id;
                                        priceDetail_exists.ServiceType = price_detail.ServiceType;
                                        _DbContext.PriceDetail.Update(priceDetail_exists);
                                        _DbContext.SaveChanges();
                                        excute_policy_list.Add(priceDetail_exists);
                                    }
                                    else
                                    {
                                        var add_detail = new PriceDetail()
                                        {
                                            AmountLast = price_detail.AmountLast,
                                            DayList = price_detail.DayList,
                                            MonthList = price_detail.MonthList,
                                            UserUpdateId = user_id,
                                            FromDate = price_detail.FromDate,
                                            Price = price_detail.Price,
                                            ProductServiceId = product_service_id,
                                            Profit = price_detail.Profit,
                                            ServiceType = price_detail.ServiceType,
                                            ToDate = price_detail.ToDate,
                                            UnitId = price_detail.UnitId,
                                            UserCreateId = user_id
                                        };
                                        _DbContext.PriceDetail.Add(add_detail);
                                        _DbContext.SaveChanges();
                                        excute_policy_list.Add(add_detail);

                                    }

                                }
                                foreach (var exists_price_detail in exists_list_policy)
                                {
                                    if (!excute_policy_list.Select(x => x.Id).ToList().Contains(exists_price_detail.Id))
                                    {
                                        _DbContext.PriceDetail.Remove(exists_price_detail);
                                        _DbContext.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
                result = (int)ResponseType.SUCCESS;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("CreateOrUpdateHotelCampaign - CampaignDAL: " + ex.ToString());
                result = (int)ResponseType.ERROR;
            }
            return result;
        }
    }
}
