﻿using Caching.Elasticsearch;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.SetServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;
using WEB.Adavigo.CMS.Service;
using WEB.CMS.Customize;

namespace WEB.Adavigo.CMS.Controllers.SetService.WaterSport
{

    public class SetServiceController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IOrderRepositor _orderRepository;
        private readonly IOrderRepository _orderRepository2;
        private readonly IContactClientRepository _contactClientRepository;
        private readonly OrderESRepository _orderESRepository;
        private readonly FlyBookingESRepository _flyBookingESRepository;
        private readonly IAllCodeRepository _allCodeRepository;
        private readonly IUserRepository _userRepository;
        private UserESRepository _userESRepository;
        private IndentiferService _indentiferService;
        private IPassengerRepository _passengerRepository;
        private IAirlinesRepository _airlinesRepository;
        private readonly IPaymentRequestRepository _paymentRequestRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IOtherBookingRepository _otherBookingRepository;
        private ManagementUser _ManagementUser;
        private APIService apiService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IHotelBookingCodeRepository _hotelBookingCodeRepository;

        public SetServiceController(IConfiguration configuration, IOrderRepositor orderRepository, IAllCodeRepository allcodeRepository, IContactClientRepository contactClientRepository,
           IUserRepository userRepository, IPassengerRepository passengerRepository, IAirlinesRepository airlinesRepository, IOtherBookingRepository otherBookingRepository,
           IPaymentRequestRepository paymentRequestRepository, ISupplierRepository supplierRepository, IOrderRepository orderRepository2, IWebHostEnvironment WebHostEnvironment,
           ManagementUser managementUser, IHotelBookingCodeRepository hotelBookingCodeRepository)
        {

            _configuration = configuration;
            _orderRepository = orderRepository;
            _contactClientRepository = contactClientRepository;
            _orderESRepository = new OrderESRepository(_configuration["DataBaseConfig:Elastic:Host"]);
            _flyBookingESRepository = new FlyBookingESRepository(_configuration["DataBaseConfig:Elastic:Host"]);
            _allCodeRepository = allcodeRepository;
            _userESRepository = new UserESRepository(_configuration["DataBaseConfig:Elastic:Host"]);
            _indentiferService = new IndentiferService(configuration);
            _userRepository = userRepository;
            _passengerRepository = passengerRepository;
            _airlinesRepository = airlinesRepository;
            _paymentRequestRepository = paymentRequestRepository;
            _supplierRepository = supplierRepository;
            _orderRepository2 = orderRepository2;
            _otherBookingRepository = otherBookingRepository;
            _ManagementUser = managementUser;
            apiService = new APIService(configuration, userRepository);
            _WebHostEnvironment = WebHostEnvironment;
            _hotelBookingCodeRepository = hotelBookingCodeRepository;
        }
        public IActionResult WaterSports()
        {
            try
            {
                var allcode_list = _allCodeRepository.GetListByType(AllCodeType.BOOKING_HOTEL_ROOM_STATUS);
                ViewBag.status = allcode_list.Where(x => x.CodeValue != (int)ServiceStatus.New).ToList();
            }catch(Exception ex)
            {
                LogHelper.InsertLogTelegram("WaterSports - SetServiceWaterSportController: " + ex);

            }
            return View();
        }
        public async Task<IActionResult> WaterSportSearch(SearchFlyBookingViewModel searchModel)
        {
            ViewBag.Model = new GenericViewModel<OtherBookingSearchViewModel>();

            try
            {
                if (searchModel == null) searchModel = new SearchFlyBookingViewModel();
                if (searchModel.pageSize <= 0) searchModel.pageSize = 30;
                if (searchModel.PageIndex <= 0) searchModel.PageIndex = 1;
                if (searchModel.StatusBooking == null || searchModel.StatusBooking.Trim() == "")
                {
                    var s = _allCodeRepository.GetListByType(AllCodeType.BOOKING_HOTEL_ROOM_STATUS).Where(x => x.CodeValue != (int)ServiceStatus.New).Select(x => x.CodeValue);
                    searchModel.StatusBooking = string.Join(",", s);
                }
                if (searchModel.StartDateFrom != null && (searchModel.StartDateTo == null || searchModel.StartDateTo < searchModel.StartDateFrom)) searchModel.StartDateTo = searchModel.StartDateFrom;
                if (searchModel.EndDateFrom != null && (searchModel.EndDateTo == null || searchModel.EndDateTo < searchModel.EndDateFrom)) searchModel.EndDateTo = searchModel.EndDateFrom;
                if (searchModel.StartDateTo < searchModel.EndDateFrom && searchModel.StartDateTo < searchModel.EndDateTo)
                {
                    searchModel.StartDateTo = null;
                    searchModel.EndDateFrom = null;
                }
                var current_user = _ManagementUser.GetCurrentUser();
                if (current_user != null)
                {
                    if (current_user.Role != "")
                    {
                        var list = current_user.Role.Split(',');
                        foreach (var item in list)
                        {
                            bool is_admin_or_department = false;
                            switch (Convert.ToInt32(item))
                            {

                                case (int)RoleType.TPKS:
                                case (int)RoleType.TPTour:
                                case (int)RoleType.TPVe:
                                case (int)RoleType.DHPQ:
                                case (int)RoleType.DHTour:
                                case (int)RoleType.DHVe:
                                case (int)RoleType.DHKS:
                                    {
                                        searchModel.SalerPermission += current_user.UserUnderList;
                                    }
                                    break;
                                case (int)RoleType.Admin:
                                case (int)RoleType.KT:
                                case (int)RoleType.GDHN:
                                case (int)RoleType.GDHPQ:
                                case (int)RoleType.GD:
                                case (int)RoleType.TPDHTour:
                                case (int)RoleType.TPDHKS:
                                case (int)RoleType.TPDHVe:
                                    {
                                        searchModel.SalerPermission = null;
                                        is_admin_or_department = true;
                                    }
                                    break;
                            }
                            if (is_admin_or_department) break;
                        }
                        var allcode_ws_type = await _allCodeRepository.GetIDIfValueExists(AllCodeType.SERVICE_TYPE_OTHER_MAIN, AllCodeDescription.WATER_SPORT);
                        if (allcode_ws_type != null && allcode_ws_type.Id > 0)
                        {
                            List<int> service_type_list = new List<int>();
                            service_type_list.Add(allcode_ws_type.CodeValue);
                            searchModel.ServiceType = service_type_list;
                        }
                        ViewBag.Model = await _otherBookingRepository.GetPagingList(searchModel, searchModel.PageIndex, searchModel.pageSize);
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("WaterSportSearch - SetServiceOtherController: " + ex);
            }

            return View();
        }
        public async Task<IActionResult> WaterSportDetail(long id)
        {
            ViewBag.user = new User();
            ViewBag.Booking = new OtherBooking();
            ViewBag.UserCreated = new User();
            ViewBag.UserUpdated = new User();
            ViewBag.Saler = new User();
            ViewBag.Operator = new User();
            ViewBag.OrderAmount = 0;
            ViewBag.ClientId = 0;
            ViewBag.RefundAmount = 0;
            try
            {

                var allcode_list = _allCodeRepository.GetListByType(AllCodeType.BOOKING_HOTEL_ROOM_STATUS);
                var WaterSport_detail = await _otherBookingRepository.GetWaterSportById(id);
                if (WaterSport_detail != null && WaterSport_detail.Id > 0)
                {
                    ViewBag.StatusName = allcode_list.First(x => x.CodeValue == WaterSport_detail.Status).Description;
                    ViewBag.user = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                    ViewBag.Booking = WaterSport_detail;
                    ViewBag.UserCreated = await _userRepository.GetById((long)WaterSport_detail.CreatedBy);
                    var order = _orderRepository.GetByOrderId(WaterSport_detail.OrderId);
                    if(order!=null && order.OrderId > 0)
                    {
                        ViewBag.OrderAmount = order.Amount;
                        ViewBag.Saler = await _userRepository.GetById((long)order.SalerId);
                        ViewBag.ClientId = order.ClientId ?? 0;

                    }
                    if (WaterSport_detail.UpdatedBy != null)
                    {
                        ViewBag.UserUpdated = await _userRepository.GetById((long)WaterSport_detail.UpdatedBy);

                    }
                    ViewBag.Operator = await _userRepository.GetById((long)WaterSport_detail.OperatorId);
                    ViewBag.AllowToFinishPayment = false;
                    if (WaterSport_detail != null && WaterSport_detail.Id > 0)
                    {
                        var max_date = WaterSport_detail.EndDate;
                        if (max_date < DateTime.Now)
                        {
                            ViewBag.AllowToFinishPayment = true;

                        }
                    }
                    var data_refund = _paymentRequestRepository.GetRequestByClientId((long)order.ClientId);
                    if (data_refund != null && data_refund.Count > 0)
                    {
                        ViewBag.RefundAmount = data_refund.Where(n => (n.Status == (int)(PAYMENT_REQUEST_STATUS.DA_CHI)) && !string.IsNullOrEmpty(n.PaymentVoucherCode)).Sum(n => n.Amount);

                    }
                    return View();

                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("FlyDetail - SetServiceWaterSportController: " + ex);
                return RedirectToAction("Error", "Home");
            }

        }

        [HttpPost]
        public async Task<IActionResult> WSDetailBookingSale(long id)
        {
            try
            {
                var allcode_list = _allCodeRepository.GetListByType(AllCodeType.SERVICE_TYPE_OTHER);
                ViewBag.ServiceType = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);

                var WaterSport_detail = await _otherBookingRepository.GetWaterSportById(id);
                if (WaterSport_detail != null && WaterSport_detail.Id > 0)
                {
                    ViewBag.Booking = WaterSport_detail;
                    ViewBag.ExtraList = await _otherBookingRepository.GetWaterSportPackagesByBookingId(WaterSport_detail.Id);
                    return View();
                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("WSDetailBookingSale - SetServiceWaterSportController: " + ex);
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> WSDetailBookingOperator(long id)
        {
            try
            {
                var allcode_list = _allCodeRepository.GetListByType(AllCodeType.SERVICE_TYPE_OTHER);

                var other_detail = await _otherBookingRepository.GetOtherBookingById(id);
                ViewBag.ListPackagesOptional = new List<OtherBookingPackagesOptionalViewModel>();
                if (other_detail != null && other_detail.Id > 0)
                {
                    ViewBag.Service = allcode_list.FirstOrDefault(x => x.CodeValue == other_detail.ServiceType);
                    ViewBag.Booking = other_detail;
                    var optional_list = await _otherBookingRepository.GetOtherBookingPackagesOptionalByBookingId(other_detail.Id);
                    if (optional_list != null && optional_list.Count > 0)
                    {
                        var list_optional = new List<OtherBookingPackagesOptionalViewModel>();
                        foreach (var item in optional_list)
                        {
                            var model = JsonConvert.DeserializeObject<OtherBookingPackagesOptionalViewModel>(JsonConvert.SerializeObject(item));
                            if (model.SuplierId > 0)
                            {
                                model.supplier = _supplierRepository.GetSuplierById(model.SuplierId);
                            }
                            list_optional.Add(model);
                        }
                        ViewBag.ListPackagesOptional = list_optional;
                    }
                    return View();
                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("OtherDetailBookingOperator - SetServiceFlyBookingController: " + ex);
                return RedirectToAction("Error", "Home");
            }
        }
        public async Task<IActionResult> WSDetailBookingChangeOperator(string operator_name, long booking_id)
        {

            try
            {
                ViewBag.Name = operator_name;
                ViewBag.Id = booking_id;

            }
            catch
            {

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SummitWSDetailChangeOperator(long booking_id, int user_id)
        {

            try
            {
                if (booking_id <=0 || user_id <= 0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.FAILED,
                        msg = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại"
                    });
                }
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                var success = await _otherBookingRepository.UpdateServiceOperator(booking_id, user_id, _UserId);

                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Đổi điều hành viên thành công"
                });

            }
            catch
            {
                return Ok(new
                {
                    status = (int)ResponseType.ERROR,
                    msg = "Đổi điều hành viên thất bại, vui lòng liên hệ IT"
                });
            }
        }
      
        [HttpPost]
        public async Task<IActionResult> WSExportExcel(SearchFlyBookingViewModel searchModel)
        {
            try
            {
                string _FileName = "Danh sách đặt dịch vụ khác.xlsx";
                string _UploadFolder = @"Template\Export";
                string _UploadDirectory = Path.Combine(_WebHostEnvironment.WebRootPath, _UploadFolder);

                if (!Directory.Exists(_UploadDirectory))
                {
                    Directory.CreateDirectory(_UploadDirectory);
                }
                //delete all file in folder before export
                try
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(_UploadDirectory);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                }
                catch
                {
                }


                string FilePath = Path.Combine(_UploadDirectory, _FileName);
                var allcode_ws_type = await _allCodeRepository.GetIDIfValueExists(AllCodeType.SERVICE_TYPE_OTHER_MAIN, AllCodeDescription.WATER_SPORT);
                if (allcode_ws_type != null && allcode_ws_type.Id > 0)
                {
                    List<int> service_type_list = new List<int>();
                    service_type_list.Add(allcode_ws_type.CodeValue);
                    searchModel.ServiceType = service_type_list;
                }
                var rsPath = await _otherBookingRepository.ExportDeposit(searchModel, FilePath);

                if (!string.IsNullOrEmpty(rsPath))
                {
                    return new JsonResult(new
                    {
                        isSuccess = true,
                        message = "Xuất dữ liệu thành công",
                        path = "/" + _UploadFolder + "/" + _FileName
                    });
                }
                else
                {
                    return new JsonResult(new
                    {
                        isSuccess = false,
                        message = "Xuất dữ liệu thất bại"
                    });
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ExportExcel - FundingController: " + ex);
                return new JsonResult(new
                {
                    isSuccess = false,
                    message = ex.Message.ToString()
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GrantWSServiceOrderPermission(long booking_id)
        {
            try
            {
                var current_user = _ManagementUser.GetCurrentUser();
                if (booking_id<=0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.FAILED,
                        msg = "Nhận đặt dịch vụ thất bại, vui lòng tải lại trang và thử lại"
                    });
                }
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                var id = await _otherBookingRepository.UpdateServiceOperator(booking_id, _UserId);
                if (id > 0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.SUCCESS,
                        msg = "Nhận đặt dịch vụ thành công"
                    });
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GrantOrderPermission - OrderManualController: " + ex.ToString());

            }
            return Ok(new
            {
                status = (int)ResponseType.ERROR,
                msg = "Nhận đặt dịch vụ thất bại, vui lòng liên hệ IT"
            });
        }
       
        [HttpPost]
        public async Task<IActionResult> WSServiceChangeToConfirmPaymentStatus(long booking_id)
        {
            try
            {
                var current_user = _ManagementUser.GetCurrentUser();
                if (booking_id <= 0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.FAILED,
                        msg = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại"
                    });
                }
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                #region not neccessary:
                //var payment_request = _paymentRequestRepository.GetByServiceId(booking_id, (int)ServicesType.WaterSport);
                //if (payment_request == null || payment_request.Count <= 0)
                //{
                //    return Ok(new
                //    {
                //        status = (int)ResponseType.FAILED,
                //        msg = "Dịch vụ chưa có yêu cầu chi nào, vui lòng bổ sung"
                //    });
                //}
                //var detail = await _otherBookingRepository.GetWaterSportById(booking_id);
                //double amount = detail.Price!=null ? (double)detail.Price:(detail.Amount-detail.Profit);
                //var request_amount = Convert.ToDouble(payment_request.Sum(x => (((x.Status == (int)(PAYMENT_REQUEST_STATUS.DA_CHI)|| x.Status == (int)(PAYMENT_REQUEST_STATUS.CHO_CHI)|| x.IsSupplierDebt == true))) ? x.Amount : 0));
                //if (request_amount >= amount)
                //{
                //    var id = await _otherBookingRepository.UpdateServiceStatus((int)ServiceStatus.Payment, booking_id, _UserId);
                //    var dataOrder2 = await _orderRepository2.ProductServiceName(detail.OrderId.ToString());
                //    List<int> confirm_payment_status_allow = new List<int>() { (int)ServiceStatus.Payment, (int)ServiceStatus.Cancel };
                //    var is_WaterSport_than_payment = dataOrder2.Any(x => !confirm_payment_status_allow.Contains(x.Status));
                //    var is_has_payment = dataOrder2.Any(x => x.Status == (int)ServiceStatus.Payment);
                //    if (!is_WaterSport_than_payment && is_has_payment)
                //    {
                //        long UpdatedBy = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                //        long UserVerify = 0;
                //        var UpdateOrderStatus = await _orderRepository2.UpdateOrderStatus(detail.OrderId, (int)OrderStatus.WAITING_FOR_ACCOUNTANT, UpdatedBy, UserVerify);
                //    }
                //    if (id > 0)
                //    {
                //        var order = _orderRepository.GetByOrderId(detail.OrderId);
                //        string link = "/Order/" + detail.OrderId;
                //        var SendMessage = apiService.SendMessage(_UserId.ToString(), ((int)ModuleType.DICH_VU).ToString(), ((int)ActionType.QUYET_TOAN).ToString(), order.OrderNo, link, current_user.Role, detail.ServiceCode);
                //        //-- update order payment_status
                //        await _orderRepository2.UpdateOrderDetail(detail.OrderId, _UserId);


                //        return Ok(new
                //        {
                //            status = (int)ResponseType.SUCCESS,
                //            msg = "Quyết toán dịch vụ thành công"
                //        });
                //    }
                //}
                //else
                //{
                //    return Ok(new
                //    {
                //        status = (int)ResponseType.FAILED,
                //        msg = "Đơn hàng chưa được thanh toán đủ"
                //    });
                //}
                #endregion
                var detail = await _otherBookingRepository.GetWaterSportById(booking_id);
                var id = await _otherBookingRepository.UpdateServiceStatus((int)ServiceStatus.Payment, booking_id, _UserId);
                var dataOrder2 = await _orderRepository2.ProductServiceName(detail.OrderId.ToString());
                List<int> confirm_payment_status_allow = new List<int>() { (int)ServiceStatus.Payment, (int)ServiceStatus.Cancel };
                var is_WaterSport_than_payment = dataOrder2.Any(x => !confirm_payment_status_allow.Contains(x.Status));
                var is_has_payment = dataOrder2.Any(x => x.Status == (int)ServiceStatus.Payment);
                if (!is_WaterSport_than_payment && is_has_payment)
                {
                    long UpdatedBy = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                    long UserVerify = 0;
                    var UpdateOrderStatus = await _orderRepository2.UpdateOrderStatus(detail.OrderId, (int)OrderStatus.WAITING_FOR_ACCOUNTANT, UpdatedBy, UserVerify);
                }
                if (id > 0)
                {
                    var order = _orderRepository.GetByOrderId(detail.OrderId);
                    string link = "/Order/" + detail.OrderId;
                    var SendMessage = apiService.SendMessage(_UserId.ToString(), ((int)ModuleType.DICH_VU).ToString(), ((int)ActionType.QUYET_TOAN).ToString(), order.OrderNo, link, current_user.Role, detail.ServiceCode);
                    //-- update order payment_status
                    await _orderRepository2.UpdateOrderDetail(detail.OrderId, _UserId);


                    return Ok(new
                    {
                        status = (int)ResponseType.SUCCESS,
                        msg = "Quyết toán dịch vụ thành công"
                    });
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("ChangeToConfirmPaymentStatus - OrderManualController: " + ex.ToString());

            }
            return Ok(new
            {
                status = (int)ResponseType.ERROR,
                msg = "Cập nhật trạng thái đặt dịch vụ thất bại, vui lòng liên hệ IT"
            });
        }
        [HttpPost]
        public async Task<IActionResult> WSServiceCodeSuggestion(string txt_search)
        {
            List<OtherBooking> data = new List<OtherBooking>();

            try
            {
                data = await _otherBookingRepository.ServiceCodeSuggesstion(txt_search);
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Success",
                    data=data
                });

            }
            catch
            {
            }

            return Ok(new
            {
                status = (int)ResponseType.ERROR,
                msg = "WaterSportServiceCodeSuggestion error on excution",
                data=data
            });
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWSOperatorOrderPrice(List<OtherBookingPackagesOptional> data)
        {

            try
            {
                if (data == null || data.Count <= 0)
                {
                    return Ok(new
                    {
                        status = (int)ResponseType.FAILED,
                        msg = "Dữ liệu gửi lên không chính xác, vui lòng kiểm tra lại"
                    });
                }
                var other_booking = await _otherBookingRepository.GetOtherBookingById(data[0].BookingId);
                double amount = 0;
                double price = 0;
                double profit = 0;
                if (other_booking != null && other_booking.Id > 0)
                {
                    int _UserId = 0;
                    if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                    {
                        _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                    }
                    var id = await _otherBookingRepository.UpdateOtherBookingOptional(data, data[0].BookingId, _UserId);
                    other_booking = await _otherBookingRepository.GetOtherBookingById(data[0].BookingId);
                    amount = other_booking.Amount;
                    price = (other_booking.Price != null ? (double)other_booking.Price : 0);
                    if (price <= 0) price = 0;
                    profit = amount - price - (other_booking.Commission == null ? 0 : (double)other_booking.Commission) - (other_booking.OthersAmount == null ? 0 : (double)other_booking.OthersAmount);

                    #region Update Order Amount:
                    await _orderRepository2.UpdateOrderDetail(other_booking.OrderId, _UserId);
                    #endregion
                }
                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Cập nhật giá đặt dịch vụ thành công",
                    amount = price,
                    profit = profit
                });
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("UpdateOperatorOrderPrice - OrderManualController: " + ex.ToString());

            }
            return Ok(new
            {
                status = (int)ResponseType.FAILED,
                msg = "Cập nhật giá đặt dịch vụ thất bại, vui lòng liên hệ IT"
            });

        }
    }
}
