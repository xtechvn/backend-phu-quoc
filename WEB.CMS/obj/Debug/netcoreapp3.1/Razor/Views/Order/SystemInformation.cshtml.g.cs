#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34524a8e728a13e1c44dfeefcfd05242bc6f801f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_SystemInformation), @"mvc.1.0.view", @"/Views/Order/SystemInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34524a8e728a13e1c44dfeefcfd05242bc6f801f", @"/Views/Order/SystemInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_SystemInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"border bg-white mb20\">\r\n    <div class=\"lb-form pd10\">\r\n        Thông tin hệ thống\r\n    </div>\r\n");
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
     if (ViewBag.UserCreateId != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pd10\">\r\n    <ul class=\"mb0\">\r\n        <li class=\"grid grid__2\">\r\n            <div>Ngày tạo</div>\r\n            <div>: ");
#nullable restore
#line 11 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
              Write(ViewBag.UserCreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"grid grid__2\">\r\n            <div>Người tạo</div>\r\n            <div>: ");
#nullable restore
#line 15 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
              Write(ViewBag.UserCreateClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"grid grid__2\">\r\n            <div>Ngày cập nhật</div>\r\n            <div>: ");
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
               Write(ViewBag.UserUpdateTime != null ? ViewBag.UserUpdateTime : "N/A");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"grid grid__2\">\r\n            <div>Người cập nhật</div>\r\n            <div>: ");
#nullable restore
#line 23 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
               Write(ViewBag.UserUpdateClientName!=null? ViewBag.UserUpdateClientName : "N/A");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n    </ul>\r\n</div> ");
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pd10\">\r\n    N/A\r\n</div>");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\SystemInformation.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
