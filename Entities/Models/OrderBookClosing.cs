using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class OrderBookClosing
{
    public int Id { get; set; }

    public long OrderId { get; set; }

    public double? Amount { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public DateOnly? FinalizeDate { get; set; }

    public int? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
