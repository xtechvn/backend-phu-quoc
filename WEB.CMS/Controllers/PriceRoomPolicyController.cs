using Caching.RedisWorker;
using Entities.Models;
using Entities.ViewModels.PricePolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;
using WEB.CMS.Customize;

namespace WEB.Adavigo.CMS.Controllers
{

    public partial class PricePolicyController : Controller
    {

      
        public async Task<IActionResult> RoomPricePolicy(string campaign_code,int campaign_id, int service_type)
        {
            HotelPricePolicyDetailViewModel model = new HotelPricePolicyDetailViewModel();
            model.ListPricePolicy = new List<HotelPricePolicyDetail>();
            model.CampaignDetail = new Campaign();
            model.CampaignDetail.Id = -1;
            model.CampaignDetail.FromDate = new DateTime(DateTime.Now.Year, 01, 01, 00, 00, 00);
            model.CampaignDetail.FromDate = new DateTime(DateTime.Now.Year + 1, 01, 01, 00, 00, 00);
            try
            {
                var customer_type_list = _allCodeRepository.GetListByType(AllCodeType.CLIENT_TYPE);
                if (customer_type_list != null && customer_type_list.Count > 0)
                {
                    customer_type_list = customer_type_list.OrderBy(o => o.CodeValue).ToList();
                }
                model.CustomerTypeList = customer_type_list;
                Campaign campaign = await _campaignRepository.GetDetailByID(campaign_id);
                if (campaign != null && campaign.Id > 0)
                {
                    model.CampaignDetail = campaign;
                   
                }
                else
                {
                    campaign = await _campaignRepository.GetDetailByCode(campaign_code);
                    if (campaign != null && campaign.Id > 0)
                    {
                        model.CampaignDetail = campaign;

                    }
                }
                
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("RoomPricePolicy - PricePolicyController: " + ex.ToString());

            }
            ViewBag.service_type = service_type;
            return PartialView(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> PolicyRule(int campaign_id)
        {
            HotelPricePolicyDetailViewModel model = new HotelPricePolicyDetailViewModel();
            model.ListPricePolicy = new List<HotelPricePolicyDetail>();
            model.CampaignDetail = new Campaign();
            model.CampaignDetail.Id = -1;
            model.CampaignDetail.FromDate= new DateTime(DateTime.Now.Year, 01, 01, 00, 00, 00);
            model.CampaignDetail.FromDate = new DateTime(DateTime.Now.Year + 1, 01, 01, 00, 00, 00);
            try
            {
                model = await _campaignRepository.GetPolicyDetailViewByCampaignID(campaign_id);
                if (model.ListPricePolicy.Count > 0)
                {
                    var new_list_price_policy = await _roomFunRepository.GetPolicyByProvider(model.CampaignDetail.Id, model.ListPricePolicy[0].ProductService.ProviderId, (short)model.CampaignDetail.ContractType);
                    var product_services_exists = model.ListPricePolicy.Select(x => x.ProductService).ToList();
                    if (new_list_price_policy.Count > 0)
                    {
                        foreach(var new_policy in new_list_price_policy)
                        {
                            if (!product_services_exists.Select(x=> new { room_id= x.RoomId,package_id=x.PackageId,allotment_id=x.AllotmentsId }).Contains(new { room_id= new_policy.ProductService.RoomId , package_id = new_policy.ProductService.PackageId, allotment_id = new_policy.ProductService.AllotmentsId }))
                            {
                                model.ListPricePolicy.Add(new_policy);
                            }
                        }
                    }
                    model.ListPricePolicy[0].ProductService.ProviderName = (await GetHotel(model.ListPricePolicy[0].ProductService.ProviderId)).name;
                    model.ListPricePolicy = model.ListPricePolicy.OrderBy(x => x.ProductService.ContractNo).ToList();
                    model.Filters = new List<HotelPricePolicyFilterModel>();
                    List<string> contract_no = model.ListPricePolicy.Select(x => x.ProductService.ContractNo).Distinct().ToList();
                    foreach (var contract in contract_no)
                    {
                        List<HotelRoomPackageDetailViewModel> package_list = new List<HotelRoomPackageDetailViewModel>();
                        List<string> package_list_in_contract = model.ListPricePolicy.Where(x => x.ProductService.ContractNo == contract).Select(x => x.ProductService.PackageId).Distinct().ToList();
                        foreach (var package_contract in package_list_in_contract)
                        {
                            package_list.Add(new HotelRoomPackageDetailViewModel()
                            {
                                package_id = package_contract,
                                package_name = model.ListPricePolicy.Where(x => x.ProductService.PackageId == package_contract).FirstOrDefault().ProductService.PackageName,
                                room_id = model.ListPricePolicy.Where(x => x.ProductService.PackageId == package_contract && x.ProductService.ContractNo == contract).OrderBy(x=>x.ProductService.RoomName).Select(x => new HotelRoomDetailFilterCMSModel {room_id=x.ProductService.RoomId,room_name=x.ProductService.RoomName}).Distinct().ToList()
                            });
                        }
                        model.Filters.Add(new HotelPricePolicyFilterModel()
                        {
                            ContractNo = contract.Trim(),
                            PackagesNameList = package_list
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("PolicyRule - PricePolicyController: " + ex.ToString());

            }
            return PartialView("~/Views/Shared/Components/PricePolicy/PolicyRule.cshtml",model);
        }
        [HttpPost]
        public async Task<IActionResult> GetPolicyRuleByProvider(int campaign_id, string provider_id,short contract_type)
        {
            HotelPricePolicyDetailViewModel model = new HotelPricePolicyDetailViewModel();
            model.ListPricePolicy = new List<HotelPricePolicyDetail>();
            model.Filters = new List<HotelPricePolicyFilterModel>();
            model.CampaignDetail = new Campaign();
            model.CampaignDetail.Id = -1;
            model.CampaignDetail.FromDate = new DateTime(DateTime.Now.Year, 01, 01, 00, 00, 00);
            model.CampaignDetail.ToDate = new DateTime((DateTime.Now.Year + 1), 01, 01, 00, 00, 00);
            try
            {
                Campaign campaign = await _campaignRepository.GetDetailByID(campaign_id);
                if (campaign != null && campaign.Id > 0)
                {
                    model.CampaignDetail = campaign;
                }
                
                var hotel = await GetHotel(provider_id);
                if(contract_type>2 || contract_type <= 0)
                {
                    model.CampaignDetail.ContractType = (short)hotel.group_provider_type;
                }
                else
                {
                    model.CampaignDetail.ContractType = (short)contract_type;
                }
                if (hotel != null && hotel.id!=null)
                {
                    if (hotel.group_provider_type == 2)
                    {
                        contract_type = (int)HotelContractType.Contract;
                        model.CampaignDetail.ContractType= (int)HotelContractType.Contract;
                    }
                    model.CampaignDetail.FromDate = new DateTime(DateTime.Now.Year, 01, 01, 00, 00, 00);
                    model.CampaignDetail.ToDate = new DateTime((DateTime.Now.Year + 1), 01, 01, 00, 00, 00);
                    model.ListPricePolicy = await _roomFunRepository.GetPolicyByProvider(model.CampaignDetail.Id,hotel.id, (short)model.CampaignDetail.ContractType);
                    foreach(var policy in model.ListPricePolicy)
                    {
                        var h= await GetHotel(policy.ProductService.ProviderId);
                        if(h!=null && h.id != null)
                        {
                            policy.ProductService.ProviderName = h.name;
                        }

                    }
                    if (model.ListPricePolicy.Count < 1)
                    {
                        model.ListPricePolicy.Add(new HotelPricePolicyDetail()
                        {
                            ProductService = new ProductRoomServiceCMSViewModel()
                            {
                                ProviderId = provider_id,
                                ProviderName = GetHotel(provider_id).Result.name

                            },
                            PriceDetail = new List<PriceDetail>()
                        });
                    }
                    //----------------- Filter
                    if (model.ListPricePolicy.Count > 0)
                    {
                        
                        model.ListPricePolicy = model.ListPricePolicy.OrderBy(x => x.ProductService.ContractNo).ToList();
                        List<string> contract_no = model.ListPricePolicy.Select(x => x.ProductService.ContractNo).Distinct().ToList();
                        foreach (var contract in contract_no)
                        {
                            if (contract != null)
                            {
                                List<HotelRoomPackageDetailViewModel> package_list = new List<HotelRoomPackageDetailViewModel>();
                                List<string> package_list_in_contract = model.ListPricePolicy.Where(x => x.ProductService.ContractNo == contract).Select(x => x.ProductService.PackageId).Distinct().ToList();
                                foreach (var package_contract in package_list_in_contract)
                                {
                                    package_list.Add(new HotelRoomPackageDetailViewModel()
                                    {
                                        package_id = package_contract,
                                        package_name = model.ListPricePolicy.Where(x => x.ProductService.PackageId == package_contract).FirstOrDefault().ProductService.PackageName,
                                        room_id = model.ListPricePolicy.Where(x => x.ProductService.PackageId == package_contract && x.ProductService.ContractNo == contract).OrderBy(x => x.ProductService.RoomName).Select(x => new HotelRoomDetailFilterCMSModel { room_id = x.ProductService.RoomId, room_name = x.ProductService.RoomName }).Distinct().ToList()
                                    });
                                }
                                model.Filters.Add(new HotelPricePolicyFilterModel()
                                {
                                    ContractNo = contract.Trim(),
                                    PackagesNameList = package_list
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("PolicyRule - PricePolicyController: " + ex.ToString());

            }
            return PartialView("~/Views/Shared/Components/PricePolicy/PolicyRule.cshtml", model);
        }

        

       
        [HttpPost]
        public async Task<IActionResult> GetHotelSuggestion(string keyword)
        {
            try
            {
               var hotel_list = await GetHotelList(keyword);
                ViewBag.VinHotel = hotel_list.Where(x => x.group_provider_type == (int)GroupProviderType.VIN).GroupBy(x => x.id).Select(x => x.First()).ToList();
                ViewBag.OthersHotel = hotel_list.Where(x => x.group_provider_type == (int)GroupProviderType.OthersHotel).GroupBy(x=>x.id).Select(x=>x.First()).ToList();
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetHotelSuggestion - PricePolicyController: " + ex.ToString());
            }
            return PartialView();
        }

        [HttpPost]
        public IActionResult NewPolicyRule(int level,int service_type)
        {
            ViewBag.level = level;
            ViewBag.service_type = service_type;
            return PartialView();

        }
       
        [HttpPost]
        public async Task<IActionResult> UpdatePricePolicyDetail(string data)
        {
            string message = "FAILED";
            int status = (int)ResponseType.FAILED;
            int price_id = -1;
            try
            {
                HotelPriceDetailSummitModel model = JsonConvert.DeserializeObject<HotelPriceDetailSummitModel>(data);
                if (model == null ||  model.CampaignID < -1 || model.ContractNo == null || model.ContractNo.Trim() == ""
                    || model.FromDate < new DateTime(2022, 01, 01, 00, 00, 00) || model.FromDate > new DateTime(2052, 12, 31, 23, 59, 59)
                    || model.ToDate < new DateTime(2022, 01, 01, 00, 00, 00) || model.ToDate > new DateTime(2052, 12, 31, 23, 59, 59) 
                    || model.FromDate>model.ToDate || model.UnitId < 0 || model.Profit<0 || model.Price<0)
                {
                    message = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại";
                    return Ok(new
                    {
                        status = status,
                        message = message
                    });
                }
                int userId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                ProductRoomService productRoomService = new ProductRoomService()
                {
                    Id=model.ProductServiceId,
                    PackageId = model.PackageId,
                    ProviderId = model.ProviderID,
                    RoomId = model.RoomID,
                    CampaignId = model.CampaignID,
                    ContractNo = model.ContractNo,
                    GroupProviderType = model.GroupProviderType,
                    AllotmentsId = model.AllotmentsId,
                };
                switch (model.UnitId)
                {
                    case (int)HotelUnitID.Percent:
                        {
                            model.AmountLast = (double)(model.Price * (100 + model.Profit) / 100);
                            if (model.AmountLast < 0 || model.AmountLast < model.Price) {
                                message = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại";
                                return Ok(new
                                {
                                    status = status,
                                    message = message
                                });
                            }

                        }
                        break;
                    case (int)HotelUnitID.VND:
                        {
                            model.AmountLast = model.Price + model.Profit;
                            if (model.AmountLast < 0 || model.AmountLast < model.Price)
                            {
                                message = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại";
                                return Ok(new
                                {
                                    status = status,
                                    message = message
                                });
                            }
                        }
                        break;
                }
                PriceDetail detail = new PriceDetail()
                {
                    Id=model.PriceDetailID,
                    AmountLast = model.AmountLast,
                    FromDate = model.FromDate,
                    ToDate = model.ToDate,
                    Price = model.Price,
                    Profit = model.Profit,
                    UserUpdateId = userId,
                    UnitId = (short)model.UnitId,
                    ServiceType = (short)model.ServiceType,
                    DayList = "",
                    MonthList = "",
                    ProductServiceId= model.ProductServiceId,
                    UserCreateId= userId
                };
                var result_db = await _priceDetailRepository.AddOrUpdateSinglePriceDetail(productRoomService, detail,userId);
                price_id = detail.Id;
                switch (result_db.Trim())
                {
                    case "Campaign not found":
                        {
                            //message = "Chiến dịch mới chưa được lưu, vui lòng nhấn vào nút [Lưu] bên dưới để lưu chiến dịch trước";
                            message = "Cập nhật chính sách giá thành công";
                            status = (int)ResponseType.SUCCESS;

                        } break;
                    case "":
                        {
                            message = "Cập nhật chính sách giá thành công";
                            status = (int)ResponseType.SUCCESS;
                        }
                        break;
                    default:
                        {
                            message = "Cập nhật chính sách giá thất bại";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                status = (int)ResponseType.ERROR;
                message = "Lỗi khi xử lý, vui lòng liên hệ bộ phận kỹ thuật";
                LogHelper.InsertLogTelegram("UpdatePricePolicyDetail - PricePolicyController: " + ex.ToString());
            }
            return Ok(new
            {
                status = status,
                msg = message,
                price_id= price_id
            });
        }
        [HttpPost]
        public async Task<IActionResult> SummitHotelCampaignData(string data)
        {
            string message = "";
            int status = (int)ResponseType.FAILED;
            try
            {
                HotelPricePolicyDetailViewModel model = JsonConvert.DeserializeObject<HotelPricePolicyDetailViewModel>(data);
                if (model == null || model.CampaignDetail.CampaignCode==null || model.CampaignDetail.CampaignCode.Trim() =="" || model.CampaignDetail.ClientTypeId<1  || model.CampaignDetail.Status <0
                    || model.CampaignDetail.Status > 1
                    || model.CampaignDetail.FromDate == DateTime.MinValue || model.CampaignDetail.FromDate == DateTime.MaxValue 
                    || model.CampaignDetail.ToDate == DateTime.MinValue || model.CampaignDetail.ToDate == DateTime.MaxValue
                    || model.CampaignDetail.ContractType < 0
                    || model.CampaignDetail.UserCreateId < -1)
                {
                    message = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại";
                    return Ok(new
                    {
                        status = status,
                        message = message
                    });
                }
                Regex.Replace(model.CampaignDetail.Description, @"[#$%&'()*+/<=>@[\\\]^_`{|}~]+", "");
                //-- Check campaign date:
                


                if (model.CampaignDetail.Id < 0)
                {
                    var exists_campaign = await _campaignRepository.GetDetailByCode(model.CampaignDetail.CampaignCode);
                    if (exists_campaign != null && exists_campaign.Id > 0)
                    {
                        message = "Chiến dịch [" + model.CampaignDetail.CampaignCode + "] đã tồn tại, vui lòng thêm mã chiến dịch khác.";
                        return Ok(new
                        {
                            status = status,
                            message = message
                        });
                    }
                }
                int userId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    userId = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                short validate_status = 0;
                if(model.ListPricePolicy!=null && model.ListPricePolicy.Count > 0)
                {
                    var provider = await GetHotel(model.ListPricePolicy[0].ProductService.ProviderId);
                    if(provider == null || provider.id!= model.ListPricePolicy[0].ProductService.ProviderId)
                    {
                        validate_status = 3;
                    }
                    foreach (var policy in model.ListPricePolicy)
                    {
                        if(policy.ProductService.ProviderId != model.ListPricePolicy[0].ProductService.ProviderId || policy.ProductService.GroupProviderType!= model.ListPricePolicy[0].ProductService.GroupProviderType)
                        {
                            validate_status = 3;
                            break;
                        }
                        if (policy.PriceDetail != null && policy.PriceDetail.Count > 0)
                        {
                            foreach (var price_detail in policy.PriceDetail)
                            {
                                if (price_detail.FromDate < model.CampaignDetail.FromDate)
                                {
                                    validate_status = 1; break;
                                }
                                else if (price_detail.ToDate > model.CampaignDetail.ToDate)
                                {
                                    validate_status = 2; break;
                                }
                                switch (price_detail.UnitId)
                                {
                                    case (int)HotelUnitID.Percent:
                                        {
                                            price_detail.AmountLast = (double)(price_detail.Price * (100 + price_detail.Profit) / 100);
                                            if (price_detail.AmountLast < 0 || price_detail.AmountLast < price_detail.Price) validate_status = 3;
                                        }
                                        break;
                                    case (int)HotelUnitID.VND:
                                        {
                                            price_detail.AmountLast = price_detail.Price + price_detail.Profit;
                                            if (price_detail.AmountLast < 0 || price_detail.AmountLast < price_detail.Price) validate_status = 3;
                                        }
                                        break;
                                }
                                if (price_detail.Price < 0 || price_detail.Profit < 0 || price_detail.AmountLast < 0)
                                {
                                    validate_status = 3;
                                    break;
                                }
                            }
                        }
                        if (validate_status != 0)
                        {
                            break;
                        }
                    }
                    switch (validate_status)
                    {
                        case 1:
                            {
                                message = "Ngày bắt đầu hiệu lực chính sách giá không được nhỏ hơn ngày bắt đầu hiệu lực chiến dịch";
                                return Ok(new
                                {
                                    status = status,
                                    message = message
                                });
                            }
                        case 2:
                            {
                                message = "Ngày kết thúc hiệu lực chính sách giá không được lớn ngày kết thúc hiệu lực chiến dịch";
                                return Ok(new
                                {
                                    status = status,
                                    message = message
                                });
                            }
                        case 3:
                            {
                                message = "Dữ liệu gửi lên không chính xác, vui lòng thử lại";
                                return Ok(new
                                {
                                    status = status,
                                    message = message
                                });
                            }
                    }

                }
                

                status = await _campaignRepository.CreateOrUpdateHotelCampaign(model, userId);
                if (status == (int)ResponseType.SUCCESS)
                {
                    message = "Lưu chính sách giá thành công";
                    _redisService.FlushDatabaseByIndex(Convert.ToInt32(_configuration["Redis:Database:db_search_result"]));

                }
                else
                {
                    message = "Lưu chính sách giá thất bại";

                }
            }
            catch (Exception ex)
            {
                status = (int)ResponseType.ERROR;
                message = "Lỗi khi xử lý, vui lòng liên hệ bộ phận kỹ thuật";
                LogHelper.InsertLogTelegram("SummitHotelCampaignData - PricePolicyController: " + ex.ToString());
            }
            return Ok(new
            {
                status = status,
                message = message
            });
        }
        [HttpPost]
        public async Task<IActionResult> RemovePriceDetail(int id)
        {
            string message = "";
            int status = (int)ResponseType.FAILED;
            try
            {
                if (id <= 0)
                {
                    status = (int)ResponseType.SUCCESS;
                    message = "Xóa chính sách giá thành công.";
                }
                else
                {
                    status = await _priceDetailRepository.RemoveByID(id);
                   if (status == (int)ResponseType.SUCCESS)
                   {
                        message = "Xóa chính sách giá thành công.";

                    }
                    else
                    {
                        message = "Xóa chính sách giá thất bại.";
                    }
                }
            }
            catch (Exception ex)
            {
                status = (int)ResponseType.ERROR;
                message = "Lỗi khi xử lý, vui lòng liên hệ bộ phận kỹ thuật";
                LogHelper.InsertLogTelegram("RemovePriceDetail - PricePolicyController: " + ex.ToString());
            }
            return Ok(new
            {
                status = status,
                message = message
            });
        }
        private async Task<HotelInfomation> GetHotel(string provider_id)
        {
            HotelInfomation hotelInfomation = null;
            try
            {
                var cache_name = CacheName.PROVIDER_LIST;
                string j_data = await _redisService.GetAsync(cache_name, Convert.ToInt32(_configuration["Redis:Database:db_common"]));
                //-- From Redis
                if (j_data != null && j_data.Trim() != "" && j_data.Trim() != "[]")
                {
                    var list_all = JsonConvert.DeserializeObject<List<HotelInfomation>>(j_data);
                    hotelInfomation = list_all.Where(x => x.id == provider_id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetHotel - PricePolicyController: " + ex);
            }
            return hotelInfomation;
        }
        private async Task<List<HotelInfomation>> GetHotelList(string keyword)
        {
            List<HotelInfomation> hotelInfomation = new List<HotelInfomation>();
            if (keyword == null) keyword = "";
            try
            {
                var cache_name = CacheName.PROVIDER_LIST;
                string j_data = await _redisService.GetAsync(cache_name, Convert.ToInt32(_configuration["Redis:Database:db_common"]));
                //-- From Redis
                if (j_data != null && j_data.Trim() != "" && j_data.Trim() != "[]")
                {
                    var list_all = JsonConvert.DeserializeObject<List<HotelInfomation>>(j_data);
                    hotelInfomation = list_all.Where(x => CommonHelper.RemoveUnicode(x.name).ToLower().Contains(CommonHelper.RemoveUnicode(keyword).ToLower())).ToList();
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetHotelList - PricePolicyController: " + ex);
            }
            return hotelInfomation;
        }
    }

}
