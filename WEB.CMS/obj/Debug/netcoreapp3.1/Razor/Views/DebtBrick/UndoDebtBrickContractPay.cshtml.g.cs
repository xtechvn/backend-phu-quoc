#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05f942b70593c41d019c4d17aa65845e7bc40f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DebtBrick_UndoDebtBrickContractPay), @"mvc.1.0.view", @"/Views/DebtBrick/UndoDebtBrickContractPay.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05f942b70593c41d019c4d17aa65845e7bc40f7", @"/Views/DebtBrick/UndoDebtBrickContractPay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DebtBrick_UndoDebtBrickContractPay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/add_debt_brick_contractpay.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
  
    var payId = (long)ViewBag.contractPayId;
    var clientId = (long)ViewBag.clientId;
    var clientName = (string)ViewBag.clientName;
    var billNo = (string)ViewBag.billNo;
    var amount = (double)ViewBag.amount;
    var payment = (double)ViewBag.payment;
    var amountRemain = amount - payment;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .white-popup {
        max-width: 1000px !important;
    }

    .content_lightbox .head {
        font-weight: 500 !important;
        font-size: 16px !important;
        margin-bottom: 20px !important;
    }

    .content_lightbox {
        padding: 20px !important;
    }
</style>


<div class=""grid grid__1 grid-don-hang gap10 mb20"">
    <input type=""text"" style=""display:none !important"" name=""name"" id=""clientName""");
            BeginWriteAttribute("value", " value=\"", 790, "\"", 809, 1);
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 798, clientName, 798, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"clientId\"");
            BeginWriteAttribute("value", " value=\"", 895, "\"", 912, 1);
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 903, clientId, 903, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"billNo\"");
            BeginWriteAttribute("value", " value=\"", 996, "\"", 1011, 1);
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 1004, billNo, 1004, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"payId\"");
            BeginWriteAttribute("value", " value=\"", 1094, "\"", 1108, 1);
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 1102, payId, 1102, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"amountOrder\"");
            BeginWriteAttribute("value", " value=\"", 1197, "\"", 1212, 1);
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 1205, amount, 1205, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"payment\"");
            BeginWriteAttribute("value", " value=\"", 1297, "\"", 1313, 1);
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 1305, payment, 1305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"amountRemain\"");
            BeginWriteAttribute("value", " value=\"", 1403, "\"", 1424, 1);
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 1411, amountRemain, 1411, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <div class=""grid-item border"">
        <div class=""row"">
            <div class=""col-4"">
                <label class=""lbl mt5 mb0"">Tên khách hàng </label>
            </div>
            <div class=""col-2"">
                <label class=""lbl mt5 mb0"">Mã phiếu thu </label>
            </div>
            <div class=""col-2"">
                <label class=""lbl mt5 mb0"">Số tiền</label>
            </div>
            <div class=""col-2"">
                <label class=""lbl mt5 mb0"">Đã giải trừ </label>
            </div>
            <div class=""col-2"">
                <label class=""lbl mt5 mb0"">Chưa giải trừ </label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <a");
            BeginWriteAttribute("href", " href=\"", 2178, "\"", 2221, 2);
            WriteAttributeValue("", 2185, "/CustomerManager/Detail?id=", 2185, 27, true);
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 2212, clientId, 2212, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"blue\">\r\n                        ");
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                   Write(clientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 2438, "\"", 2481, 2);
            WriteAttributeValue("", 2445, "/Receipt/Detail?contractPayId=", 2445, 30, true);
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 2475, payId, 2475, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 64 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
               Write(billNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 68 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                  Write(amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 71 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                  Write(payment.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                   Write(amountRemain.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input type=\"text\" id=\"amount\"");
            BeginWriteAttribute("value", " value=\"", 2915, "\"", 2936, 1);
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
WriteAttributeValue("", 2923, amountRemain, 2923, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display:none !important"" />
            </div>
        </div>
    </div>
</div>
<div>
    <div class=""bg-white border pd10 "" id=""order-relate"">
        <div class=""bold gray mb10"">Đơn hàng liên quan</div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table "" id=""order-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Mã đơn</th>
                        <th>Người tạo</th>
                        <th class=""text-right"">Số tiền</th>
                        <th class=""text-right"">Đã giải trừ</th>
                        <th class=""text-right"">Chưa giải trừ</th>
                        <th class=""text-right"">Đã giải trừ với phiếu ");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                                                                Write(billNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    </tr>
                </thead>
                <tbody id=""body_contract_pay_list"">
                </tbody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
</div>

<div class=""text-center"" style=""margin-top: 20px; margin-bottom: 20px;"">
    <button type=""submit"" class=""btn btn-default btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Bỏ qua</button>
    <button type=""submit"" class=""btn btn-default background-green"" onclick=""_add_debt_brick_contract_pay.UndoDebtBrick()"">Hoàn thành</button>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05f942b70593c41d019c4d17aa65845e7bc40f713891", async() => {
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
            WriteLiteral("\r\n<script>\r\n    _add_debt_brick_contract_pay.InitializationUnDebt(");
#nullable restore
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                                                 Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                                                            Write(payId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\UndoDebtBrickContractPay.cshtml"
                                                                    Write(amountRemain);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n</script>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $().ready(function () {\r\n            $(\'input\').attr(\'autocomplete\', \'off\');\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<style scoped>
    .background-green {
        background: #009900 !important;
    }

    .multiple-select {
        position: relative;
        max-width: 200px !important;
        width: 100%;
    }

    .select2-selection .select2-selection--single {
        height: 34px !important;
    }

    .token-input-client-add {
        min-width: 200px !important;
    }

        .token-input-client-add input {
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

    .row-main-head .down-up .form-down {
        width: 345px !important;
    }

    .form-control {
        background: #fff;");
            WriteLiteral(@"
        width: 100%;
        font-size: 13px;
        height: 30px;
        line-height: 30px;
        border: 1px solid #ccc;
        padding: 0 5px;
        outline: 0;
        box-shadow: none;
        color: #000;
        border-radius: 0.25rem !important;
    }

    .background-disabled {
        background: #eee !important;
    }
</style>");
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
