using System;
using System.Collections.Generic;
using Entities.Models;

namespace Entities.ViewModels.OrderManual
{
   
    public class OrderManualWaterSportBookingServiceSummitModel
    {
        public long id { get; set; }
        public long order_id { get; set; }
        public string service_code { get; set; }
        public DateTime used_date { get; set; }
        public string note { get; set; }
        public int operator_id { get; set; }
        public List<OrderManualWaterSportBookingServiceSummitPackage> packages { get; set; }
        public double others_amount { get; set; }
        public double commission { get; set; }
        public string conf_no { get; set; }
        public string room_no { get; set; }
        public string serial_no { get; set; }

    }


    public class OrderManualWaterSportBookingServiceSummitPackage
    {
        public long id { get; set; }
        public int service_type { get; set; }
        public double base_price { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
        public double commission { get; set; }
        public string note { get; set; }

    }
}
