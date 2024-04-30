#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269a52dcc1353808e1d47a0f2f8c6d4747e8a390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_Tour), @"mvc.1.0.view", @"/Views/SetService/Tour.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
using Entities.ViewModels.Tour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269a52dcc1353808e1d47a0f2f8c6d4747e8a390", @"/Views/SetService/Tour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_Tour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/zebra_datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
  
    ViewData["Title"] = "Đặt dịch vụ Tour";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var BOOKING_HOTEL = (List<AllCode>)ViewBag.BOOKING_HOTEL;
    var BOOKING_HOTEL2 = (List<AllCode>)ViewBag.BOOKING_HOTEL2;
    var ORGANIZING_TYPE = (List<AllCode>)ViewBag.ORGANIZING_TYPE;
    var TOUR_TYPE = (List<AllCode>)ViewBag.TOUR_TYPE;
    var CountTourByStatus = (List<CountTourviewModel>)ViewBag.CountTourByStatus;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section style="" overflow-x: hidden;"">
    <div class=""row-main container"">
        <h2 class=""title_page mb20"">Danh sách dịch vụ tour</h2>
        <div class=""flex fillter-donhang"">
            <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">
                <select class=""select2 client-select main-staff-select"" id=""ServiceCode"" multiple=""multiple"" style=""width:100% !important"" placeholder=""Mã dịch vụ"">
                </select>

            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">
                <select class=""select2 client-select main-staff-select"" id=""OrderNo"" multiple=""multiple"" style=""width:100% !important"" placeholder=""Mã đơn hàng"">
                </select>

            </div>
            <div class=""multiple-select form-group mb10 mr-2"">
                <div class=""multiple-select form-group mb10 mr-2"" style="" width: 200px;    margin-top: 10px;"">
                    <div class=""select-btn select-btn-StatusBooking-type"" id=""select-b");
            WriteLiteral(@"tn-StatusBooking-type"">
                        <span class=""btn-text-StatusBooking-type"">Tất cả trạng thái</span>
                        <span class=""arrow-dwn"">
                            <i class=""fa fa-angle-down""></i>
                        </span>
                    </div>

                    <ul class=""list-items"" id=""list-item-StatusBooking"">
");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                         if (BOOKING_HOTEL2 != null && BOOKING_HOTEL2.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                             foreach (var item in BOOKING_HOTEL2)
                            {
                                if (item.CodeValue != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"item item-StatusBooking-type\"");
            BeginWriteAttribute("id", " id=\"", 2254, "\"", 2293, 2);
            WriteAttributeValue("", 2259, "StatusBooking_type_", 2259, 19, true);
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 2278, item.CodeValue, 2278, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 2359, "\"", 2407, 2);
            WriteAttributeValue("", 2364, "checkbox_StatusBooking_type_", 2364, 28, true);
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 2392, item.CodeValue, 2392, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"fa fa-check\"></i>\r\n                                        </span>\r\n                                        <span class=\"item-text\"");
            BeginWriteAttribute("id", " id=\"", 2596, "\"", 2640, 2);
            WriteAttributeValue("", 2601, "StatusBooking_type_text_", 2601, 24, true);
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 2625, item.CodeValue, 2625, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                                                                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
            </div>
            <div class=""multiple-select form-group mb10 mr-2"">
                <div class=""multiple-select form-group mb10 mr-2"" style="" width: 200px;    margin-top: 10px;"">
                    <div class=""select-btn select-btn-TourType-type"" id=""select-btn-TourType-type"">
                        <span class=""btn-text-TourType-type"">Tất cả loại tour</span>
                        <span class=""arrow-dwn"">
                            <i class=""fa fa-angle-down""></i>
                        </span>
                    </div>

                    <ul class=""list-items"" id=""list-item-TourType"">
");
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                         if (TOUR_TYPE != null && TOUR_TYPE.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                             foreach (var item in TOUR_TYPE)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"item item-TourType-type\"");
            BeginWriteAttribute("id", " id=\"", 3745, "\"", 3779, 2);
            WriteAttributeValue("", 3750, "TourType_type_", 3750, 14, true);
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 3764, item.CodeValue, 3764, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <span class=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 3841, "\"", 3884, 2);
            WriteAttributeValue("", 3846, "checkbox_TourType_type_", 3846, 23, true);
