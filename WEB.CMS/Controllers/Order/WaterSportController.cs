using Caching.Elasticsearch;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.ElasticSearch;
using Entities.ViewModels.OrderManual;
using Entities.ViewModels.SportWater;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using Repositories.IRepositories;
using Repositories.Repositories;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using ThirdParty.Json.LitJson;
using Utilities;
using Utilities.Contants;
using WEB.Adavigo.CMS.Service;
using WEB.CMS.Models;
using static MongoDB.Libmongocrypt.CryptContext;

namespace WEB.Adavigo.CMS.PQ.Controllers.Order
{
    public class WaterSportController : Controller
    {
        private readonly ISportWaterGuestsRepository _sportWaterGuestsRepository;
        private readonly IConfiguration _configuration;
        private HotelESRepository _hotelESRepository;
        private readonly IAllCodeRepository _allCodeRepository;
        private IOtherBookingRepository _otherBookingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IndentiferService indentiferService;
        private readonly IOrderRepository _orderRepository;
        private readonly IIdentifierServiceRepository _identifierServiceRepository;
        private readonly IAccountClientRepository _accountClientRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly IClientRepository _clientRepository;
        public WaterSportController(ISportWaterGuestsRepository sportWaterGuestsRepository, IConfiguration configuration, IAllCodeRepository allCodeRepository, IOtherBookingRepository otherBookingRepository,
            IUserRepository userRepository, IOrderRepository orderRepository, IIdentifierServiceRepository identifierServiceRepository, IAccountClientRepository accountClientRepository, IPassengerRepository passengerRepository, IClientRepository clientRepository)
        {
            _sportWaterGuestsRepository = sportWaterGuestsRepository;
            _configuration = configuration;
            _hotelESRepository = new HotelESRepository(_configuration["DataBaseConfig:Elastic:Host"]);
            _allCodeRepository = allCodeRepository;
            _otherBookingRepository = otherBookingRepository;
            _userRepository = userRepository;
            indentiferService = new IndentiferService(configuration);
            _orderRepository = orderRepository;
            _identifierServiceRepository = identifierServiceRepository;
            _accountClientRepository = accountClientRepository;
            _passengerRepository = passengerRepository;
            _clientRepository = clientRepository;
        }
        public async Task<IActionResult> Index()
        {

            var clientid = _configuration["Config:Client_id"];
            var client = await _clientRepository.GetClientDetailByClientId(Convert.ToInt32(clientid));
            ViewBag.client = client;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Search(WaterSportSearchModel searchModel)
        {
            var model = new GenericViewModel<SportWaterGuestsViewModel>();
            try
            {
                //var clientid = _configuration["Config:Client_id"];
                //if (searchModel.ClientId == null)
                //{
                //    searchModel.ClientId = clientid;
                //}
                model = await _sportWaterGuestsRepository.GetPagingList(searchModel);

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - WaterSportController: " + ex);
            }
            return PartialView(model);
        }
        public async Task<IActionResult> ImportWSExcel()
        {
            var clientid = _configuration["Config:Client_id"];
            var client = await _clientRepository.GetClientDetailByClientId(Convert.ToInt32(clientid));
            ViewBag.client = client;
            return PartialView();

        }
        [HttpPost]
        public async Task<IActionResult> ImportWSExcelListing(IFormFile file)
        {

            try
            {
                var stream = new MemoryStream();
                await file.CopyToAsync(stream);
                var data_list = new List<WaterSportExcelImportModel>();
                List<AllCode> all_code_ws = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = LicenseContext.Commercial;
                    ExcelWorksheet ws = package.Workbook.Worksheets.FirstOrDefault();

                    var endRow = ws.Cells.End.Row;
                    var startRow = 4;
                    var TotalRooms = "Total Rooms";

                    for (int row = startRow; row <= endRow; row++)
                    {
                        var cellRange = ws.Cells[row, 1, row, 5];
                        var isRowEmpty = cellRange.All(c => c.Value == null);
                        if (isRowEmpty)
                        {
                            break;
                        }
                        var roomno = ws.Cells[row, 1].Value;
                        var user_name = ws.Cells[row, 2].Value;
                        var nationalcode = ws.Cells[row, 3].Value;
                        var startDate = ws.Cells[row, 4].Value != null ? ws.Cells[row, 4].Value.ToString() : null;
                        var endDate = ws.Cells[row, 5].Value != null ? ws.Cells[row, 5].Value.ToString() : null;

                        string national_name = string.Empty;
                        var national_id = 0;
                        if (nationalcode != null)
                        {
                            var national_data = await _sportWaterGuestsRepository.GetDetailNationalByCode(nationalcode.ToString());
                            national_id = national_data != null ? national_data.Id : 0;
                            national_name = national_data != null ? national_data.Name : "";
                            ViewBag.msg = "quốc tịch";

                        }
                        var data = new WaterSportExcelImportModel
                        {

                            roomno = roomno == null ? "" : roomno.ToString(),
                            national_id = national_id,
                            national_name = national_name,
                            national_code = nationalcode == null ? "" : nationalcode.ToString(),
                            username = user_name == null ? "" : user_name.ToString(),
                            //startDate = startDate == null ? DateTime.MinValue : Convert.ToDateTime(startDate.ToString()),
                            //endDate = endDate == null ? DateTime.MinValue : Convert.ToDateTime(endDate.ToString()),

                        };
                        bool convert_date = false;
                        if (startDate != null && endDate != null)
                        {
                            try
                            {

                                data.startDate = DateTime.ParseExact(startDate.Split(" ")[0], "d/M/yyyy", null);
                                data.endDate = DateTime.ParseExact(endDate.Split(" ")[0], "d/M/yyyy", null);
                                convert_date = true;
                            }
                            catch
                            {

                            }
                            if (!convert_date)
                            {
                                try
                                {

                                    data.startDate = Convert.ToDateTime(startDate);
                                    data.endDate = Convert.ToDateTime(endDate);
                                    convert_date = true;
                                }
                                catch
                                {
                                }
                            }
                            if (!convert_date)
                            {
                                try
                                {
                                    data.startDate = DateTime.FromOADate(Convert.ToDouble(startDate));
                                    data.endDate = DateTime.FromOADate(Convert.ToDouble(endDate));
                                    convert_date = true;
                                }
                                catch
                                {
                                    return PartialView();
                                }
                            }
                        }
                        data_list.Add(data);
                    }



                }

                ViewBag.CheckedAll = true;
                return PartialView(data_list);
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ImportWSExcelListing - WaterSportController: " + ex.ToString());
                return PartialView();
            }
        }
        [HttpPost]
        public async Task<IActionResult> ImportWSExcelUpload(string jsonData)
        {
            var status = (int)ResponseType.ERROR;
            var msg = "Upload file không thành công";
            try
            {
                List<WaterSportExcelModel> model = JsonConvert.DeserializeObject<List<WaterSportExcelModel>>(jsonData);
                List<WaterSportExcelModel> data = new List<WaterSportExcelModel>();
                var _UserLogin = 0;

                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserLogin = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (model != null)
                {

                    try
                    {

                        await _sportWaterGuestsRepository.InsertSportWaterGuests(model, _UserLogin);
                        status = (int)ResponseType.SUCCESS;
                        msg = "Upload file thành công";
                    }
                    catch (Exception ex)
                    {
                        LogHelper.InsertLogTelegram("ConfirmUploadWSOrder - WaterSportController: " + ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ConfirmUploadWSOrder - WaterSportController: " + ex.ToString());
            }
            return Ok(new
            {
                status = status,
                msg = msg,

            });

        }
        [HttpPost]
        public async Task<IActionResult> AddWaterSportService(List<string> ListId, long ClientId)
        {
            try
            {
                ViewBag.ServiceType = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
                var listids = string.Join(',', ListId);
                ViewBag.User = null;
                ViewBag.Booking = null;
                ViewBag.IsOrderManual = false;
                ViewBag.AllowToEdit = true;
                ViewBag.listid = listids;
                if (ClientId == 0)
                {
                    var client = await _sportWaterGuestsRepository.GetListSportWaterGuestsByIds(listids);
                    ClientId = client != null ? client[0].ClientId : 0;
                }
                ViewBag.ClientId = ClientId;
                var data = await _sportWaterGuestsRepository.GetListSportWaterGuestsByIds(listids);
                if (data != null)
                {
                    if (data.Max(s => s.EndDate) < DateTime.Now)
                    {
                        ViewBag.MsgErr = 1;
                    }
                    ViewBag.data = data;
                    ViewBag.Room = data[0].RoomNo;
                }


            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("AddWaterSportService - WaterSportController: " + ex.ToString());
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWaterSportServicePackages(long booking_id)
        {
            ViewBag.ExtraList = new List<OtherBookingPackages>();
            ViewBag.ServiceType = new List<AllCode>();
            ViewBag.FLOATING_HOUSE = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_FLOATING_HOUSE);
            ViewBag.Booking = new OtherBooking();
            try
            {
                ViewBag.price = 0;
                var ListSportWaterPackages = await _sportWaterGuestsRepository.GetListSportWaterPackages();
                if (ListSportWaterPackages != null)
                {
                    var detail = ListSportWaterPackages.FirstOrDefault(s => s.SportWaterId == 1 && s.DurationType == 1);
                    ViewBag.price = detail.Price;
                }
                ViewBag.ServiceType = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
                ViewBag.Booking = await _otherBookingRepository.GetWaterSportById(booking_id);

                if (booking_id > 0)
                {
                    var list = await _otherBookingRepository.GetWaterSportPackagesByBookingId(booking_id);
                    if (list != null)
                    {
                        ViewBag.ExtraList = list;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("AddWaterSportServicePackages - WaterSportController: " + ex.ToString());
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWaterSportType()
        {
            return Ok(new
            {
                data = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE)
            });
        }
        [HttpPost]
        public async Task<IActionResult> UserSuggestion(string txt_search)
        {

            try
            {
                long _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt64(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (txt_search == null) txt_search = "";
                //var data = await _userESRepository.GetUserSuggesstion(txt_search);
                var data = new List<UserESViewModel>();
                if (data == null || data.Count <= 0)
                {
                    var data_sql = await _userRepository.GetUserSuggesstion(txt_search);
                    //data = new List<UserESViewModel>();
                    if (data_sql != null && data_sql.Count > 0)
                    {
                        data.AddRange(data_sql.Select(x => new UserESViewModel() { email = x.Email, fullname = x.FullName, id = x.Id, phone = x.Phone, username = x.UserName, _id = x.Id }));
                    }
                }
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    data = data,
                    selected = _UserId
                });

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("UserSuggestion - WaterSportController: " + ex.ToString());
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    data = new List<CustomerESViewModel>()
                });
            }

        }
        [HttpPost]
        public async Task<IActionResult> SummitwatersportServicePackages(OrderManualWaterSportBookingServiceSummitModel data, List<string> passenger, long client_id)
        {
            try
            {
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (data.service_code == null || data.service_code.Trim() == "")
                {
                    data.service_code = await indentiferService.GetServiceCodeByType((int)ServiceType.Other);
                }
                Entities.Models.Order order = new Entities.Models.Order()
                {
                    OrderNo = await _identifierServiceRepository.buildOrderNoManual(1),
                    SalerId = _UserId,
                    SalerGroupId = null,
                    Note = "Thể thao biển",

                    UserUpdateId = _UserId,
                    CreatedBy = _UserId,
                    CreateTime = DateTime.Now,
                    UpdateLast = DateTime.Now,
                    ClientId = client_id,
                    AccountClientId = _accountClientRepository.GetMainAccountClientByClientId(client_id),
                    SystemType = (int)SystemType.Backend,
                    OrderStatus = (int)OrderStatus.CREATED_ORDER,
                    PaymentStatus = (int)PaymentStatus.UNPAID,
                    ExpriryDate = DateTime.Now.AddMonths(1),
                    StartDate = null,
                    EndDate = null,
                    Amount = 0,
                    Label = "Thể thao biển",
                };
                var exists = await _orderRepository.GetOrderByOrderNo(order.OrderNo);
                if (exists != null && exists.OrderId > 0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.FAILED,
                        msg = "Mã đơn hàng đã tồn tại,vui lòng thử lại.",
                        order_id = -1
                    });
                }
                var result = await _orderRepository.CreateOrder(order);
                var orderdetail = await _orderRepository.GetOrderByOrderNo(order.OrderNo);
                if (orderdetail != null) data.order_id = orderdetail.OrderId;
                int service_status = (int)ServiceStatus.OnExcution;
                double total_amount = 0;
                if (data.id <= 0)
                {
                    service_status = (int)ServiceStatus.New;
                    total_amount += data.packages.Sum(x => x.amount);
                }
                else
                {
                    var exists_booking = await _otherBookingRepository.GetWaterSportById(data.id);
                    service_status = exists_booking.Status;
                    total_amount += data.packages.Sum(x => x.amount);
                    double total_exists_other_amount = exists_booking.Amount;
                    total_amount -= total_exists_other_amount;

                }
                bool is_allow_to_edit = false;

                var id = await _otherBookingRepository.SummitWaterSportBooking(data, _UserId);
                #region Update Order Amount:
                await _orderRepository.UpdateOrderDetail(data.order_id, _UserId);
                await _orderRepository.ReCheckandUpdateOrderPayment(data.order_id);
                var addpassenger = _passengerRepository.InsertPassenger(string.Join("/", passenger), data.order_id, id > 0 ? id : 0);

                #endregion



                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Thêm mới  dịch vụ thành công",
                    data = data.order_id
                });
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("SummitOtherServicePackages - WaterSportController: " + ex.ToString());
            }
            return Ok(new
            {
                status = (int)ResponseType.FAILED,
                msg = "Thêm mới  dịch vụ thất bại, vui lòng liên hệ IT"
            });
        }
        public async Task<IActionResult> ClientSuggestion(string txt_search, int type = 0)
        {

            try
            {
                if (string.IsNullOrEmpty(txt_search))
                {
                    var es_serviceClient = new esService(_configuration);
                    var data_Clientl = await es_serviceClient.search(AgencyType.NGUOI_DD.ToString(), "searchClientByAgencyType.json");
                    if (data_Clientl != "{}")
                    {
                        //var es_result =// ((RestSharp.RestResponseBase)find_hotel).Content;                       

                        JObject jsonObject = JObject.Parse(data_Clientl);
                        var hits = (JArray)jsonObject["hits"]["hits"];
                        var Clientl_result = new List<earchClientESViewModel>();
                        foreach (var hit in hits)
                        {
                            var source = JsonConvert.DeserializeObject<earchClientESViewModel>(hit["_source"].ToString());
                            if (type == AgencyType.NGUOI_DD)
                            {
                                if (source.agencytype == AgencyType.NGUOI_DD)
                                {
                                    Clientl_result.Add(source);
                                }
                            }
                            else
                            {
                                Clientl_result.Add(source);
                            }

                        }

                        return Ok(new
                        {
                            status = (int)ResponseType.SUCCESS,
                            data = Clientl_result,
                        });
                    }
                }
                else
                {
                    bool isUnicode = Encoding.ASCII.GetByteCount(txt_search) != Encoding.UTF8.GetByteCount(txt_search);


                    byte[] utfBytes = Encoding.UTF8.GetBytes(txt_search.Trim());
                    txt_search = Encoding.UTF8.GetString(utfBytes);
                }

                var es_service = new esService(_configuration);
                var data_hotel = await es_service.search(txt_search, "searchClient.json");
                if (data_hotel != "{}")
                {
                    //var es_result =// ((RestSharp.RestResponseBase)find_hotel).Content;                       

                    JObject jsonObject = JObject.Parse(data_hotel);
                    var hits = (JArray)jsonObject["hits"]["hits"];
                    var hotel_result = new List<earchClientESViewModel>();
                    foreach (var hit in hits)
                    {
                        var source = JsonConvert.DeserializeObject<earchClientESViewModel>(hit["_source"].ToString());
                        if (type == AgencyType.NGUOI_DD)
                        {
                            if (source.agencytype == AgencyType.NGUOI_DD)
                            {
                                hotel_result.Add(source);
                            }
                        }
                        else
                        {
                            hotel_result.Add(source);
                        }

                    }

                    return Ok(new
                    {
                        status = (int)ResponseType.SUCCESS,
                        data = hotel_result,
                    });
                    //var data = await _clientESRepository.GetClientSuggesstion2(txt_search);

                }
                else
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.EMPTY,
                        msg = "Không có dữ liệu nào thỏa mãn từ khóa " + txt_search
                    });
                }
                //var data = await _clientESRepository.GetClientSuggesstion(txt_search);
                //return Ok(new
                //{
                //    status = (int)ResponseType.SUCCESS,
                //    data = data,
                //});

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ClientSuggestion - WaterSportController: " + ex);
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    data = new List<CustomerESViewModel>()
                });
            }

        }
        public async Task<IActionResult> GetPriceSportWaterPackage(long id, long type)
        {
            try
            {
                var data = await _sportWaterGuestsRepository.GetListSportWaterPackages();
                if (data != null)
                {
                    var detail = data.FirstOrDefault(s => s.SportWaterId == id && s.DurationType == type);
                    return Ok(new
                    {
                        status = (int)ResponseType.SUCCESS,
                        price = detail != null ? detail.Price.ToString("N0") : "0"
                    });
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPriceSportWaterPackage - WaterSportController: " + ex.ToString());

            }
            return Ok(new
            {
                status = (int)ResponseType.FAILED,
                price = 0
            });
        }
        [HttpPost]
        public async Task<IActionResult> WaterSportTypeSuggesstion(int id)
        {
            string txt_search = "";
            try
            {
                switch (id)
                {
                    case WaterSportType.WATER_SPORT_FLOATING_HOUSE:
                        {
                            txt_search = AllCodeType.WATER_SPORT_FLOATING_HOUSE;

                        }
                        break;
                    case WaterSportType.WATER_SPORT_JETSKI:
                    case WaterSportType.WATER_SPORT_JETSKI2:
                        {
                            txt_search = AllCodeType.WATER_SPORT_JETSKI;
                        }
                        break;
                    case WaterSportType.WATER_SPORT_PARASAILING:
                        {
                            txt_search = AllCodeType.WATER_SPORT_PARASAILING;
                        }
                        break;
                    case WaterSportType.WATER_SPORT_FLY_FISH:
                        {
                            txt_search = AllCodeType.WATER_SPORT_FLY_FISH;
                        }
                        break;
                    case WaterSportType.WATER_SPORT_BANANA_BOAT:
                        {
                            txt_search = AllCodeType.WATER_SPORT_BANANA_BOAT;
                        }
                        break;
                    case WaterSportType.WATER_SPORT_KAYAK:
                        {
                            txt_search = AllCodeType.WATER_SPORT_KAYAK;
                        }
                        break;
                }
                var data = _allCodeRepository.GetListByType(txt_search);
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    data = data
                });


            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("WaterSportTypeSuggesstion - WaterSportController: " + ex.ToString());
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    data = new List<CustomerESViewModel>()
                });
            }

        }

    }
}
