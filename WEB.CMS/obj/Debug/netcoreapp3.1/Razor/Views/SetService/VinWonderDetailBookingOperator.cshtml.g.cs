#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa9c9daf1fdf19861feb2df4d6dfcce1e732b79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_VinWonderDetailBookingOperator), @"mvc.1.0.view", @"/Views/SetService/VinWonderDetailBookingOperator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa9c9daf1fdf19861feb2df4d6dfcce1e732b79", @"/Views/SetService/VinWonderDetailBookingOperator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_VinWonderDetailBookingOperator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
  
    Layout = null;
    Entities.Models.VinWonderBooking? booking = (Entities.Models.VinWonderBooking?)ViewBag.Booking;
    List<Entities.Models.VinWonderBookingTicket> list = (List<Entities.Models.VinWonderBookingTicket>)ViewBag.Packages;
    double amount = (double)booking.Amount;
    double profit = 0;
    double unit_price = (double)booking.TotalUnitPrice;
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .service-other-ordered-package-name {
        margin-top: 15px;
    }
    .form-control:disabled {
        background-color: #e8e8e8 !important;
    }
</style>
<div>
    <div class=""bold mb10 txt_14"">Ghi chú</div>
    <div class=""form-group"">
        <textarea class=""form-control service-vinwonder-readonly-note input-disabled-background"" disabled style=""height: 200px;"" rows=""6"">");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                                                                                      Write(booking!=null && booking.Note!=null? booking.Note:"");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
    </div>
</div>
<div class=""row row_min"">
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Địa điểm<sup class=""red"">*</sup></label>
        <select id=""add-service-vinwonder-select-location"" class=""select select2 add-service-vinwonder-select-location input-disabled-background"" disabled name=""add-service-vinwonder-select-service"" style=""width: 100%;"">
");
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
             if (booking != null && booking.Id > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa9c9daf1fdf19861feb2df4d6dfcce1e732b795638", async() => {
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                    Write(booking.SiteName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                    WriteLiteral(booking.SiteCode);

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
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Chi phí khác </label>
        <input id=""servicemanual-vinwonder-other-amount"" class=""form-control currency text-right servicemanual-vinwonder-other-amount"" disabled type=""text"" name=""servicemanual-vinwonder-other-amount"" placeholder=""Nhập chi phí khác""");
            BeginWriteAttribute("value", " value=\"", 1812, "\"", 1901, 1);
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 1820, booking.OthersAmount!=null ? ((double)booking.OthersAmount).ToString("N0"):"0", 1820, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

    </div>
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Hoa hồng CTV </label>
        <input id=""servicemanual-vinwonder-discount"" class=""form-control currency text-right servicemanual-vinwonder-discount"" disabled type=""text"" name=""servicemanual-vinwonder-discount"" placeholder=""Nhập chiết khấu""");
            BeginWriteAttribute("value", " value=\"", 2241, "\"", 2326, 1);
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 2249, booking.Commission!=null ? ((double)booking.Commission).ToString("N0"):"0", 2249, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    </div>\r\n</div>\r\n<div>\r\n    <div class=\"bold mb15 txt_14\">\r\n        Bảng kê dịch vụ\r\n        <small>((Đơn giá đã bao gồm thuế phí + Phí dịch vụ Adavigo))</small>\r\n");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
         if (booking != null && (booking.Status == (short)Utilities.Contants.ServiceStatus.OnExcution|| booking.Status == (short)Utilities.Contants.ServiceStatus.ServeCode))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button class=""btn btn-default update-operator-order-amount"">Cập nhật thành tiền</button>
            <button class=""btn btn-default update-operator-order-amount-save"" style=""display:none;"">Lưu</button>
            <button class=""btn btn-default update-operator-order-amount-cancel"" style=""display:none;"">Hủy</button>
");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""table-responsive table-gray service-vinwonder-packages"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th style=""width: 70px;"">STT</th>
                    <th style=""min-width: 200px;"">Nội dung</th>
                    <th class=""text-left"" style=""min-width: 100px;"">Thời gian sử dụng</th>
                    <th class=""text-right"" style=""min-width: 100px;""> Giá nhập </th>
                    <th class=""text-right"" style=""min-width: 100px;""> Giá bán </th>
                    <th class=""text-right"" style=""width:100px !important;"">Số lượng</th>
                    <th class=""text-right""> Tổng tiền giá bán</th>
                    <th class=""text-right""> Tổng tiền giá nhập</th>
                    <th class=""text-right"" style=""width:150px !important;"">Lợi nhuận</th>
                </tr>
            </thead>
            <tbody class=""service-vinwonder-packages-tbody"">

