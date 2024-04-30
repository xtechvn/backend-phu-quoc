#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd6f366d08089dad085584f55ce27b196571e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd6f366d08089dad085584f55ce27b196571e31", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
  
    var _ListMenu = (List<Menu>)ViewBag.Menu;
    var ListNotify = (List<Menu>)ViewBag.GetListNotify;
    var _ParentMenus = _ListMenu.Where(s => s.ParentId == 0).OrderBy(s => s.OrderNo);
    var ActivedParentId = (int)ViewBag.ParentId;
    var ActivedMenuId = (int)ViewBag.MenuId;

    void GenChildMenu(int parentId)
    {
        var childDatas = _ListMenu.Where(s => s.ParentId == parentId);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
         if (childDatas != null && childDatas.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
             foreach (var subMenu in childDatas)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 609, "\"", 673, 1);
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 617, subMenu.Id == ActivedMenuId ? "active" : string.Empty, 617, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 674, "\"", 694, 1);
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 681, subMenu.Link, 681, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i");
            BeginWriteAttribute("class", " class=\"", 699, "\"", 720, 1);
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 707, subMenu.Icon, 707, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                                       Write(subMenu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 20 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"

                GenChildMenu(subMenu.Id);
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""menu-left"">

    <a class=""btn_control_menu"" href=""javascripts:;"">
        <svg class=""icon-svg"">
            <use xlink:href=""/images/icons/icon.svg#menu""></use>
        </svg>
    </a>
    <h1 class=""logo"" title=""new-ca"" href=""/"">
        <a href=""/"" class=""before""><img src=""/images/graphics/logo-white.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1186, "\"", 1192, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n        <a href=\"/\" class=\"after\"><img src=\"/images/graphics/logo-a.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1272, "\"", 1278, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n    </h1>\r\n    <div class=\"nav-left\">\r\n        <ul class=\"accordion\">\r\n");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
             foreach (var parent in _ParentMenus)
            {
                var parent_link = parent.Link;
                var childDatas = _ListMenu.Where(s => s.ParentId == parent.Id);
                if (string.IsNullOrEmpty(parent_link))
                {
                    var first_child = _ListMenu.FirstOrDefault(s => s.ParentId == parent.Id && !string.IsNullOrEmpty(s.Link));
                    parent_link = first_child.Link;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"accordion-item \">\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 2450, "\"", 2515, 1);
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2458, parent.Id == ActivedParentId ? "active" : string.Empty, 2458, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2516, "\"", 2535, 1);
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2523, parent_link, 2523, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 2565, "\"", 2585, 1);
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2573, parent.Icon, 2573, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> <span>");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                      Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                     if (childDatas!=null && childDatas.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"click\"></span>\r\n");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"level2 collapse\"");
            BeginWriteAttribute("style", " style=\"", 2851, "\"", 2954, 3);
            WriteAttributeValue(" ", 2859, "display:", 2860, 9, true);
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 2868, childDatas != null && childDatas.Any(x=>x.Id == ActivedMenuId) ? "block" : "none", 2869, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2953, ";", 2953, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                      
                        if (childDatas != null && childDatas.Any())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                             foreach (var subMenu in childDatas)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 3253, "\"", 3317, 1);
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 3261, subMenu.Id == ActivedMenuId ? "active" : string.Empty, 3261, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3318, "\"", 3338, 1);
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 3325, subMenu.Link, 3325, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 3381, "\"", 3402, 1);
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 3389, subMenu.Icon, 3389, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    <span> ");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                      Write(subMenu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                </li>\r\n");
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                             
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n                </li>\r\n");
#nullable restore
#line 85 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdd6f366d08089dad085584f55ce27b196571e3115295", async() => {
                WriteLiteral(@"
        <a class=""out"" onclick=""$(this).closest('form').submit(); _account.logOut()"" style=""cursor:pointer"">
			<svg class=""icon-svg"">
                    <use xlink:href=""/images/icons/icon.svg#Out""></use>
                </svg> Đăng xuất
		</a>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n");
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
