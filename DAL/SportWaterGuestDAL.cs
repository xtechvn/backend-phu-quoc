using DAL.Generic;
using DAL.StoreProcedure;
using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.SportWater;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace DAL
{
    public class SportWaterGuestDAL : GenericService<SportWaterGuest>
    {
        private static DbWorker _DbWorker;
        public SportWaterGuestDAL(string connection) : base(connection)
        {
            _DbWorker = new DbWorker(connection);

        }
        public async Task<National> GetDetailNationalByCode(string Code)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@Code", Code);

                var dt= _DbWorker.GetDataTable(StoreProcedureConstant.SP_GetDetailNationalByCode, objParam);
                if(dt != null && dt.Rows.Count > 0)
                {
                    var data = dt.ToList<National>();
                    return data[0];
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("SP_GetDetailNationalByCode - WaterSportDAL: " + ex);
            }
            return null;
        }
        public DataTable GetListSportWaterGuests(WaterSportSearchModel model)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[5];
                objParam[0] = new SqlParameter("@ClientId", model.ClientId);
                objParam[1] = new SqlParameter("@RoomNo", model.RoomNo);
                objParam[2] = new SqlParameter("@UserName", model.UserName);
                objParam[3] = new SqlParameter("@PageIndex", model.PageIndex);
                objParam[4] = new SqlParameter("@PageSize", model.PageSize);

                return _DbWorker.GetDataTable(StoreProcedureConstant.SP_GetListSportWaterGuests, objParam);
                
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetListSportWaterGuests - WaterSportDAL: " + ex);
            }
            return null;
        }
        public DataTable GetListSportWaterGuestsByIds(string Ids)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@Id", Ids);
              
                return _DbWorker.GetDataTable(StoreProcedureConstant.SP_GetListSportWaterGuestsByIds, objParam);
                
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetListSportWaterGuests - WaterSportDAL: " + ex);
            }
            return null;
        }
        public async Task<long> InsertSportWaterGuests(WaterSportExcelModel model)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[7];
                objParam[0] = new SqlParameter("@ClientId", model.ClientId);
                objParam[1] = new SqlParameter("@UserName", model.username);
                objParam[2] = new SqlParameter("@StartDate", model.StartDate);
                objParam[3] = new SqlParameter("@EndDate",model.EndDate);
                objParam[4] = new SqlParameter("@RoomNo", model.roomno);
                objParam[5] = new SqlParameter("@National", model.national);
                objParam[6] = new SqlParameter("@CreatedBy", model.CreatedBy);

                return _DbWorker.ExecuteNonQuery(StoreProcedureConstant.sp_InsertSportWaterGuests, objParam);
             
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("InsertSportWaterGuests - WaterSportDAL: " + ex);
            }
            return -1;
        } 
        public async Task<DataTable> GetListSportWaterPackages()
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[0];


                return _DbWorker.GetDataTable(StoreProcedureConstant.SP_GetListSportWaterPackages, objParam);
             
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetListSportWaterPackages - WaterSportDAL: " + ex);
            }
            return null;
        }
    }
}
