using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.Report;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;
using WEB.CMS.Customize;

namespace WEB.Adavigo.CMS.PQ.Controllers.Report
{
    [CustomAuthorize]
    public class ReportWSController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IDepartmentRepository _DepartmentRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IOtherBookingRepository _otherBookingRepository;

        private readonly IReportRepository _reportRepository;
        private ManagementUser _ManagementUser;
        private readonly IAllCodeRepository _allCodeRepository;

        public ReportWSController(IOrderRepository orderRepository, IDepartmentRepository departmentRepository,
            IWebHostEnvironment WebHostEnvironment, 
             IReportRepository reportRepository, ManagementUser managementUser, IAllCodeRepository allcodeRepository, IOtherBookingRepository otherBookingRepository)
        {
            _orderRepository = orderRepository;
            _DepartmentRepository = departmentRepository;
            _WebHostEnvironment = WebHostEnvironment;
            _reportRepository = reportRepository;
            _ManagementUser = managementUser;
            _allCodeRepository = allcodeRepository;
            _otherBookingRepository = otherBookingRepository;


        }
        public async Task<IActionResult> Index()
        {
            var ws_type = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
            ViewBag.Type = ws_type;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Search(WSReportSearchModel searchModel)
        {
            try
            {
                ViewBag.MinDate = searchModel.FromDate;
                ViewBag.MaxDate = searchModel.ToDate;
                ViewBag.TotalReport = new List<WSReportTotalViewModel>();
                var ws_type = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
                ViewBag.Type = ws_type;
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (searchModel.ServiceType!=null && searchModel.ServiceType.Trim() == "-1") searchModel.ServiceType = null;
                if (searchModel.ClientIds != null && searchModel.ClientIds.Trim() == "-1") searchModel.ClientIds = null;
                if (searchModel.FromDate == DateTime.MinValue) searchModel.FromDate = new DateTime(DateTime.Now.Year, 1, 1, 1, 0, 0, 0);
                if (searchModel.ToDate == DateTime.MinValue) searchModel.ToDate = DateTime.Now;
                var model = await _reportRepository.GetWSOperatorReport(searchModel);
                var total_report = await _reportRepository.GetWSTotalReportFromData(model);
                ViewBag.TotalReport = total_report;
                var summary = new WSReportTotalViewModel()
                {
                    DateUsed = DateTime.Now,
                    ServicesList = new List<WSReportTotalServiceViewModel>()
                };
                var total_service_list = total_report.SelectMany(x => x.ServicesList);
                foreach (var type in ws_type)
                {
                    var item_by_service_type = total_service_list.Where(x => x.ServiceType == type.CodeValue);
                    if (item_by_service_type != null && item_by_service_type.Count() > 0)
                    {

                        summary.ServicesList.Add(new WSReportTotalServiceViewModel()
                        {
                            ServiceType = type.CodeValue,
                            Amount=item_by_service_type.Sum(x=>x.Amount),
                            Commission=item_by_service_type.Sum(x=>x.Commission)
                        });
                    }
                }
                ViewBag.Summary = summary;

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - OperatorReportController: " + ex);
            }
            return View();
        }
        public async Task<IActionResult> ExportExcel(WSReportSearchModel searchModel)
        {
            try
            {
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (searchModel.FromDate == DateTime.MinValue) searchModel.FromDate = new DateTime(DateTime.Now.Year, 1, 1, 1, 0, 0, 0);
                if (searchModel.ToDate == DateTime.MinValue) searchModel.ToDate = DateTime.Now;
                string folder = @"\Template\Export\";
                string file_name = "Chi tiết Doanh thu Thể thao biển ngày "+searchModel.FromDate.ToString("dd-MM-yyyy")+" _" + _UserId + ".xlsx";
                string _UploadDirectory = Path.Combine(_WebHostEnvironment.WebRootPath, folder);
                string file_path_combine = Path.Combine(_UploadDirectory, file_name);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var file_path = await _reportRepository.ExportWSExcel(await _reportRepository.GetWSOperatorReport(searchModel), searchModel, file_path_combine);

                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Xuất dữ liệu thành công",
                    path = file_path
                });
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - OperatorReportController: " + ex);
            }
            return Ok(new
            {
                status = (int)ResponseType.FAILED,
                msg = "Xuất dữ liệu thất bại, vui lòng liên hệ IT",
                path = ""
            });
        }
        public async Task<IActionResult> ExportTotal(WSReportSearchModel searchModel)
        {
            try
            {
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (searchModel.FromDate == DateTime.MinValue) searchModel.FromDate = new DateTime(DateTime.Now.Year, 1, 1, 1, 0, 0, 0);
                if (searchModel.ToDate == DateTime.MinValue) searchModel.ToDate = DateTime.Now;
                string folder = @"\Template\Export\";
                string file_name = "Doanh thu Thể thao biển  _" + _UserId + ".xlsx";
                string _UploadDirectory = Path.Combine(_WebHostEnvironment.WebRootPath, folder);
                string file_path_combine = Path.Combine(_UploadDirectory, file_name);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var ws_type = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);

                var file_path = await _reportRepository.ExportWSTotalExcel(await _reportRepository.GetWSOperatorReport(searchModel), searchModel, ws_type, file_path_combine);

                return Ok(new
                {
                    status = (int)ResponseType.SUCCESS,
                    msg = "Xuất dữ liệu thành công",
                    path = file_path
                });
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - OperatorReportController: " + ex);
            }
            return Ok(new
            {
                status = (int)ResponseType.FAILED,
                msg = "Xuất dữ liệu thất bại, vui lòng liên hệ IT",
                path = ""
            });
        }
        [HttpPost]
        public async Task<IActionResult> Detail(WSReportSearchModel searchModel)
        {
            try
            {
                ViewBag.MinDate = searchModel.FromDate;
                ViewBag.MaxDate = searchModel.ToDate;
                ViewBag.TotalReport = new List<WSReportTotalViewModel>();
                var ws_type = _allCodeRepository.GetListByType(AllCodeType.WATER_SPORT_TYPE);
                ViewBag.Type = ws_type;
                var list_total_report = new List<WSReportTotalViewModel>();
                int _UserId = 0;
                if (HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    _UserId = Convert.ToInt32(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
                if (searchModel.ServiceType != null && searchModel.ServiceType.Trim() == "-1") searchModel.ServiceType = null;
                if (searchModel.ClientIds != null && searchModel.ClientIds.Trim() == "-1") searchModel.ClientIds = null;
                if (searchModel.FromDate == DateTime.MinValue) searchModel.FromDate = new DateTime(DateTime.Now.Year, 1, 1, 1, 0, 0, 0);
                if (searchModel.ToDate == DateTime.MinValue) searchModel.ToDate = DateTime.Now;
                var model = await _reportRepository.GetWSOperatorReport(searchModel);
                ViewBag.Model = model;
               

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - OperatorReportController: " + ex);
            }
            return View();
        }
    }
}
