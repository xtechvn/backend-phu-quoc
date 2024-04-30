#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13f2ef6860acc5866f1241344c03b0f638ec293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receipt_Search), @"mvc.1.0.view", @"/Views/Receipt/Search.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\_ViewImports.cshtml"
using WEB.CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\_ViewImports.cshtml"
using WEB.CMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13f2ef6860acc5866f1241344c03b0f638ec293", @"/Views/Receipt/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipt_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<ContractPayViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
  
    Layout = null;
    var isQcEnvironment = (bool)ViewBag.isQcEnvironment;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
 if (Model == null || Model.ListData == null || Model.ListData.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"search-null center mb40\">\r\n        <div class=\"mb24\">\r\n            <img src=\"/images/graphics/icon-search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 385, "\"", 391, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <h2 class=\"title txt_24\">Không tìm thấy kết quả</h2>\r\n        <div class=\"gray\">Chúng tôi không tìm thấy thông tin mà bạn cần, vui lòng thử lại</div>\r\n    </div>\r\n");
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th style=""width: 30px;"">STT</th>
                    <th style=""width: 100px;"">Mã phiếu</th>
                    <th style=""width: 140px;"">Loại nghiệp vụ</th>
                    <th style=""width: 100px;"">Hình thức</th>
                    <th style=""width: 100px;"">Khách hàng</th>
                    <th style=""width: 100px;"">Nhà cung cấp</th>
                    <th style=""width: 100px;"">Nhân viên</th>
                    <th style=""width: 100px;"" class=""text-right"">Số tiền</th>
                    <th style=""width: 200px;"">Nội dung</th>
                    <th style=""width: 120px;"">Đơn hàng/Nạp quỹ/Dịch vụ</th>
                    <th style=""width: 140px;"">Ngày tạo</th>
                    <th style=""width: 140px;"">Người tạo</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                 if (Model.ListData != null && Model.ListData.Count > 0)
                {
                    var counter = (Model.CurrentPage - 1) * Model.PageSize;
                    foreach (var item in Model.ListData)
                    {
                        counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"center \">");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-nowrap\">\r\n                                <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2112, 2);
            WriteAttributeValue("", 2071, "/Receipt/Detail?contractPayId=", 2071, 30, true);
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 2101, item.PayId, 2101, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                               Write(item.BillNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td class=\"text-break\">");
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                              Write(item.ContractPayType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-break\">");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                              Write(item.PayTypeStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-break\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2479, "\"", 2527, 2);
            WriteAttributeValue("", 2486, "/CustomerManager/Detail?id=", 2486, 27, true);
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 2513, item.ClientId, 2513, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"blue\"> ");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                                                                   Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            </td>\r\n                            <td class=\"text-break\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2700, "\"", 2743, 2);
            WriteAttributeValue("", 2707, "/Supplier/Detail?id=", 2707, 20, true);
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 2727, item.SupplierId, 2727, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"blue\"> ");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                                                              Write(item.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            </td>\r\n                            <td class=\"text-break\">\r\n                                ");
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                           Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-right\">\r\n");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_DON_HANG)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                     if (item.TotalDeposit >= item.Amount)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"green\">");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                      Write(item.TotalDeposit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/ </div>\r\n");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"red\">");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                    Write(item.TotalDeposit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/ </div>\r\n");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_HOA_HONG_NCC
                               || item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_NCC_HOAN_TRA)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    Write(item.TotalDeposit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 81 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_KHAC)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>");
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 85 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_KY_QUY)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>");
#nullable restore
#line 88 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                    Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td class=\" text-break\">");
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                               Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\" text-break\">\r\n");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_DON_HANG && item.DataContent != null)
                                {
                                    var counterContent = 1;
                                    foreach (var dataNo in item.DataContent)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 5233, "\"", 5277, 2);
            WriteAttributeValue("", 5240, "/Order/Orderdetails?id=", 5240, 23, true);
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 5263, dataNo.DataId, 5263, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 99 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                       Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n");
#nullable restore
#line 101 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (counterContent < item.DataContent.Count)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>,</span>\r\n");
#nullable restore
#line 104 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         
                                        counterContent += 1;
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if (item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_KY_QUY && item.DataContent != null)
                                {
                                    var counterContent = 1;
                                    foreach (var dataNo in item.DataContent)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 6166, "\"", 6220, 2);
            WriteAttributeValue("", 6173, "/Funding/Detail?depositHistotyId=", 6173, 33, true);
#nullable restore
#line 113 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 6206, dataNo.DataId, 6206, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 114 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                       Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n");
#nullable restore
#line 116 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (counterContent < item.DataContent.Count)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>,</span>\r\n");
#nullable restore
#line 119 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         
                                        counterContent += 1;
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                 if ((item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_HOA_HONG_NCC || item.Type == (int)DepositHistoryConstant.CONTRACT_PAY_TYPE.THU_TIEN_NCC_HOAN_TRA) && item.DataContent != null)
                                {
                                    var counterContent = 1;
                                    foreach (var dataNo in item.DataContent)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (dataNo.ServiceType == (int)ServiceType.PRODUCT_FLY_TICKET)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 7353, "\"", 7400, 2);
            WriteAttributeValue("", 7360, "/SetService/fly/detail/", 7360, 23, true);
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 7383, dataNo.DataIdFly, 7383, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 131 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                           Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n");
#nullable restore
#line 133 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (dataNo.ServiceType == (int)ServiceType.BOOK_HOTEL_ROOM_VIN)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 7769, "\"", 7826, 2);
            WriteAttributeValue("", 7776, "/SetService/VerifyHotelServiceDetai/", 7776, 36, true);
#nullable restore
#line 136 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 7812, dataNo.DataId, 7812, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 137 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                           Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n");
#nullable restore
#line 139 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (dataNo.ServiceType == (int)ServiceType.Tour)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 8180, "\"", 8225, 2);
            WriteAttributeValue("", 8187, "/SetService/Tour/Detail/", 8187, 24, true);
#nullable restore
#line 142 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 8211, dataNo.DataId, 8211, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 143 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                           Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n");
#nullable restore
#line 145 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (dataNo.ServiceType == (int)ServiceType.Other)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 8580, "\"", 8627, 2);
            WriteAttributeValue("", 8587, "/SetService/Others/Detail/", 8587, 26, true);
#nullable restore
#line 148 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
WriteAttributeValue("", 8613, dataNo.DataId, 8613, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 149 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                           Write(dataNo.DataNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n");
#nullable restore
#line 151 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         if (counterContent < item.DataContent.Count)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>,</span>\r\n");
#nullable restore
#line 155 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                         
                                        counterContent += 1;
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n");
#nullable restore
#line 160 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                             if (item.CreatedDate != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\" text-break\">");
#nullable restore
#line 162 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                   Write(item.CreatedDate.Value.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 163 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\" text-break\">");
#nullable restore
#line 166 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                                   Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 167 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\" text-break\">");
#nullable restore
#line 168 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        </tr>\r\n");
#nullable restore
#line 170 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 175 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 177 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\Search.cshtml"
Write(await Component.InvokeAsync("Paging", new
{
    pageModel = new Paging()
    {
        TotalRecord = Model.TotalRecord,
        TotalPage = Model.TotalPage,
        CurrentPage = Model.CurrentPage,
        PageSize = Model.PageSize,
        RecordName = "kết quả lọc",
        PageAction = "_receipt_service.OnPaging({0})"
    }
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<ContractPayViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591