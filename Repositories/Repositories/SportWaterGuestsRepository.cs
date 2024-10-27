using DAL;
using DAL.StoreProcedure;
using Elasticsearch.Net;
using Entities.ConfigModels;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.SportWater;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
    public class SportWaterGuestsRepository: ISportWaterGuestsRepository
    {

        private readonly SportWaterGuestDAL sportWaterGuestDAL;

        public SportWaterGuestsRepository(IOptions<DataBaseConfig> dataBaseConfig, ILogger<AllCodeRepository> logger)
        {

            sportWaterGuestDAL = new SportWaterGuestDAL(dataBaseConfig.Value.SqlServer.ConnectionString);
        }
        public async Task<GenericViewModel<SportWaterGuestsViewModel>>  GetPagingList(WaterSportSearchModel SearchModel)
        {
            var model = new GenericViewModel<SportWaterGuestsViewModel>();
            try
            {
                DataTable dt= sportWaterGuestDAL.GetListSportWaterGuests(SearchModel);
                if(dt != null && dt.Rows.Count > 0)
                {
                    model.ListData = dt.ToList<SportWaterGuestsViewModel>();
                    model.PageSize = SearchModel.PageSize;
                    model.CurrentPage = SearchModel.PageIndex;
                    model.TotalRecord = Convert.ToInt32(dt.Rows[0]["TotalRow"]);
                    model.TotalPage = (int)Math.Ceiling((double)model.TotalRecord / model.PageSize);
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPagingList - SportWaterGuestsRepository: " + ex);
            }
            return model;
        }
        public async Task<List<SportWaterGuestsViewModel>> GetListSportWaterGuestsByIds(String Ids)
        {
            var model = new GenericViewModel<SportWaterGuestsViewModel>();
            try
            {
                DataTable dt= sportWaterGuestDAL.GetListSportWaterGuestsByIds(Ids);
                if (dt != null && dt.Rows.Count > 0)
                {
                    var ListData = dt.ToList<SportWaterGuestsViewModel>();
                    return ListData;
                }
            
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPagingList - SportWaterGuestsRepository: " + ex);
            }
            return null;
        }
        public async Task<National> GetDetailNationalByCode(string Code)
        {
            try
            {
                return await sportWaterGuestDAL.GetDetailNationalByCode(Code);
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetDetailNationalByCode - SportWaterGuestsRepository: " + ex);
            }
            return null;
        }
        public async Task<long> InsertSportWaterGuests(List<WaterSportExcelModel> model,int CreatedBy)
        {
            try
            {
                foreach (var item in model)
                {
                    item.CreatedBy = CreatedBy;
                    if(item.ClientId!=null && item.national!=0 && item.username!=null)
                    await sportWaterGuestDAL.InsertSportWaterGuests(item);
                }
                return 1;

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("InsertSportWaterGuests - SportWaterGuestsRepository: " + ex);
            }
            return -1;
        }  
        public async Task<List<SportWaterPackagesViewModel>> GetListSportWaterPackages()
        {
            try
            {

                DataTable dt =await sportWaterGuestDAL.GetListSportWaterPackages();
                if(dt!=null && dt.Rows.Count > 0)
                {
                    var data = dt.ToList<SportWaterPackagesViewModel>();
                    return data;
                }

            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetListSportWaterPackages - SportWaterGuestsRepository: " + ex);
            }
            return null;
        }
    }
}