#nullable restore
#line 71 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 3869, item.CodeValue, 3869, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fa fa-check\"></i>\r\n                                    </span>\r\n                                    <span class=\"item-text\"");
            BeginWriteAttribute("id", " id=\"", 4061, "\"", 4100, 2);
            WriteAttributeValue("", 4066, "TourType_type_text_", 4066, 19, true);
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 4085, item.CodeValue, 4085, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </ul>
                </div>
            </div>
            <div class=""multiple-select form-group mb10 mr-2"">
                <div class=""multiple-select form-group mb10 mr-2"" style="" width: 220px;    margin-top: 10px;"">
                    <div class=""select-btn select-btn-OrganizingType-type"" id=""select-btn-OrganizingType-type"">
                        <span class=""btn-text-OrganizingType-type"">Tất cả hình thức tổ chức</span>
                        <span class=""arrow-dwn"">
                            <i class=""fa fa-angle-down""></i>
                        </span>
                    </div>

                    <ul class=""list-items"" id=""list-item-OrganizingType"">
");
#nullable restore
#line 94 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                         if(ORGANIZING_TYPE!=null&& ORGANIZING_TYPE.Count>0){
                          

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                           foreach (var item in ORGANIZING_TYPE)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"item item-OrganizingType-type\"");
            BeginWriteAttribute("id", " id=\"", 5186, "\"", 5226, 2);
            WriteAttributeValue("", 5191, "OrganizingType_type_", 5191, 20, true);
#nullable restore
#line 97 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 5211, item.CodeValue, 5211, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span class=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 5284, "\"", 5333, 2);
            WriteAttributeValue("", 5289, "checkbox_OrganizingType_type_", 5289, 29, true);
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 5318, item.CodeValue, 5318, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa fa-check\"></i>\r\n                                </span>\r\n                                <span class=\"item-text\"");
            BeginWriteAttribute("id", " id=\"", 5498, "\"", 5543, 2);
            WriteAttributeValue("", 5503, "OrganizingType_type_text_", 5503, 25, true);
