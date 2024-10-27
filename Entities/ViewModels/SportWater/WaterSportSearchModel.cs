using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels.SportWater
{
    public class WaterSportSearchModel
    {
        public string ClientId { get; set; }
        public string RoomNo { get; set; }
        public string UserName { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
