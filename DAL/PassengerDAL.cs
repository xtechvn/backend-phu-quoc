using DAL.Generic;
using DAL.StoreProcedure;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace DAL
{
    public class PassengerDAL : GenericService<Passenger>
    {
        private DbWorker dbWorker;
        public PassengerDAL(string connection) : base(connection)
        {
            dbWorker = new DbWorker(connection);
        }
      
        public async Task<List<Passenger>> GetByOrderId(long order_id, string group_fly)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var passengers = await _DbContext.Passenger.AsNoTracking().Where(x => x.OrderId == order_id && x.GroupBookingId.Trim()==group_fly.Trim()).ToListAsync();
                   
                    return passengers;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetByOrderId - PassengerDAL. " + ex.ToString());
                return new List<Passenger>();
            }
        }
        public async Task<List<Passenger>> GetPassengerByOrderId(long order_id)
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var passengers = await _DbContext.Passenger.AsNoTracking().Where(x => x.OrderId == order_id ).ToListAsync();

                    return passengers;
                }
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetPassengerByOrderId - PassengerDAL. " + ex.ToString());
                return new List<Passenger>();
            }
        }
        public int InsertPassenger(Passenger model)
        {
            try
            {

                SqlParameter[] objParam = new SqlParameter[8];
                objParam[0] = new SqlParameter("@Name", model.Name);
                objParam[1] = new SqlParameter("@MembershipCard", model.MembershipCard);
                objParam[2] = new SqlParameter("@PersonType", model.PersonType);
                objParam[3] = new SqlParameter("@Birthday", model.Birthday);
                objParam[4] = new SqlParameter("@Gender", model.Gender);
                objParam[5] = new SqlParameter("@OrderId", model.OrderId);
                objParam[6] = new SqlParameter("@Note", model.Note);
                objParam[7] = new SqlParameter("@GroupBookingId", model.GroupBookingId);

                return dbWorker.ExecuteNonQuery(StoreProcedureConstant.sp_InsertPassenger, objParam);
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("InsertPassenger - PassengerDAL: " + ex);
                return 0;
            }
        }
    }
}
