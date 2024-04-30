#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01862ddb61a635f3168ce0486683ea720ef71325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_DetailTable), @"mvc.1.0.view", @"/Views/Policy/DetailTable.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01862ddb61a635f3168ce0486683ea720ef71325", @"/Views/Policy/DetailTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Policy_DetailTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
  
    var PermisionType = (List<AllCode>)ViewBag.PermisionType;
    var DebtType = (List<AllCode>)ViewBag.DebtType;
    var ClientType = (List<AllCode>)ViewBag.ClientType;
    Layout = null;
    int index = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
 if (ViewBag.Type == 1)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-nowrap"">
        <thead>
            <tr>
                <th>STT</th>
                <th>Loại khách hàng</th>
                <th>Loại công nợ<sup class=""red"">*</sup></th>
                <th>Hạn mức công nợ VMB<sup class=""red"">*</sup></th>
                <th>Hạn mức công nợ KS<sup class=""red"">*</sup></th>
                <th>Hạn mức công nợ Tour<sup class=""red"">*</sup></th>
                <th>Hạn mức công nợ dịch vụ khác<sup class=""red"">*</sup></th>
                <th>Hạn mức công nợ VinWonder<sup class=""red"">*</sup></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
             foreach (var item in ClientType)
            {
                if (item.CodeValue != 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"servicemanual-policy-row\">\r\n                        <td class=\"servicemanual-policy-package\">");
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                                             Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input class=\"form-control servicemanual-Policy-Clienttype\" type=\"text\" name=\"servicemanual-Policy-Clienttype\"");
            BeginWriteAttribute("value", " value=\"", 2312, "\"", 2335, 1);
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
WriteAttributeValue("", 2320, item.CodeValue, 2320, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\"> ");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                                                                                                                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <select class=\"form-control servicemanual-Policy-DebtType\" style=\"min-width:150px;\" type=\"text\" name=\"servicemanual-Policy-DebtType\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01862ddb61a635f3168ce0486683ea720ef713256629", async() => {
                WriteLiteral("Tất cả loại công nợ");
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
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                 foreach (var i in DebtType)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01862ddb61a635f3168ce0486683ea720ef713258122", async() => {
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                                            Write(i.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                       WriteLiteral(i.CodeValue);

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
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </td>
                        <td><input class=""form-control text-right currency servicemanual-Policy-ProductFlyTicketDebtAmount"" type=""text"" name=""servicemanual-Policy-ProductFlyTicketDebtAmount""></td>
                        <td><input type=""text"" class=""form-control text-right currency servicemanual-Policy-HotelDebtAmout"" name="" servicemanual-Policy-HotelDebtAmout""");
            BeginWriteAttribute("value", " value=\"", 3312, "\"", 3320, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                       \r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-TourDebtAmount\" name=\" servicemanual-Policy-TourDebtAmount\"");
            BeginWriteAttribute("value", " value=\"", 3521, "\"", 3529, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-TouringCarDebtAmount\" name=\" servicemanual-Policy-TouringCarDebtAmount\"");
            BeginWriteAttribute("value", " value=\"", 3717, "\"", 3725, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-VinWonderDebtAmount\" name=\" servicemanual-Policy-VinWonderDebtAmount\"");
            BeginWriteAttribute("value", " value=\"", 3911, "\"", 3919, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
 if (ViewBag.Type == 2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-nowrap"">
        <thead>
            <tr>
                <th>STT</th>
                <th>Loại khách hàng</th>
                <th>Số dư ký quỹ VMB tối thiểu<sup class=""red"">*</sup></th>
                <th>Số dư ký quỹ KS tối thiểu<sup class=""red"">*</sup></th>
                <th>Số dư ký quỹ Tour<sup class=""red"">*</sup></th>
                <th>Số dư ký quỹ dịch vụ khác<sup class=""red"">*</sup></th>
                <th>Số dư ký quỹ VinWonder<sup class=""red"">*</sup></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
             foreach (var c in ClientType)
            {
                if (c.CodeValue != 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"servicemanual-policy-row\">\r\n                        <td class=\"servicemanual-policy-package\">");
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                                             Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input class=\"form-control servicemanual-Policy-Clienttype\" type=\"text\" name=\"servicemanual-Policy-Clienttype\"");
            BeginWriteAttribute("value", " value=\"", 5023, "\"", 5043, 1);
#nullable restore
#line 99 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
WriteAttributeValue("", 5031, c.CodeValue, 5031, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\"> ");
#nullable restore
#line 99 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                                                                                                                                                                                 Write(c.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        <td><input class=""form-control text-right currency servicemanual-Policy-ProductFlyTicketDepositAmount"" type=""text"" name=""servicemanual-Policy-ProductFlyTicketDepositAmount""></td>
                        <td><input type=""text"" class=""form-control text-right currency servicemanual-Policy-HotelDepositAmout"" name="" servicemanual-Policy-HotelDepositAmout""");
            BeginWriteAttribute("value", " value=\"", 5467, "\"", 5475, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-TourDepositAmount\" name=\" servicemanual-Policy-TourDepositAmount\"");
            BeginWriteAttribute("value", " value=\"", 5657, "\"", 5665, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-TouringCarDepositAmount\" name=\" servicemanual-Policy-TouringCarDepositAmount\"");
            BeginWriteAttribute("value", " value=\"", 5859, "\"", 5867, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                        <td><input type=\"text\" class=\"form-control text-right currency servicemanual-Policy-VinWonderDepositAmount\" name=\" servicemanual-Policy-VinWonderDepositAmount\"");
            BeginWriteAttribute("value", " value=\"", 6059, "\"", 6067, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    </tr>\r\n");
#nullable restore
#line 107 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Policy\DetailTable.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .hotel_service {\r\n        overflow-y: scroll;\r\n        overflow-x: hidden;\r\n    }\r\n</style>\r\n\r\n");
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
