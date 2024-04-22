using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Report
{
    public class WSReportSearchModel
    {
         
        public string ClientIds { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ServiceType { get; set; }
        public double VAT { get; set; }
    }
    public class WSReportViewModel
    {
        
        public double BasePrice { get; set; }
        public int Quantity { get; set; }
        public double Profit { get; set; }
        public int? ServiceType { get; set; }
        public double AmountVat { get; set; }
        public double Amount { get; set; }
        public string ConfNo { get; set; }
        public string SerialNo { get; set; }
        public string RoomNo { get; set; }
        public DateTime StartDate { get; set; }
        public string ClientId { get; set; }
        public string ClientCode { get; set; }
        public string Label { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public string Note { get; set; }
        public string EndUserName { get; set; }
        public double? Commission { get; set; }
        public string Name { get; set; }


    }
    public class WSReportTotalViewModel
    {

        public DateTime DateUsed { get; set; }
        public List<WSReportTotalServiceViewModel> ServicesList { get; set; }

    }
    public class WSReportTotalServiceViewModel
    {

        public int ServiceType { get; set; }
        public double Amount { get; set; }
        public double Commission { get; set; }

    }
}
