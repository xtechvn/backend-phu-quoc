#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c11dcfe1830ca1638f67039da711373c8a79724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Index), @"mvc.1.0.view", @"/Views/Supplier/Index.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c11dcfe1830ca1638f67039da711373c8a79724", @"/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/supplier.js?v=3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/Hotel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
  
    ViewData["Title"] = "Danh sách nhà cung cấp";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
  
    var service_types = (List<AllCode>)ViewBag.ServiceTypes;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section style=""overflow-x: hidden;"">
    <div class=""row-main container"">
        <h2 class=""txt_18 bold mb20"">Danh sách nhà cung cấp</h2>
        <div class=""flex fillter-donhang"">
            <button type=""button"" class=""btn btn-default mb10 mr-2"" onclick=""_supplier_service.ShowAddOrUpdate(0)"">
                <i class=""fa fa-plus""></i>Tạo nhà cung cấp
            </button>
            <div class=""form-group mb10 mr-2"">
                <input type=""text"" class=""form-control"" id=""ip_search_fullname"" placeholder=""Tên nhà cung cấp"" style=""width: 150px;"">
            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 200px;"">
                <select");
            BeginWriteAttribute("class", " class=\"", 840, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"sl_search_service\" multiple style=\"width: 100%!important;\">\r\n");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
                     if (service_types != null && service_types.Any())
                    {
                        foreach (var item in service_types)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c11dcfe1830ca1638f67039da711373c8a797246202", async() => {
#nullable restore
#line 25 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
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
#line 25 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
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
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
            <div class=""form-group mb10 mr-2"" style=""min-width: 200px;"">
                <select class=""main-staff-select"" id=""sl_search_suggest_user"" style=""width:100%!important"">
                </select>
            </div>


            <div class=""row-main-head mb10 mr-2 mfp-hide"">
                <div class=""down-up"">
                    <a class=""btn btn-default onclick"" href=""javascript:;"">
                        <i class=""fa fa-bars""></i>
                        <i class=""fa fa-caret-down""></i>
                    </a>
                    <div class=""form-down"" style=""display: none;"">
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 2009, "\"", 2019, 0);
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
                <button class=""btn-search btn-default mfp-hide"" type=""button"" onclick=""_supplier_service.Export()"" id=""btnExport"">
                    <i class=""fa fa-file-excel-o"" id=""icon-export""></i>
                </button>
                <button type=""button"" class=""btn btn-default bg-main"" onclick=""_supplier_service.OnSearch()"">
                    <svg class=""icon-svg"" style=""vertical-align: sub;"">
                        <use xlink:href=""/images/icons/icon.svg#search""></use>
                    </svg>
                    Tìm kiếm
                </button>
            </div>
        </div>
        <div class=""line-bottom mb20"">
            <div class=""flex row-main-head"">

                <div class=""btn-right text-right "">
                    <div class=""row-main-head");
            WriteLiteral(@" mb10 mr-2"" style=""display: none;"">
                        <div class=""down-up"">
                            <a class=""btn btn-default onclick"" href=""javascript:;"">
                                <i class=""fa fa-bars""></i>
                                <i class=""fa fa-caret-down""></i>
                            </a>
                            <div class=""form-down text-nowrap"">
                                <div class=""grid-slide"">
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""STT"" onclick=""_supplier_service.ChangeSetting(1)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        STT
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""SupplierId"" onclick=""_supplier_serv");
            WriteLiteral(@"ice.ChangeSetting(2)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        ID
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""SupplierName"" onclick=""_supplier_service.ChangeSetting(3)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Tên nhà cung cấp
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""EstablistYear"" onclick=""_supplier_service.ChangeSetting(4)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Năm thành lập
          ");
            WriteLiteral(@"                          </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""Address"" onclick=""_supplier_service.ChangeSetting(5)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Địa điểm
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""Contact"" onclick=""_supplier_service.ChangeSetting(6)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Liên hệ
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""Service"" onclick=""_supplier_service.Ch");
            WriteLiteral(@"angeSetting(7)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Dịch vụ
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""SalerId"" onclick=""_supplier_service.ChangeSetting(8)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Nhân viên phụ trách
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""CreateBy"" onclick=""_supplier_service.ChangeSetting(9)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Người tạo
                      ");
            WriteLiteral(@"              </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""CreateDate"" onclick=""_supplier_service.ChangeSetting(10)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Ngày tạo
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""UpdatedBy"" onclick=""_supplier_service.ChangeSetting(11)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Người cập nhật
                                    </label>
                                    <label class=""check-list mb10 mr25"">
                                        <input type=""checkbox"" id=""UpdatedDate"" onclick=""_supplier_serv");
            WriteLiteral(@"ice.ChangeSetting(12)"" class=""checkbox-tb-column"" data-id=""1"">
                                        <span class=""checkmark""></span>
                                        Ngày cập nhật
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id=""grid_data"" class=""wrap_bg wrap_bg_no-padding mb20"">
            <div class=""col-xl-12 text-center"" style=""margin-top:200px"">
            </div>
        </div>
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c11dcfe1830ca1638f67039da711373c8a7972417577", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c11dcfe1830ca1638f67039da711373c8a7972418764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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