#nullable restore
#line 101 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 5528, item.CodeValue, 5528, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                                                                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n");
#nullable restore
#line 103 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </ul>
                </div>
            </div>
            <div class=""form-group mb10 mr-2"">
                <div class=""datepicker-wrap"" style=""width:100%"">
                    <input class=""form-control date text-left filter_date_daterangepicker"" id=""StartDate"" type=""text""
                           name=""datetimeApprove"" style=""min-width: 180px !important"" placeholder=""Ngày check in"" />

                </div>
            </div>
            <div class=""form-group mb10 mr-2"">
                <div class=""datepicker-wrap"" style=""width:100%"">
                    <input class=""form-control date text-left filter_date_daterangepicker"" id=""EndDate"" type=""text""
                           name=""datetimeApprove2"" style=""min-width: 180px !important"" placeholder=""Ngày check out"" />
                </div>
            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">

                <select class=""select2 client-select main-staff-select"" id=""UserC");
            WriteLiteral(@"reate"" multiple=""multiple"" style=""width:100% !important"">
                </select>
            </div>
            <div class=""form-group mb10 mr-2"">
                <div class=""datepicker-wrap"" style=""width:100%"">
                    <input class=""form-control date text-left filter_date_daterangepicker"" id=""CreateDate"" type=""text""
                           name=""datetimeApprove3"" style=""min-width: 180px !important"" placeholder=""Ngày tạo"" />
                </div>
            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">

                <select class=""select2 client-select main-staff-select"" id=""SalerId"" multiple=""multiple"" style=""width:100% !important"">
                </select>
            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">

                <select class=""select2 client-select main-staff-select"" id=""OperatorId"" multiple=""multiple"" style=""width:100% !important"">
                </select>
            </div>
   ");
            WriteLiteral(@"         <div class=""form-group mb10 mr-2"" style=""min-width: 220px;"">
                <select class=""select2 client-select main-staff-select"" id=""BookingCode"" style=""width:100% !important"">
                </select>
            </div>
            <div class=""row-main-head mb10 mr-2"" style=""display:none"">
                <div class=""down-up"">
                    <a class=""btn btn-default onclick"" href=""javascript:;"">
                        <i class=""fa fa-bars""></i>
                        <i class=""fa fa-caret-down""></i>
                    </a>
                    <div class=""form-down"" style=""display: none;"">
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 8455, "\"", 8465, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""checkmark""></span>
                            Hình thức
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"">
                            <span class=""checkmark""></span>
                            Mã đơn
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"">
                            <span class=""checkmark""></span>
                            Ngày bắt đầu
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"">
                            <span class=""checkmark""></span>
                            Ngày kết thúc
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"">
                     ");
            WriteLiteral(@"       <span class=""checkmark""></span>
                            Nhãn đơn
                        </label>
                    </div>
                </div>
            </div>
            <div class=""mb10 mr-2"">
                <button class=""btn-search btn-default"" type=""button"" onclick=""_SetServiceTour.Export()"" id=""btnExport"">
                    <i class=""fa fa-file-excel-o"" id=""icon-export"" title=""Xuất excel"">
                    </i>
                </button>
                <button type=""button"" class=""btn btn-default bg-main"" onclick=""_SetServiceTour.SearchData()"">
                    <svg class=""icon-svg"" style=""vertical-align: sub;"">
                        <use xlink:href=""/images/icons/icon.svg#search""></use>
                    </svg>
                    Tìm kiếm
                </button>
            </div>
        </div>
        <div class=""line-bottom"" style=""padding-bottom: 0;"">
            <div class=""row"">
                <div class=""tab-default col-md-9 mb0 mt10"">
  ");
            WriteLiteral("                  <a href=\"javascript:;\" onclick=\"_SetServiceTour.OnSearchStatus(-1)\" id=\"StatusBookingAll\" class=\"active\">Tất cả (0)</a>\r\n");
#nullable restore
#line 200 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                     if (CountTourByStatus != null && CountTourByStatus.Count > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                         foreach (var i in CountTourByStatus)
                        {
                            if (i.Status != 0)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10985, "\"", 11036, 3);
            WriteAttributeValue("", 10995, "_SetServiceTour.OnSearchStatus(", 10995, 31, true);
#nullable restore
#line 207 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 11026, i.Status, 11026, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11035, ")", 11035, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 11037, "\"", 11065, 2);
            WriteAttributeValue("", 11042, "StatusBooking_", 11042, 14, true);
#nullable restore
#line 207 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
WriteAttributeValue("", 11056, i.Status, 11056, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 207 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                                                                                                                   Write(i.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 207 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                                                                                                                                                  Write(i.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n");
#nullable restore
#line 208 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\Tour.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div id=""grid_data_Search"">
            <img src=""/images/icons/loading.gif"" style="" width: 100px; height: 100px; margin-left:46%;"" id=""imgLoading_Search"" />
        </div>
    </div>
</section>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269a52dcc1353808e1d47a0f2f8c6d4747e8a39025388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"" src=""/modules/SetServiceTour.js""></script>
    <script>
        $('input[name=""datetimeApprove""]').daterangepicker({
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name=""datetimeApprove""]').on('cancel.daterangepicker', function (ev, picker) {
            $('#StartDate').val('');
            isPickerApprove = false;
        });
        $('input[name=""datetimeApprove""]').on('apply.daterangepicker', function (ev, picker) {
            $('#StartDate').val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
            isPickerApprove = true;
        });
        $('input[name=""datetimeApprove2""]').daterangepicker({
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name=""datetimeApprove2""]').on('cancel.daterangepicker', function (ev, picker) {
   ");
                WriteLiteral(@"         $('#EndDate').val('');
            isPickerApprove2 = false;
        });
        $('input[name=""datetimeApprove2""]').on('apply.daterangepicker', function (ev, picker) {
            $('#EndDate').val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
            isPickerApprove2 = true;
        });
        $('input[name=""datetimeApprove3""]').daterangepicker({
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name=""datetimeApprove3""]').on('cancel.daterangepicker', function (ev, picker) {
            $('#CreateDate').val('');
            isPickerApprove3 = false;
        });
        $('input[name=""datetimeApprove3""]').on('apply.daterangepicker', function (ev, picker) {
            $('#CreateDate').val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
            isPickerApprove3 = true;
        });
    </script>
");
            }
            );
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
