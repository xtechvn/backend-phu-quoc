#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96884b99afb317f8aa60dd232e463f1c5c78b387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_ListTourPackagesOrdered), @"mvc.1.0.view", @"/Views/SetService/ListTourPackagesOrdered.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
using Entities.ViewModels.HotelBookingRoom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
using Entities.ViewModels.Tour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96884b99afb317f8aa60dd232e463f1c5c78b387", @"/Views/SetService/ListTourPackagesOrdered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_ListTourPackagesOrdered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TourPackages>>
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
   int i = 0;
    int i2 = 0;
    int index = 0;
    var ListTourGuests = (List<TourGuests>)ViewBag.ListTourGuests;
    var TourPackageOptional = (List<AllCode>)ViewBag.TourPackageOptional;
    var ContactClient = (ContactClient)ViewBag.ContactClient;
    var listTourPackagesOptional = (List<TourPackagesOptionalViewModel>)ViewBag.listTourPackagesOptional;
    Entities.Models.Tour tour = (Entities.Models.Tour)ViewBag.Tour;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    textarea {
        min-height: 70px !important;
        min-width: 120px !important;
    }

    .style-width {
        max-width: 70px !important;
        min-width: 50px !important;
    }

    .style-width2 {
        min-width: 200px !important;
    }

    .style-width3 {
        min-width: 250px !important;
    }
    .form-control:disabled {
        background-color: #e8e8e8 !important;
    }
</style>
<div class=""bold mb15 txt_14"">Ghi chú</div>
<div class=""form-group"">
    <textarea class=""form-control service-tour-note"" disabled style=""height: 200px;"">");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                 Write(tour != null&& tour.Note!=null?tour.Note:"");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
</div>
<div class=""flex-auto mb15"" style="" justify-content: right;"">
    <div class=""form-group other-amount"" style=""min-width: 200px;width: 200px; "">
        <label class=""lbl text-center"" style=""width: 100%;"">Chi phí khác </label>
        <div class=""wrap_input"">
            <input id=""servicemanual-hotel-other-amount"" class=""form-control currency text-right servicemanual-hotel-other-amount"" disabled type=""text"" name=""servicemanual-hotel-other-amount"" placeholder=""Nhập chi phí khác""");
            BeginWriteAttribute("value", " value=\"", 1720, "\"", 1818, 1);
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 1728, tour != null&& tour.OthersAmount!=null ? ((double)tour.OthersAmount).ToString("N0"):"0", 1728, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
    <div class=""form-group discount"" style=""min-width: 200px;width: 200px;"">
        <label class=""lbl text-center"" style=""width: 100%;"">Hoa hồng CTV</label>
        <div class=""wrap_input"">
            <input id=""servicemanual-hotel-discount"" class=""form-control currency text-right servicemanual-hotel-discount"" disabled type=""text"" name=""servicemanual-hotel-discount"" placeholder=""Nhập chiết khấu""");
            BeginWriteAttribute("value", " value=\"", 2253, "\"", 2348, 1);
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 2261, tour != null&& tour.Commission!=null ?  ((double)tour.Commission).ToString("N0"):"0", 2261, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    <span>\r\n        <strong>Bảng kê dịch vụ phòng</strong> (Đơn giá đã bao gồm thuế phí + Phí dịch vụ Adavigo)\r\n");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
         if (  ViewBag.Tourstatus == (int)Utilities.Contants.ServiceStatus.OnExcution || ViewBag.Tourstatus == (int)Utilities.Contants.ServiceStatus.ServeCode)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-default green ml-1\" id=\"CCthanhtien\" style=\"color: white;\" onclick=\"_SetService_Tour_Detail.TTStatus()\">Cập nhật dịch vụ</a>");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                                                                                       }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a class=""btn btn-default green ml-1"" id=""Boqua"" style=""color: white; display:none"" onclick=""_SetService_Tour_Detail.BQStatus()"">Bỏ qua</a>
        <a class=""btn btn-default ml-1"" id=""luu"" style=""color: white; display: none"" onclick=""_SetService_Tour_Detail.Summit()"">Lưu</a>
    </span>
</div>
<br />

