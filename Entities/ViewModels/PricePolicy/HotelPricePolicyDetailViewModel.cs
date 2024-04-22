using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.PricePolicy
{
    public class HotelPricePolicyDetailViewModel
    {
        public Campaign CampaignDetail { get; set; }
        public List<HotelPricePolicyDetail> ListPricePolicy { get; set; }
        public List<AllCode> CustomerTypeList { get; set; }
        public List<HotelPricePolicyFilterModel> Filters { get; set; }

    }

    public class HotelPricePolicyFilterModel
    {
        public string ContractNo { get; set; }
        public List<HotelRoomPackageDetailViewModel> PackagesNameList { get; set; }
    }
    public class HotelRoomPackageDetailViewModel
    {
        public string package_id { get; set; }
        public string package_name { get; set; }
        public List<HotelRoomDetailFilterCMSModel> room_id { get; set; }
    }
    public class HotelRoomDetailFilterCMSModel
    {
        public string room_id { get; set; }
        public string room_name { get; set; }
    }
    public class HotelPricePolicyDetail
    {
        public ProductRoomServiceCMSViewModel ProductService { get; set; }
        public List<PriceDetail> PriceDetail { get; set; }
    }
    public class ProductRoomServiceCMSViewModel : ProductRoomService
    {
        public string ProviderName { get; set; }
        public string PackageName { get; set; }
        public string RoomName { get; set; }
        public string RoomCode { get; set; }
        public double BasePrice { get; set; }
    }


   


}
