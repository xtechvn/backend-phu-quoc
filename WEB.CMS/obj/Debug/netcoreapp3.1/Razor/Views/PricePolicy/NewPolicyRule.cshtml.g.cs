#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PricePolicy\NewPolicyRule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5b1af5def83fbed1ee0defb86f66d51e4caa48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PricePolicy_NewPolicyRule), @"mvc.1.0.view", @"/Views/PricePolicy/NewPolicyRule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b1af5def83fbed1ee0defb86f66d51e4caa48e", @"/Views/PricePolicy/NewPolicyRule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_PricePolicy_NewPolicyRule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PricePolicy\NewPolicyRule.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PricePolicy\NewPolicyRule.cshtml"
   
    int lvl = (int)ViewBag.level;
    int service_type = (int)ViewBag.service_type;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mb10 add_new_block\" data-value=\"-1\" data-serviceid=\"");
#nullable restore
#line 9 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PricePolicy\NewPolicyRule.cshtml"
                                                           Write(service_type);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
    <div class=""tag-input-price price_detail_input "">
        <input type=""text"" class=""form-control price_detail_input price_detail_input_profit"" data-mode-new=""0"" value=""0"">
        <div class=""tag  price_detail_input_price_unit "">
            <a class=""active price_detail_unit_active price_detail_event_changeprice_unit price_detail_unit_vnd""
               data-percent=""0"" data-unitid=""2"" href=""javascript:;"">VND</a>
            <a class="" price_detail_event_changeprice_unit price_detail_unit_percent""
               data-vnd=""0"" data-unitid=""1"" href=""javascript:;"">%</a>
        </div>
    </div>
    - Từ:
    <div class=""tag-input-date"">
        <input class=""form-control date datefilter price_detail_input price_detail_input_fromdate init_fromdate"" type=""text"" name=""price_detail_date_add_new"" value=""01/01/2022 00:00"">
    </div>
    đến
    <div class=""tag-input-date"">
        <input class=""form-control date datefilter price_detail_input price_detail_input_todate init_todate"" type=""text"" ");
            WriteLiteral("name=\"price_detail_date_add_new\" value=\"01/01/2022 00:00\">\r\n    </div>\r\n    <span class=\"controler show  ml-2 price_detail_input_button\">\r\n        <a href=\"javascript:;\" class=\"btn-default update_price_detail_add_new\" data-lvl=\"");
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PricePolicy\NewPolicyRule.cshtml"
                                                                                    Write(lvl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Thêm mới</a>\r\n        <a href=\"javascript:;\" class=\"ml-1 blue cancel_edit_price_detail_add_new\">Hủy</a>\r\n    </span>\r\n    <script>\r\n        _pricepolicymanagement.NewPolicyRuleInit();\r\n    </script>\r\n</div>\r\n");
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