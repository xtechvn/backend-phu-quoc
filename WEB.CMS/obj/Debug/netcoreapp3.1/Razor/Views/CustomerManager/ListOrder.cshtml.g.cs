#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4208a734f4f7be96d40e99f8f3f051587b4ffc2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerManager_ListOrder), @"mvc.1.0.view", @"/Views/CustomerManager/ListOrder.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
using Entities.ViewModels.Funding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
using Utilities.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4208a734f4f7be96d40e99f8f3f051587b4ffc2d", @"/Views/CustomerManager/ListOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerManager_ListOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrap_bg wrap_bg_no-padding mb20"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th style=""width: 30px;"">STT</th>
                    <th>Mã đơn</th>
                    <th>Ngày bắt đầu - Ngày kết thúc</th>
                    <th>Nhãn đơn</th>
                    <th class=""text-right"">Thanh toán</th>
                    <th class=""text-right"">Lợi nhuận</th>
                    <th>Trạng thái</th>
                    <th>
                        Ngày tạo
                        <a class=""sort"">↓</a>
                    </th>
                    <th>Người tạo</th>
                    <th>Nhân viên chính</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                if(Model.ListData!=null && Model.ListData.Count > 0)
                {
                    var counter = (Model.CurrentPage - 1) * Model.PageSize;
                   foreach(var item in Model.ListData)
                   {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <tr>\r\n                           <td>");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                           Write(counter++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td><a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1412, "\"", 1439, 2);
            WriteAttributeValue("", 1419, "/Order/", 1419, 7, true);
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
WriteAttributeValue("", 1426, item.OrderId, 1426, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                      Write(item.OrderCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                           <td>");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                          Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                            Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                          Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td class=\"text-right\">\r\n");
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                if (item.TotalAmount != 0)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"green\">");
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                               Write(((double)item.TotalAmount).ToString("###,###,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/</div>");
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                                                               }
                               else
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"green\">0/</div>");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"red\">");
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                            Write(item.Amount == 0 ? "0": item.Amount.ToString("###,###,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                           </td>\r\n                           <td class=\"text-right\">");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                             Write(item.Profit.ToString("###,###,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>\r\n                            \r\n");
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                switch (Convert.ToInt32(item.StatusCode))
                               {
                                   case (int)(OrderStatus.CREATED_ORDER):
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <span class=\"status-oranger\">");
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                       }
                                       break;
                                   case (int)(OrderStatus.CONFIRMED_SALE):
                                   case (int)(OrderStatus.WAITING_FOR_OPERATOR):

                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <div class=\"status-green\">");
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                 Write(item.PermisionTypeName==null|| item.PermisionTypeName.Trim() == "" ? "Không công nợ": item.PermisionTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                                                                                                                                  Write(item.PaymentStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"

                                       }
                                       break;
                                   case (int)(OrderStatus.WAITING_FOR_ACCOUNTANT):
                                   case (int)(OrderStatus.FINISHED):
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <span class=\"status-green\">");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                       }
                                       break;
                                   case ((int)(OrderStatus.CANCEL)):
                                   case ((int)(OrderStatus.ACCOUNTANT_DECLINE)):
                                   case ((int)(OrderStatus.OPERATOR_DECLINE)):
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <span class=\"status-red\">");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                                       }
                                       break;
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                           </td>\r\n                           <td> ");
#nullable restore
#line 83 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                           Write(item.CreateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
                           Write(item.SalerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       </tr>\r\n");
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"

                   }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 94 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
Write(await Component.InvokeAsync("Paging", new
    {
        pageModel = new Paging()
        {
            TotalRecord = Model.TotalRecord,
            TotalPage = Model.TotalPage,
            CurrentPage = Model.CurrentPage,
            PageSize = Model.PageSize,
            RecordName = "Hóa đơn",
            PageAction = "_customer_manager.OrederOnPaging({0})"
        }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> ");
#nullable restore
#line 106 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrap_bg wrap_bg_no-padding mb20"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th style=""width: 30px;"">STT</th>
                    <th>Mã đơn</th>
                    <th>Ngày bắt đầu - Ngày kết thúc</th>
                    <th>Nhãn đơn</th>
                    <th class=""text-right"">Thanh toán</th>
                    <th class=""text-right"">Lợi nhuận</th>
                    <th>Trạng thái</th>
                    <th>
                        Ngày tạo
                        <a class=""sort"">↓</a>
                    </th>
                    <th>Người tạo</th>
                    <th>Nhân viên chính</th>

                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>");
#nullable restore
#line 134 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\ListOrder.cshtml"
      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591