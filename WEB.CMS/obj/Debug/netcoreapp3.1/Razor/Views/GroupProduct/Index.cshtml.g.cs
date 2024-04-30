#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\GroupProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff468d47ca7b3df9b720193283e5c77813c00e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupProduct_Index), @"mvc.1.0.view", @"/Views/GroupProduct/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff468d47ca7b3df9b720193283e5c77813c00e1", @"/Views/GroupProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/groupProductManager.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\GroupProduct\Index.cshtml"
  
    ViewData["Title"] = "Quản lý danh mục";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .search-wrapper {
        max-width: 480px;
        width: 100%;
        margin-bottom: 10px;
        position: relative;
        border: 1px solid #D9D9D9;
        border-radius: 5px;
    }

    .text-inactive {
        font-size: 13px;
        color: red;
        margin-left: 20px;
    }

    .group__aff_checkbox {
        position: absolute;
        right: 120px;
    }

        .group__aff_checkbox .check-list {
            float: left;
            margin-left: 20px;
        }
</style>
<div class=""row-main container flex"">
    <div class=""row-main_col200"">
        <h2 class=""title_page"">Nhóm hàng</h2>
        <div class=""wrap_bg wrap_bg2"">
            <div class=""vai-tro"">
                <h3 class=""title-margin"">Tim kiếm</h3>
                <div class=""search-wrapper"">
                    <input type=""text"" id=""ip-kup-search-group-product"" placeholder=""Tên nhóm hàng"">
                    <span class=""search-btn"">
                        <button type=""button""");
            WriteLiteral(@">
                            <svg class=""icon-svg"">
                                <use xlink:href=""images/icons/icon.svg#search""></use>
                            </svg>
                        </button>
                    </span>
                </div>
                <label class=""radio radio-block"">
                    <input type=""radio"" name=""optradio"" onclick=""_groupProduct.OnSearchByStatus(-1)"" checked=""checked"">
                    <span class=""checkmark""></span>
                    Tất cả
                </label>
                <label class=""radio radio-block"">
                    <input type=""radio"" name=""optradio"" onclick=""_groupProduct.OnSearchByStatus(0)"">
                    <span class=""checkmark""></span>
                    Đang hoạt động
                </label>
                <label class=""radio radio-block"">
                    <input type=""radio"" name=""optradio"" onclick=""_groupProduct.OnSearchByStatus(1)"">
                    <span class=""checkmark""></span>
     ");
            WriteLiteral(@"               Ngừng hoạt động
                </label>
            </div>
        </div>
    </div>
    <div class=""row-main_col800"">
        <div class=""wrap_bg"">
            <div class=""widget-menu"">
                <div class=""form-group"">
                    <button type=""button"" class=""btn"" onclick=""_groupProduct.Expand()"">Mở rộng</button>
                    <button type=""button"" class=""btn"" onclick=""_groupProduct.Collapse()"">Thu gọn</button>
                    <button type=""button"" class=""btn"" onclick=""_groupProduct.AddOrUpdatePosition()"">
                        <i class=""fa fa-plus-circle""></i>Tạo kích thước
                    </button>
                    <button type=""button"" class=""btn"" id=""btn-add-parent-category"" style=""float:right;"">
                        <i class=""fa fa-plus-circle""></i>Tạo Website
                    </button>
                </div>
                <div class=""wrap-widget"">
                    <div class=""widget-header"">
                        <h4><i");
            WriteLiteral(@" class=""fa fa-bars""></i>Danh sách chuyên mục</h4>
                    </div>
                  
                    <ul class=""dd-list"" id=""grid-data"">
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff468d47ca7b3df9b720193283e5c77813c00e17384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
