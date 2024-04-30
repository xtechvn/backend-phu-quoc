#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e936259c6fc6888e3c5ba85746a2557da2c28ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_WSDetailBookingOperator), @"mvc.1.0.view", @"/Views/SetService/WSDetailBookingOperator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e936259c6fc6888e3c5ba85746a2557da2c28ed", @"/Views/SetService/WSDetailBookingOperator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_WSDetailBookingOperator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
  
    Layout = null;
    int index = 0;
    Entities.Models.OtherBooking? booking = (Entities.Models.OtherBooking?)ViewBag.Booking;
    List<Entities.ViewModels.SetServices.OtherBookingPackagesOptionalViewModel> ws_packages = (List<Entities.ViewModels.SetServices.OtherBookingPackagesOptionalViewModel>)ViewBag.ListPackagesOptional;
    double amount = ws_packages.Sum(x=>x.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .service-ws-ordered-package-name{
        margin-top:15px;
    }
    .textarea {
        min-height: 70px !important;
        min-width: 120px !important;
    }
</style>
<div>
    <div class=""bold mb10 txt_14"">Ghi chú</div>
    <div class=""form-group"">
        <textarea class=""form-control service-ws-note"" disabled style=""height: 200px;"" rows=""6"">");
#nullable restore
#line 20 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                                            Write(booking!=null && booking.Note!=null? booking.Note:"");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
    </div>
</div>
<div class=""row row_min"">
    
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Ngày đi <sup class=""red"">*</sup></label>
        <div class=""datepicker-wrap"" style=""width:100%"">
            <input class=""form-control datepicker-input service-ws-date-time-single service-ws-from-date"" type=""text"" name=""service-ws-from-date""");
            BeginWriteAttribute("value", " value=\"", 1214, "\"", 1329, 1);
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 1222, booking!=null ? booking.StartDate.ToString("dd/MM/yyyy HH:mm"):DateTime.Now.ToString("dd/MM/yyyy HH:mm"), 1222, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Ngày về <sup class=""red"">*</sup></label>
        <div class=""datepicker-wrap"" style=""width:100%"">
            <input class=""form-control datepicker-input service-ws-date-time-single service-ws-single-date service-ws-to-date"" type=""text"" name=""service-ws-from-date""");
            BeginWriteAttribute("value", " value=\"", 1709, "\"", 1822, 1);
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 1717, booking!=null ? booking.EndDate.ToString("dd/MM/yyyy HH:mm"):DateTime.Now.ToString("dd/MM/yyyy HH:mm"), 1717, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Chi phí khác </label>
        <input id=""servicemanual-ws-ws-amount"" class=""form-control currency text-right servicemanual-ws-ws-amount"" disabled type=""text"" name=""servicemanual-ws-ws-amount"" placeholder=""Nhập chi phí khác""");
            BeginWriteAttribute("value", " value=\"", 2160, "\"", 2249, 1);
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 2168, booking.OthersAmount!=null ? ((double)booking.OthersAmount).ToString("N0"):"0", 2168, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

    </div>
    <div class=""col-xl-2 col-lg-3 col-md-6 mb15"">
        <label class=""lbl mb5"">Hoa hồng CTV </label>
        <input id=""servicemanual-ws-discount"" class=""form-control currency text-right servicemanual-ws-discount"" disabled type=""text"" name=""servicemanual-ws-discount"" placeholder=""Nhập chiết khấu""");
            BeginWriteAttribute("value", " value=\"", 2568, "\"", 2653, 1);
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 2576, booking.Commission!=null ? ((double)booking.Commission).ToString("N0"):"0", 2576, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    </div>\r\n</div>\r\n<div class=\"mb15 bold txt_18 set-service-ws-detail-title\">\r\n    Bảng kê dịch vụ\r\n    <small>(Đơn giá đã bao gồm thuế phí + Phí dịch vụ Adavigo)</small>\r\n");
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
     if (booking!=null && (booking.Status == (short)Utilities.Contants.ServiceStatus.OnExcution|| booking.Status == (short)Utilities.Contants.ServiceStatus.ServeCode))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button class=""btn btn-default update-operator-order-amount"">Cập nhật thành tiền</button>
        <button class=""btn btn-default update-operator-order-amount-save"" style=""display:none;"">Lưu</button>
        <button class=""btn btn-default update-operator-order-amount-cancel"" style=""display:none;"">Hủy</button>
