#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cc2dfa16e6cc4ed1ec58df6df5ecf2735d4546e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_AddWatersportServicePackages), @"mvc.1.0.view", @"/Views/Order/AddWatersportServicePackages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc2dfa16e6cc4ed1ec58df6df5ecf2735d4546e", @"/Views/Order/AddWatersportServicePackages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_AddWatersportServicePackages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
  
    Layout = null;
    Entities.Models.OtherBooking booking = (Entities.Models.OtherBooking)ViewBag.Booking;
    List<Entities.Models.OtherBookingPackages> list = (List<Entities.Models.OtherBookingPackages>)ViewBag.ExtraList;
    List<Entities.Models.AllCode> list_service = (List<Entities.Models.AllCode>)ViewBag.ServiceType;
    double profit = list != null && list.Count > 0 ? list.Sum(x => (double)x.Profit) : 0;
    double amount = list != null && list.Count > 0 ? list.Sum(x => (double)x.Amount) : 0;
    double commission = list != null && list.Count > 0 ? list.Sum(x => x.Commission!=null?(double)x.Commission:0) : 0;
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .service-watersport-packages-note{
        height:80px;
    }
</style>
<table class=""table table-nowrap"">
    <thead>
        <tr>
            <th style=""min-width: 70px;"">STT</th>
            <th style=""min-width: 300px;"">Sản phẩm</th>
            <th class=""text-right"" style=""min-width: 200px;"">Đơn giá<sup class=""red"">*</sup></th>
            <th class=""text-right"" style=""min-width:150px !important;"">Số lượng</th>
            <th class=""text-right"" style=""min-width: 300px !important;"">Thành tiền giá bán</th>
            <th class=""text-right"" style=""min-width: 300px !important;"">Hoa hồng</th>
            <th class=""text-center"" style=""min-width: 400px !important;"">Ghi chú</th>
            <th class=""text-right""></th>
        </tr>
    </thead>
    <tbody class=""service-watersport-packages-tbody"">

");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
         if (list.Count > 0)
        {
            foreach (var item in list)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"service-watersport-packages-row\" data-extra-package-id=\"");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <td class=\"service-watersport-packages-order\">");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                      Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <select class=\"select select2 service-watersport-service-type\" name=\"service-watersport-service-type\" style=\"width: 100%;\">\r\n\r\n");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                      
                        var select_service = list_service.FirstOrDefault(x => x.CodeValue == item.ServiceType);
                        if (select_service != null && select_service.Id > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc2dfa16e6cc4ed1ec58df6df5ecf2735d4546e6864", async() => {
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                                                        Write(select_service.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                WriteLiteral(select_service.CodeValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </td>\r\n");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
              
                double amount_sale_pre = (double)item.Amount / (double)item.Quantity;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td> <input class=\"form-control text-right currency service-watersport-packages-baseprice\" type=\"text\" name=\"service-watersport-packages-baseprice\"");
            BeginWriteAttribute("value", " value=\"", 2671, "\"", 2721, 1);
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
WriteAttributeValue("", 2679, ((double)item.BasePrice).ToString("N0"), 2679, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            <td> <input class=\"form-control text-right currency service-watersport-packages-quantity\" type=\"text\" name=\"service-watersport-packages-quantity\"");
            BeginWriteAttribute("value", " value=\"", 2887, "\"", 2933, 1);
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
WriteAttributeValue("", 2895, ((int)item.Quantity).ToString("N0"), 2895, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            <td class=\"text-right\"> <input class=\"form-control text-right currency service-watersport-packages-amount\" disabled style=\"background-color: lightgray;\"");
            BeginWriteAttribute("value", " value=\"", 3106, "\"", 3141, 1);
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
WriteAttributeValue("", 3114, item.Amount.ToString("N0"), 3114, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            <td class=\"text-right\"> <input class=\"form-control text-right currency service-watersport-packages-commission\"");
            BeginWriteAttribute("value", "  value=\"", 3272, "\"", 3349, 1);
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
WriteAttributeValue("", 3281, (item.Commission!=null?(double) item.Commission:0).ToString("N0"), 3281, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            <td><textarea class=\"form-control style-width2 textarea service-watersport-packages-note\" >");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                                                                  Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea></td>\r\n\r\n            <td class=\"text-right\">\r\n                <a class=\"fa fa-trash-o\" href=\"javascript:;\" onclick=\"_order_detail_watersport.DeletewatersportBookingpackages($(this));\"></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"service-watersport-packages-row\" data-extra-package-id=\"0\">\r\n        <td class=\"service-watersport-packages-order\">");
#nullable restore
#line 68 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                  Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <select class=\"select select2 service-watersport-service-type\" name=\"service-watersport-service-type\" style=\"width: 100%;\">\r\n\r\n");
#nullable restore
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                 foreach (var allcode in list_service)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc2dfa16e6cc4ed1ec58df6df5ecf2735d4546e13587", async() => {
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                     Write(allcode.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                        WriteLiteral(allcode.CodeValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n        </td>\r\n        <td> <input class=\"form-control text-right currency service-watersport-packages-baseprice\" type=\"text\" name=\"service-watersport-packages-baseprice\"");
            BeginWriteAttribute("value", " value=\"", 4438, "\"", 4446, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n        <td> <input class=\"form-control text-right currency service-watersport-packages-quantity\" type=\"text\" name=\"service-watersport-packages-quantity\"");
            BeginWriteAttribute("value", " value=\"", 4608, "\"", 4616, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\r\n        <td class=\"text-right\"> <input class=\"form-control text-right currency service-watersport-packages-amount\" style=\"background-color: lightgray;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4787, "\"", 4795, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n        <td class=\"text-right\"> <input class=\"form-control text-right currency service-watersport-packages-commission\"");
            BeginWriteAttribute("value", "  value=\"", 4922, "\"", 4931, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
        <td><textarea class=""form-control style-width2 textarea service-watersport-packages-note""></textarea></td>

        <td class=""text-right"">
            <a class=""fa fa-trash-o"" href=""javascript:;"" onclick=""_order_detail_watersport.DeletewatersportBookingpackages($(this));""></a>
        </td>
    </tr>
");
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <tr class=""service-watersport-packages-summary-row"">
            <td></td>
            <td>
                <a href=""javascript:;"" class=""blue ml-2 mb10"" onclick=""_order_detail_watersport.AddwatersportBookingpackages();""><i class=""fa fa-plus-circle green""></i> Thêm dịch vụ</a>
            </td>
            <td class=""text-right"" colspan=""2"">Tổng cộng</td>
            <td class=""text-right font-weight-bold service-watersport-packages-total-amount"">");
#nullable restore
#line 99 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                                                         Write(amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right font-weight-bold service-watersport-packages-total-commission\">");
#nullable restore
#line 100 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddWatersportServicePackages.cshtml"
                                                                                             Write(commission.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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