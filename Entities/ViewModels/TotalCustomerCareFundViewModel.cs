using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class TotalCustomerCareFundViewModel
    {
        public double TotalFundCustomerCare { get; set; }
        public double TotalAmountPaymentRequestComplete { get; set; }
        public double TotalAmountPaymentRequestPending { get; set; }
    }
}
