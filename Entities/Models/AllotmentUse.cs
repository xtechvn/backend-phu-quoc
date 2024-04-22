using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AllotmentUse
    {
        public int Id { get; set; }
        public long DataId { get; set; }
        public DateTime CreateDate { get; set; }
        public double AmountUse { get; set; }
        public int AllomentFundId { get; set; }
        public long AccountClientId { get; set; }

        public virtual AllotmentFund AllomentFund { get; set; }
    }
}
