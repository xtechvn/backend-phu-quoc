using Entities.Models;
using Entities.ViewModels;
using Entities.ViewModels.TransferSms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using Utilities;
using WEB.Adavigo.CMS.Service;
using WEB.CMS.Customize;

namespace WEB.Adavigo.CMS.Controllers
{
    [CustomAuthorize]

    public class TransactionSmsController : Controller
    {
        private readonly IConfiguration _configuration;
        public TransactionSmsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(TransferSmsSearchModel searchModel, int currentPage = 1, int pageSize = 20)
        {
            var model = new GenericViewModel<TransactionSMS>();
            try
            {
                TransferSmsService transferSmsService = new TransferSmsService();
                long total = 0;
                var listTransactionSms = transferSmsService.SearchTransactionSMs(searchModel, out total, currentPage, pageSize);
                model.CurrentPage = currentPage;
                model.ListData = listTransactionSms;
                model.PageSize = pageSize;
                model.TotalRecord = total;
                model.TotalPage = (int)Math.Ceiling((double)total / pageSize);
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("Search - TransactionSmsController. " + JsonConvert.SerializeObject(ex));
            }
            return PartialView(model);
        }
    }
}
