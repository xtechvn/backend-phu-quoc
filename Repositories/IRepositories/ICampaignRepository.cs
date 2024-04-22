using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.PricePolicy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface ICampaignRepository
    {
        public GenericViewModel<PricePolicyListingModel> GetPagingList(PricePolicySearchModel searchModel, int currentPage, int pageSize);

        public Task<Campaign> GetDetailByCode(string campaign_code);
        public Task<int> AddNew(Campaign campaign);
        public Task<int> Update(Campaign campaign);
        public int Delete(int campaignId);
        public Task<int> CreateOrUpdateHotelCampaign(HotelPricePolicyDetailViewModel full_detail, int user_id);
        public Task<Campaign> GetDetailByID(int id);
        public Task<HotelPricePolicyDetailViewModel> GetPolicyDetailViewByCampaignID(int campaign_id);
    }
}
