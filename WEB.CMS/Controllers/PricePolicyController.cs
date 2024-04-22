using Caching.RedisWorker;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;
using WEB.CMS.Customize;

namespace WEB.Adavigo.CMS.Controllers
{
    [CustomAuthorize]

    public partial class PricePolicyController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAllCodeRepository _allCodeRepository;
        private readonly ICampaignRepository _campaignRepository;
        private readonly IPriceDetailRepository _priceDetailRepository;
        private readonly IGroupProductRepository _groupProductRepository;
        private readonly IProductFlyTicketServiceRepository _productFlyTicketServiceRepository;
        private readonly IRoomPackageRepository _roomPackageRepository;
        private readonly IServicePiceRoomRepository _servicePiceRoomRepository;
        private readonly RedisConn _redisService;
        private readonly IRoomFunRepository _roomFunRepository;
        public PricePolicyController(IConfiguration configuration, ICampaignRepository campaignRepository, IAllCodeRepository allCodeRepository,
            IPriceDetailRepository priceDetailRepository, IGroupProductRepository groupProductRepository, 
             IProductFlyTicketServiceRepository productFlyTicketServiceRepository,
            IRoomPackageRepository roomPackageRepository, IServicePiceRoomRepository servicePiceRoomRepository, IRoomFunRepository roomFunRepository)
        {
            _configuration = configuration;
            _campaignRepository = campaignRepository;
            _priceDetailRepository = priceDetailRepository;
            _groupProductRepository = groupProductRepository;
            _productFlyTicketServiceRepository = productFlyTicketServiceRepository;
            _redisService = new RedisConn(_configuration);
            _redisService.Connect();
            _allCodeRepository = allCodeRepository;
            _roomPackageRepository = roomPackageRepository;
            _servicePiceRoomRepository = servicePiceRoomRepository;
            _roomFunRepository = roomFunRepository;
        }
        /// <summary>
        /// View
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.ServiceType = _allCodeRepository.GetListByType(AllCodeType.SERVICE_TYPE);

            return View();
        }
        /// <summary>
        /// View
        /// </summary>
        /// <returns></returns>
        public IActionResult AddNew()
        {
            var service_list = _allCodeRepository.GetListByType(AllCodeType.SERVICE_TYPE);
            service_list.Remove(service_list.Where(x => x.CodeValue == (int)ServicesType.OthersHotelRent).FirstOrDefault());
            return View(service_list);
        }
        /// <summary>
        /// Hàm tìm kiếm để filter ngoài trang hiển thị tất cả chiến dịch
        /// </summary>
        /// <param name="searchModel"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Search(PricePolicySearchModel searchModel, int currentPage = 1, int pageSize = 20)
        {
            var model = new GenericViewModel<PricePolicyListingModel>();
            try
            {
                if (searchModel.ToDate == DateTime.MinValue) searchModel.ToDate = DateTime.MaxValue;
                var status_int = searchModel.CampaginStatus.Split(",");
                List<string> status_str = new List<string>();
                foreach(var status_num in status_int)
                {
                    if(CampaignStatus.CampaignStatusConstant.ContainsKey(status_num))
                    status_str.Add(CampaignStatus.CampaignStatusConstant[status_num]);
                }
                
                searchModel.CampaginStatus = string.Join(",", status_str);
                model = _campaignRepository.GetPagingList(searchModel, currentPage, pageSize);
                if(model!=null && model.ListData != null && model.ListData.Count>0)
                {
                    foreach (var item in model.ListData)
                    {
                        var hotel = await GetHotel(item.ProviderID);
                        if (hotel != null && hotel.id == item.ProviderID)
                        {
                            item.ProviderName = hotel.name;
                        }
                    }
                }
            }
                
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - PricePolicyController: " + ex);
            }
            return PartialView(model);
        }

    }
}
