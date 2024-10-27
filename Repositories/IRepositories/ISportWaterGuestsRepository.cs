using Entities.ViewModels.SportWater;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Repositories.IRepositories
{
    public interface ISportWaterGuestsRepository
    {
        Task<GenericViewModel<SportWaterGuestsViewModel>> GetPagingList(WaterSportSearchModel SearchModel);
        Task<National> GetDetailNationalByCode(string Code);
        Task<long> InsertSportWaterGuests(List<WaterSportExcelModel> model,int CreatedBy);
        Task<List<SportWaterGuestsViewModel>> GetListSportWaterGuestsByIds(String Ids);
        Task<List<SportWaterPackagesViewModel>> GetListSportWaterPackages();
    }
}
