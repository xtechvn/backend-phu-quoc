#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4b9c42537c0550e5374bee2c520f5a22dfb060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DebtBrick_History), @"mvc.1.0.view", @"/Views/DebtBrick/History.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
using Entities.ViewModels.Funding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
using Utilities.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4b9c42537c0550e5374bee2c520f5a22dfb060", @"/Views/DebtBrick/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DebtBrick_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
  
    var i = 1;
    var listDebtBrickLogViewModel = (List<DebtBrickLogViewModel>)ViewBag.listDebtBrickLogViewModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""white-popup"">
    <div class=""content_lightbox"">
        <div class=""table-responsive table-default table-gray table-modal mb20"">
            <table class=""table table-nowrap"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Thời gian</th>
                        <th>Nội dung</th>
");
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                     if (listDebtBrickLogViewModel != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                         foreach (var item in listDebtBrickLogViewModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                               Write(item.CreatedTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                     if (item.ObjectType == ObjectType.UNDO_DEBTBRICKLOG_ORDER)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            ");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đã gạch nợ ");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                                                 Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cho đơn hàng\r\n                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1487, 2);
            WriteAttributeValue("", 1451, "/Order/Orderdetails?id=", 1451, 23, true);
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
WriteAttributeValue("", 1474, item.OrderId, 1474, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                           Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </p>\r\n");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                     if (item.ObjectType == ObjectType.DEBTBRICKLOG_ORDER)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            ");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            đã bỏ gạch nợ ");
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                                     Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cho đơn hàng\r\n                                            <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 2084, "\"", 2127, 2);
            WriteAttributeValue("", 2091, "/Order/Orderdetails?id=", 2091, 23, true);
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
WriteAttributeValue("", 2114, item.OrderId, 2114, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                           Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </p>\r\n");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\History.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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