");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                 if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        double item_unit_price = ((double)item.UnitPrice > 0) ? (double)item.UnitPrice : (double)item.Amount - (double)item.Profit;
                        double base_price_operator = Math.Round(item_unit_price / (double)item.Quantity, 0);
                        double item_profit = (double)item.Amount - item_unit_price;
                        profit += item_profit;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"service-vinwonder-packages-row\" data-extra-package-id=\"");
#nullable restore
#line 81 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <td class=\"service-vinwonder-packages-order\">");
#nullable restore
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                     Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"text\" class=\"form-control service-vinwonder-packages-packagename input-disabled-background\" disabled style=\"width:100% !important\"");
            BeginWriteAttribute("value", " value=\"", 4932, "\"", 4950, 1);
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 4940, item.Name, 4940, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </td>\r\n                            <td>\r\n                                <input class=\"form-control service-vinwonder-packages-date input-disabled-background\" disabled type=\"text\" name=\"service-vinwonder-packages-date\"");
            BeginWriteAttribute("value", " value=\"", 5200, "\"", 5289, 1);
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 5208, item.DateUsed==null?"" :((DateTime)item.DateUsed).ToString("dd/MM/yyyy HH:mm"), 5208, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </td>
                            <td> <input class=""form-control text-right currency service-vinwonder-packages-baseprice-operator input-disabled-background"" disabled type=""text"" name=""service-vinwonder-packages-baseprice-operator""");
            BeginWriteAttribute("value", " value=\"", 5554, "\"", 5599, 1);
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 5562, base_price_operator.ToString("N0"), 5562, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                            <td> <input class=\"form-control text-right currency service-vinwonder-packages-baseprice input-disabled-background\" disabled type=\"text\" name=\"service-vinwonder-packages-baseprice\"");
            BeginWriteAttribute("value", " value=\"", 5816, "\"", 5866, 1);
#nullable restore
#line 90 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 5824, ((double)item.BasePrice).ToString("N0"), 5824, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                            <td> <input class=\"form-control text-right currency service-vinwonder-packages-quantity input-disabled-background\" disabled type=\"text\" name=\"service-vinwonder-packages-quantity\"");
            BeginWriteAttribute("value", " value=\"", 6081, "\"", 6127, 1);
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 6089, ((int)item.Quantity).ToString("N0"), 6089, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                            <td class=\"text-right\"> <input class=\"form-control text-right currency service-vinwonder-packages-amount input-disabled-background\" disabled style=\"background-color: lightgray;\"");
            BeginWriteAttribute("value", " value=\"", 6341, "\"", 6388, 1);
#nullable restore
#line 92 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 6349, ((double)item.Amount).ToString("N0"), 6349, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                            <td class=\"text-right\"> <input class=\"form-control text-right currency service-vinwonder-packages-unit-price input-disabled-background\" disabled style=\"background-color: lightgray;\"");
            BeginWriteAttribute("value", " value=\"", 6606, "\"", 6647, 1);
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 6614, item_unit_price.ToString("N0"), 6614, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></td>
                            <td class=""text-right service-vinwonder-packages-profit-row"">
                                <input class=""form-control text-right currency service-vinwonder-packages-profit input-disabled-background"" disabled type=""text""");
            BeginWriteAttribute("value", " value=\"", 6907, "\"", 6944, 1);
#nullable restore
#line 95 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
WriteAttributeValue("", 6915, item_profit.ToString("N0"), 6915, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr class=""service-vinwonder-packages-summary-row"">
                    <td></td>
                    <td colspan=""2"" class=""text-right"">Tổng cộng</td>
                    <td class=""text-right""></td>
                    <td class=""text-right""></td>
                    <td class=""text-right""></td>
                    <td class=""text-right font-weight-bold service-vinwonder-packages-total-amount"">");
#nullable restore
#line 106 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                                                Write(amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right font-weight-bold service-vinwonder-packages-total-total-unit-price\">");
#nullable restore
#line 107 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                                                          Write(unit_price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right font-weight-bold service-vinwonder-packages-total-profit\">");
#nullable restore
#line 108 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\VinWonderDetailBookingOperator.cshtml"
                                                                                                Write(profit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                </tr>

            </tbody>
        </table>
    </div>
</div>

<div class=""attachment-operator border pd10"">
    <img src=""/images/icons/loading.gif"" style=""width: 55px;height: 55px;margin-left: 10px;margin-bottom: 10px;"" class=""img_loading_summit coll"">
</div>
");
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
