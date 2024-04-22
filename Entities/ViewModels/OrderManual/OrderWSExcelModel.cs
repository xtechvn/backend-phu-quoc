using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.OrderManual
{
    public class OrderWSExcelImportModel
    {
        public DateTime used_date { get; set; }
        public string label { get; set; }
        public string used_date_str { get; set; }
        public string client_name { get; set; }
        public string conf_no { get; set; }
        public string room_no { get; set; }
        public string serial_no { get; set; }
        public string product_name { get; set; }
        public int quanity { get; set; }
        public double base_price { get; set; }
        public double amount { get; set; }
        public double amount_before_vat { get; set; }
        public double vat_value { get; set; }
        public string note { get; set; }
        public string client_code { get; set; }
        public int service_type { get; set; }

    }
    public class OrderWSExcelSuccessModel
    {
        public long order_id { get; set; }
        public string order_no { get; set; }
        public DateTime used_date { get; set; }
        public string client_id { get; set; }
        public string conf_no { get; set; }
        public string room_no { get; set; }
        public string serial_no { get; set; }
        public double amount { get; set; }

    }
    public class OrderWSExcelSQLModel
    {
        public Order order { get; set; }
        public List<OtherBookingWSExcelSQLModel> booking { get; set; }
        public ContactClient ContactClient { get; set; }

    }
    public class OtherBookingWSExcelSQLModel
    {
        public OtherBooking detail { get; set; }
        public List<OtherBookingPackages> packages { get; set; }

    }
}
