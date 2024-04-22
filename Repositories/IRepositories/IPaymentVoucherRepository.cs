﻿using Entities.ViewModels.Funding;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IPaymentVoucherRepository
    {
        List<PaymentVoucherViewModel> GetPaymentVouchers(PaymentVoucherViewModel searchModel, out long total, int currentPage = 1, int pageSize = 20);
        PaymentVoucherViewModel GetDetail(int paymentVoucherId);
        string ExportPaymentVouchers(PaymentVoucherViewModel searchModel, string FilePath);
        int CreatePaymentVoucher(PaymentVoucherViewModel model, out string msg);
        int UpdatePaymentVoucher(PaymentVoucherViewModel model);
    }
}
