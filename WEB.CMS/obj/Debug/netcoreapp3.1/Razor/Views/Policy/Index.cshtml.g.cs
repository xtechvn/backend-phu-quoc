#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec99ead71efab9b4e211ac4fb2260db2c69a28e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Index), @"mvc.1.0.view", @"/Views/Policy/Index.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec99ead71efab9b4e211ac4fb2260db2c69a28e9", @"/Views/Policy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Policy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/zebra_datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
  
  
    var PermisionType = (List<AllCode>)ViewBag.PermisionType;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container""></div>
<section style="" overflow-x: hidden;"">
    <div class=""row-main container"">
        <h2 class=""txt_18 bold mb20"">Chính sách hợp tác</h2>
        <div class=""flex fillter-donhang mb10"">

            <div class=""form-group mb10 mr-2"">
                <input type=""text"" class=""form-control"" id=""PolicyName"" placeholder=""Mã KH, Tên KH, Điện thoại, Email"" style=""width: 220px;"">
            </div>

            <div class=""form-group mb10 mr-2"">
                <div class=""datepicker-wrap"" style=""width:100%"">
                    <div class=""datepicker-wrap"" style=""width:100%"">
                        <input class=""form-control date text-left filter_date_daterangepicker"" id=""EffectiveDateFrom"" type=""text""
                               name=""datetimeApprove"" style=""min-width: 180px !important"" placeholder=""Ngày hiệu lực"" />
                    </div>

                </div>
            </div>
            <div class=""form-group mb10 mr-2"">
                <select class=");
            WriteLiteral("\"select2\" id=\"PermissionType\"");
            BeginWriteAttribute("name", " name=\"", 1153, "\"", 1160, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 220px; height: 30px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec99ead71efab9b4e211ac4fb2260db2c69a28e95936", async() => {
                WriteLiteral("Tất cả nhóm khách hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
                     if (PermisionType != null)
                    {
                        foreach (var item in PermisionType)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec99ead71efab9b4e211ac4fb2260db2c69a28e97481", async() => {
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
                               WriteLiteral(item.CodeValue);

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
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>

            <div class=""form-group mb10 mr-2""style=""min-width:365px"">
                
                <select class=""select2 client-select main-staff-select"" id=""UserCreate"" multiple=""multiple"" style=""width:100% !important"">
                </select>
            </div>

            <div class=""form-group mb10 mr-2"">
                <div class=""datepicker-wrap"" style=""width:100%"">
                    <input class=""form-control date text-left filter_date_daterangepicker"" id=""CreateDate"" type=""text""
                           name=""datetimeApprove2"" style=""min-width: 180px !important"" placeholder=""Ngày tạo"" />
                </div>
            </div>


          
            <div class=""mb10 mr-2"">
                <button type=""button"" class=""btn btn-default bg-main"" onclick=""_Policy.SearchData()"">
                    <svg class=""icon-svg"" style=""vertical-align: sub;"">
                        <use xlink:href=""/images/icons/icon.svg#search""></us");
            WriteLiteral(@"e>
                    </svg>
                    Tìm kiếm
                </button>
            </div>
        </div>

        <div class=""line-bottom mb20"">
            <div class=""flex row-main-head"">

                <div class=""btn-right text-right"">
                    <button type=""button"" class=""btn btn-default bg-main mb10 mr-2"" onclick=""_Policy.OpenPopup('')""><i class=""fa fa-plus-circle""></i>Tạo mới chính sách</button>
                    <div class=""row-main-head mb10 mr-2"" style=""display:none"">
                        <div class=""down-up"">
                            <a class=""btn btn-default onclick"" href=""javascript:;"">
                                <i class=""fa fa-bars""></i>
                                <i class=""fa fa-caret-down""></i>
                            </a>
                            <div class=""form-down text-nowrap"" style=""display: none;"">
                                <div class=""grid-slide"">
                                    <label class=""check-list ");
            WriteLiteral(@"mb10 mr25"">
                                        <input type=""checkbox"" id=""STT"" onclick=""_Policy.ChangeSetting(1)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        STT
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""PolicyId"" onclick=""_Policy.ChangeSetting(2)"" class=""checkbox-tb-column"" data-id=""2"">
                                        <span class=""checkmark""></span>
                                        Id
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""PolicyNameCS"" onclick=""_Policy.ChangeSetting(3)"" class=""checkbox-tb-column"" data-id=""3"">
                                        <span class=""checkmark""></span>
     ");
            WriteLiteral(@"                                   Tên
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""EffectiveDate"" onclick=""_Policy.ChangeSetting(4)"" class=""checkbox-tb-column"" data-id=""4"">
                                        <span class=""checkmark""></span>
                                        Hiệu lực từ ngày
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""PermissionTypeCS"" onclick=""_Policy.ChangeSetting(5)"" class=""checkbox-tb-column"" data-id=""5"">
                                        <span class=""checkmark""></span>
                                        Nhóm khách hàng
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <inp");
            WriteLiteral(@"ut type=""checkbox"" id=""CreatedDate"" onclick=""_Policy.ChangeSetting(6)"" class=""checkbox-tb-column"" data-id=""6"">
                                        <span class=""checkmark""></span>
                                        Ngày tạo
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""CreatedBy"" onclick=""_Policy.ChangeSetting(7)"" class=""checkbox-tb-column"" data-id=""7"">
                                        <span class=""checkmark""></span>
                                        Người tạo
                                    </label>

                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""ThaoT"" onclick=""_Policy.ChangeSetting(8)"" class=""checkbox-tb-column"" data-id=""8"">
                                        <span class=""checkmark""></span>
                                        Thao t");
            WriteLiteral(@"ác
                                    </label>
                                   
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"
        <div id=""grid_data_Search"">
            <img src=""/images/icons/loading.gif"" style="" width: 100px; height: 100px; margin-left:46%;"" id=""imgLoading_Search"" />
        </div>
    </div>
</section>
<style>
    .row-main-head .down-up .form-down {
        width: 370px !important;
    }

    .grid-slide {
        display: grid;
        grid-template-columns: auto auto;
    }

    .token-input-input-token input {
        background: #fff !important;
        width: 100% !important;
        font-size: 13px !important;
        height: 30px !important;
        line-height: 30px !important;
        border: 1px solid #ccc !important;
        padding: 0 5px !important;
        outline: 0 !important;
        box-shadow: none !important;
        color: #000 !important;
        border-radius: 0.25rem !important;
    }
</style>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"/modules/Policy.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec99ead71efab9b4e211ac4fb2260db2c69a28e916354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
    
        $('input[name=""datetimeApprove""]').daterangepicker({
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name=""datetimeApprove""]').on('cancel.daterangepicker', function (ev, picker) {
            $('#EffectiveDateFrom').val('');
            isPickerApprove = false;
        });
        $('input[name=""datetimeApprove""]').on('apply.daterangepicker', function (ev, picker) {
            $('#EffectiveDateFrom').val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
            isPickerApprove = true;
        });

        $('input[name=""datetimeApprove2""]').daterangepicker({
            autoUpdateInput: false,
            locale: {
                cancelLabel: 'Clear'
            }
        });
        $('input[name=""datetimeApprove2""]').on('cancel.daterangepicker', function (ev, picker) {
            $('#CreateDate').val('');
            isPicke");
                WriteLiteral(@"rApprove2 = false;
        });
        $('input[name=""datetimeApprove2""]').on('apply.daterangepicker', function (ev, picker) {
            $('#CreateDate').val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
            isPickerApprove2 = true;
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