using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Entities.ViewModels
{
    public class WaterSportExcelImportModel
    {
        public string roomno { get; set; }
        public string username { get; set; }
        public long national_id { get; set; }
        public string national_name { get; set; }
        public string national_code { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    public class WaterSportExcelModel
    {
        public long ClientId { get; set; }
        public string roomno { get; set; }
        public string username { get; set; }
        public long national { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? StartDate
        {
            get
            {
                return DateUtil.StringToDate(startDate);
            }
        }
        public DateTime? EndDate
        {
            get
            {
                return DateUtil.StringToDate(endDate);
            }
        }
    }
}
