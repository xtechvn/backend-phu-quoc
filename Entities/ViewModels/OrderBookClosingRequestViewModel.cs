using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class OrderBookClosingRequestViewModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FinalizeDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long OrderId { get; set; }
        public string OrderNo { get; set; }
        public double AmountPrevious { get; set; }
        public double Amount { get; set; }
        public string UserFinalize { get; set; }
    }
}