");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""table-responsive table-default table-gray wrap_bg wrap_bg_no-padding mb20"">
    <table class=""table table-nowrap set-service-ws-detail-box"">
        <thead>
            <tr>
                <th style=""width: 70px;"">STT</th>
                <th style=""min-width: 200px;"">Nội dung</th>
                <th style=""min-width: 400px;"">Nhà cung cấp</th>
                <th class=""text-right"" style=""min-width: 100px;""> Giá nhập </th>
                <th class=""text-right"" style=""width:100px !important;"">Số lượng</th>
                <th class=""text-right""> Tổng tiền giá nhập</th>
                <th style=""width: 500px !important;"">Ghi chú</th>
                <th>Thao tác</th>
            </tr>
        </thead>
        <tbody class=""set-service-ws-packages-optional-tbody"" data-code=""");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                     Write(booking != null&& booking.ServiceCode!=null? booking.ServiceCode:"");

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-go-id=\"");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                                                                                                         Write(booking != null? booking.Id.ToString():"");

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
             if (ws_packages != null && ws_packages.Count > 0)
            {
                foreach (var item in ws_packages)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"service-ws-ordered-row\" data-id=\"");
#nullable restore
#line 79 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td class=\"service-ws-ordered-order\">");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                         Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><p class=\"form-control service-ws-ordered-package-name\">");
#nullable restore
#line 81 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                               Write(item.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td>\r\n                            <select class=\"select2 service-ws-ordered-suplier input-disabled-background\" style=\"width:100% !important\" disabled>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e936259c6fc6888e3c5ba85746a2557da2c28ed12210", async() => {
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                    Write(item.SuplierId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                                      Write(item.supplier.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                   WriteLiteral(item.SuplierId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </select>
                        </td>
                        <td> <input class=""form-control text-right currency service-ws-packages-baseprice-operator input-disabled-background"" disabled type=""text"" name=""service-ws-packages-baseprice-operator""");
            BeginWriteAttribute("value", " value=\"", 5307, "\"", 5421, 1);
#nullable restore
#line 88 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 5315, (item.BasePrice==null || item.BasePrice<0? (double)item.Amount : (double)item.BasePrice).ToString("N0"), 5315, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td> <input class=\"form-control text-right currency service-ws-packages-quantity input-disabled-background\" disabled type=\"text\" name=\"service-ws-packages-quantity\"");
            BeginWriteAttribute("value", " value=\"", 5618, "\"", 5708, 1);
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 5626, (item.Quantity==null || item.Quantity<0? 1 : (int)item.Quantity).ToString("N0"), 5626, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td class=\"text-right\"> <input class=\"form-control text-right currency service-ws-packages-unit-price input-disabled-background\" disabled style=\"background-color: lightgray;\"");
            BeginWriteAttribute("value", " value=\"", 5915, "\"", 5952, 1);
#nullable restore
#line 90 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
WriteAttributeValue("", 5923, item.Amount.ToString("N0"), 5923, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td>\r\n                        \r\n                            <textarea class=\"form-control style-width2 textarea service-ws-ordered-note input-disabled-background\" disabled style=\"background: #f0f0f0;\">");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                                                                                                                    Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                        
                        </td>
                        <td> <a class=""fa fa-trash-o service-ws-ordered-delete-row-disabled service-ws-ordered-delete-row"" style=""display:none;"" href=""javascript:;""></a></td>
                    </tr>
");
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <tr class=""service-ws-ordered-summary-row"">
                <td></td>
                <td>
                    <a href=""javascript:;"" class=""blue ml-2 mb10 service-ws-ordered-add-new-disabled service-ws-ordered-add-new"" style=""display:none;""><i class=""fa fa-plus-circle green""></i> Thêm dòng</a>
                </td>
                <td></td>
                <td></td>
                <td></td>
                <td class=""service-ws-ordered-total-amount"" style=""font-weight:bold; text-align:right;"">");
#nullable restore
#line 109 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\WSDetailBookingOperator.cshtml"
                                                                                                    Write(amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                <td></td>
                <td></td>
            </tr>

        </tbody>
    </table>

</div>
<div class=""attachment-operator border pd10"">
    <img src=""/images/icons/loading.gif"" style=""width: 55px;height: 55px;margin-left: 10px;margin-bottom: 10px;"" class=""img_loading coll"">
</div>
<script>
    _set_service_ws_detail.wsDetailBookingOrderedInitialization()

</script>");
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
