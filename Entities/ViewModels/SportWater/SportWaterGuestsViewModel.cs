using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels.SportWater
{
    public class SportWaterGuestsViewModel
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public string RoomNo { get; set; }
        public string UserName { get; set; }
        public string Code { get; set; }
        public string National { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long TotalRow { get; set; }
    }
}