<div class=""table-responsive table-default table-gray"">
    <table class=""table table-nowrap "">
        <thead>
            <tr>
                <th style=""width: 80px; text-align: center;"">STT</th>
                <th style=""width: 150px; text-align: center;"">Mã dịch vụ</th>
                <th style=""width: 300px; text-align: center;"">Nhà cung cấp</th>
                <th style=""width: 150px; text-align: center;"">Loại dịch vụ</th>
                <th style=""width: 150px; text-align: center;"">Đơn giá</th>
                <th style=""width: 90px; text-align: center;"">Số lượng </th>
                <th style=""width: 90px; text-align: center;"">Số lần</th>
                <th class=""text-rig");
            WriteLiteral(@"ht"" style=""width: 150px; text-align: center;"">Thành tiền</th>
                <th style=""text-align: center;min-width:200px !important;"">Ghi chú</th>
                <th style=""text-align: center;"">Thao tác</th>
            </tr>
        </thead>
        <tbody class=""service-tour-extrapackage-tbody"">

");
#nullable restore
#line 86 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
             if (listTourPackagesOptional != null && listTourPackagesOptional.Count > 0)
            {
                foreach (var item in listTourPackagesOptional)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"service-tour-extrapackage-row\" data-extra-package-id=\"");
#nullable restore
#line 90 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td style=\"text-align: center;\" class=\"service-tour-stt\">");
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                             Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input name=\"service-tour-package-stt\" style=\"display:none\" class=\"form-control service-tour-package-stt\"");
            BeginWriteAttribute("value", " value=\"", 4744, "\"", 4760, 1);
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 4752, index, 4752, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n                        <td style=\"max-width: 150px;\">");
#nullable restore
#line 92 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                 Write(item.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <select disabled class=\"service-tour-extrapackage-SupplierId-select supplier-select style-width3\" style=\"background: #f0f0f0; width: 100% !important;\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96884b99afb317f8aa60dd232e463f1c5c78b38712339", async() => {
#nullable restore
#line 96 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                Write(item.SupplierId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 96 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                                   Write(item.SupplierName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                       WriteLiteral(item.SupplierId);

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
            WriteLiteral(@"
                            </select>
                        </td>
                        <td>
                            <select disabled style=""background: #f0f0f0; width: 100% !important"" class=""supplier-select  service-tour-extrapackage-Packageid-select"" name=""service-tour-extrapackage-Packageid-select"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96884b99afb317f8aa60dd232e463f1c5c78b38715013", async() => {
#nullable restore
#line 102 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                               Write(item.PackageidName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                       WriteLiteral(item.Packageid);

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
            WriteLiteral("\r\n\r\n                            </select>\r\n                        </td>\r\n                        <td> <input disabled style=\"background: #f0f0f0;\" class=\"form-control style-width2 text-right currency service-tour-extrapackage-Price\"");
            BeginWriteAttribute("value", " value=\"", 5859, "\"", 5905, 1);
#nullable restore
#line 106 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 5867, ((double)item.Price).ToString("N0"), 5867, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td> <input disabled style=\"background: #f0f0f0;\" class=\"form-control style-width text-right currency service-tour-extrapackage-Quantity\"");
            BeginWriteAttribute("value", " value=\"", 6075, "\"", 6101, 1);
#nullable restore
#line 107 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 6083, (item.Quantity), 6083, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td> <input disabled style=\"background: #f0f0f0; \" class=\"form-control style-width text-right currency service-tour-extrapackage-Times\"");
            BeginWriteAttribute("value", " value=\"", 6269, "\"", 6292, 1);
#nullable restore
#line 108 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 6277, (item.Times), 6277, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\r\n                        <td class=\"text-right\"> <input disabled style=\"background: #f0f0f0;\" class=\"form-control style-width2 text-right currency service-tour-extrapackage-amount\"");
            BeginWriteAttribute("value", " value=\"", 6482, "\"", 6529, 1);
#nullable restore
#line 110 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 6490, ((double)item.Amount).ToString("N0"), 6490, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><textarea class=\"form-control style-width2   textarea service-tour-extrapackage-Note\" disabled style=\"background: #f0f0f0;\">");
#nullable restore
#line 111 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                                                                                   Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea></td>\r\n                        <td style=\"text-align: center;\">\r\n                            <a class=\"fa fa-trash-o  service-tour-delete\" href=\"javascript:;\" style=\"display:none\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6890, "\"", 6973, 5);
            WriteAttributeValue("", 6900, "_SetService_Tour_Detail.DeleteTourPackageOptional(", 6900, 50, true);
#nullable restore
#line 113 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 6950, item.Id, 6950, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6958, ",", 6958, 1, true);
#nullable restore
#line 113 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 6959, item.TourId, 6959, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6971, ");", 6971, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 116 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <tr class=""service-tour-extrapackage-summary-row"">
                <td></td>
                <td>
                    <a href=""javascript:;"" class=""blue ml-2 mb10 service-tour-buttun"" style=""display:none"" onclick=""_SetService_Tour_Detail.AddTourPackage($(this));""><i class=""fa fa-plus-circle green""></i> Thêm dòng</a>

                </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td class=""text-right"">Tổng cộng</td>
");
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                 if (listTourPackagesOptional != null && listTourPackagesOptional.Count > 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-right service-tour-total-extrapackage-amount-after-vat\" data-extra-package-amount=\"0\">\r\n                        ");
#nullable restore
#line 134 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                    Write(((double)(listTourPackagesOptional.Sum(x => x.Amount))).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n");
#nullable restore
#line 137 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-right service-tour-total-extrapackage-amount-after-vat\" data-extra-package-amount=\"0\">\r\n                    </td>\r\n");
#nullable restore
#line 143 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <td></td>
                <td></td>
            </tr>
        </tbody>
    </table>
</div>

<h3 class=""txt_18 bold mb20"">
    Danh sách đoàn
</h3>
<p>Thông tin thành viên chính</p>
<div class=""wrap_bg wrap_bg_no-padding mb20"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th>Họ và tên</th>
                    <th>Ngày sinh</th>
                    <th>Giới tính</th>
                    <th>Số CCCD</th>
                    <th>Số phòng</th>
                    <th>Điện thoại</th>
                    <th>Email</th>
                    <th>Ghi chú</th>
                </tr>
            </thead>
            <tbody>
            <tbody>
");
#nullable restore
#line 172 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                 if (ContactClient != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 175 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                       Write(ContactClient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td>");
#nullable restore
#line 180 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                       Write(ContactClient.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 181 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                       Write(ContactClient.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 184 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<span>\r\n    Thông tin danh sách  thành viên khác\r\n");
#nullable restore
#line 191 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
     if (ViewBag.Tourstatus != 1 && ViewBag.Tourstatus != 4 && ViewBag.Tourstatus != 3 && ViewBag.Tourstatus != 5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-default green ml-1\" id=\"CCTourGuests\" style=\"color: white;\" onclick=\"_SetService_Tour_Detail.TTStatusTourGuests()\">Cập nhật danh sách đoàn</a>");
#nullable restore
#line 192 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                                                                                                     }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <a class=""btn btn-default green ml-1"" id=""BoquaTourGuests"" style=""color: white; display:none"" onclick=""_SetService_Tour_Detail.BQStatusTourGuests()"">Bỏ qua</a>
    <a class=""btn btn-default ml-1"" id=""luuTourGuests"" style=""color: white; display: none"" onclick=""_SetService_Tour_Detail.SummitTourGuests()"">Lưu</a>
</span>
<div class=""wrap_bg wrap_bg_no-padding mb20"" style=""margin-top:10px !important"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th>STT</th>
                    <th>Họ và tên</th>
                    <th>Ngày sinh</th>
                    <th>Giới tính</th>
                    <th>Số CCCD</th>
                    <th>Số phòng</th>
                    <th>Ghi chú</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 212 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                 if (ListTourGuests != null)
                {
                    foreach (var hg in ListTourGuests)
                    {
                        i2++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"service-TourGuests-extrapackage-row\" data-TourGuests-id=\"");
#nullable restore
#line 217 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                                                       Write(hg.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <td style=\"width:100px;\">");
#nullable restore
#line 218 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                Write(i2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"width:250px\">");
#nullable restore
#line 219 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                               Write(hg.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"width:200px\">");
#nullable restore
#line 220 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                                Write(Convert.ToDateTime(hg.Birthday).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 221 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                             if (hg.Gender != null)
                            {
                                if (hg.Gender == 0)
                                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"width:100px;\">Nam</td>\r\n");
#nullable restore
#line 228 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"width:100px;\">Nữ</td>\r\n");
#nullable restore
#line 232 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                                }

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"width:100px;\"></td>\r\n");
#nullable restore
#line 238 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td style=\"width: 200px;\"><input class=\"form-control style-width2 text-right TourGuests-CCCD\"");
            BeginWriteAttribute("value", " value=\"", 12164, "\"", 12180, 1);
#nullable restore
#line 240 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 12172, hg.Cccd, 12172, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled style=\"background: #f0f0f0;\" /></td>\r\n                            <td style=\"width: 200px;\"><input class=\"form-control style-width2 text-right TourGuests-RoomNumber\"");
            BeginWriteAttribute("value", " value=\"", 12356, "\"", 12378, 1);
#nullable restore
#line 241 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
WriteAttributeValue("", 12364, hg.RoomNumber, 12364, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled style=\"background: #f0f0f0;\" /></td>\r\n                            <td>");
#nullable restore
#line 242 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                           Write(hg.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 244 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\ListTourPackagesOrdered.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div class=\"attachment-operator border pd10\">\r\n</div>\r\n<script>\r\n    _SetService_Tour_Detail.TourOrderedInitialization()\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TourPackages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
