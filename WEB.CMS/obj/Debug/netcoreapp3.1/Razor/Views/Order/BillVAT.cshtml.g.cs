#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1afb801ed8c3956467ec8d25e8e092a6dc850083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_BillVAT), @"mvc.1.0.view", @"/Views/Order/BillVAT.cshtml")]
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
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
using Utilities.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1afb801ed8c3956467ec8d25e8e092a6dc850083", @"/Views/Order/BillVAT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_BillVAT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
   var listRequest = (List<Entities.ViewModels.Invoice.InvoiceRequestViewModel>)ViewBag.listRequest;
    var i = 1;
    var orderStatus = ViewBag.orderStatus;
    var totalRequest = (int)ViewBag.totalRequest;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"border bg-white mb20\">\r\n    <div class=\"flex space-between row-main-head pd10\">\r\n        <div class=\"bold\">Yêu cầu xuất hóa đơn</div>\r\n        <div>\r\n");
#nullable restore
#line 12 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
             if (totalRequest == 0 && orderStatus == (int)OrderStatus.WAITING_FOR_OPERATOR)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button onclick=\"_ordersCMS.AddInvoiceRequest();\" type=\"button\" class=\"btn btn-default bg-main \">\r\n                    <i class=\"fa fa-plus\"></i>Thêm\r\n                </button>\r\n");
#nullable restore
#line 17 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""line-bottom pb0""></div>
    <div class=""pd10"">
        <div class=""table-responsive table-gray"">
            <table class=""table table-nowrap"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Mã hóa đơn</th>
                        <th style=""width: 350px;"">Nội dung</th>
                        <th class=""text-right"">Số tiền</th>
                        <th>Trạng thái</th>
                        <th>Ngày gửi</th>
                        <th class=""text-center"">Thao tác</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                     if (listRequest != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                         foreach (var item in listRequest)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1805, 2);
            WriteAttributeValue("", 1757, "/InvoiceRequest/Detail?invoiceRequestId=", 1757, 40, true);
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
WriteAttributeValue("", 1797, item.Id, 1797, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                   Write(item.InvoiceRequestNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                               Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                                  Write(item.TotalPriceVAT.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                     if (item.Status == (int)(INVOICE_REQUEST_STATUS.CHO_TBP_DUYET))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status-wait\">");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                                             Write(item.InvoiceRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                     if (item.Status == (int)(INVOICE_REQUEST_STATUS.DA_DUYET) || item.Status == (int)(INVOICE_REQUEST_STATUS.HOAN_THANH))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status-approve\">");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                                                Write(item.InvoiceRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                     if (item.Status == (int)(INVOICE_REQUEST_STATUS.TU_CHOI))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status-reject\">");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                                               Write(item.InvoiceRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                     if (item.Status == (int)(INVOICE_REQUEST_STATUS.LUU_NHAP))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status-draft\">");
#nullable restore
#line 64 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                                              Write(item.InvoiceRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                               Write(item.CreatedDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                     if (item.Status == (int)(INVOICE_REQUEST_STATUS.LUU_NHAP) || item.Status == (int)(INVOICE_REQUEST_STATUS.TU_CHOI))
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button type=\"button\" class=\" ml-1 green border-0\" style=\" background: none;\"");
            BeginWriteAttribute("onclick", "\r\n                                                onclick=\"", 4175, "\"", 4307, 7);
            WriteAttributeValue("", 4234, "_invoice_request_service.Delete(", 4234, 32, true);
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
WriteAttributeValue("", 4266, item.Id, 4266, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4274, ",", 4274, 1, true);
            WriteAttributeValue(" ", 4275, "\'", 4276, 2, true);
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
WriteAttributeValue("", 4277, item.InvoiceRequestNo, 4277, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4299, "\',", 4299, 2, true);
            WriteAttributeValue(" ", 4301, "true)", 4302, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"fa fa-trash-o txt_14 ml-1\"></i>\r\n                                        </button>\r\n");
#nullable restore
#line 79 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\BillVAT.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
