#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ba020d15a5440fb1ec56dc515a17ab3cdfa894f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DebtBrick_AddWithContractPay), @"mvc.1.0.view", @"/Views/DebtBrick/AddWithContractPay.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba020d15a5440fb1ec56dc515a17ab3cdfa894f", @"/Views/DebtBrick/AddWithContractPay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_DebtBrick_AddWithContractPay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
  
    var payId = (long)ViewBag.contractPayId;
    var clientId = (long)ViewBag.clientId;
    var clientName = (string)ViewBag.clientName;
    var debtNote = (string)ViewBag.debtNote;
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
            BeginWriteAttribute("value", " value=\"", 836, "\"", 855, 1);
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 844, clientName, 844, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"clientId\"");
            BeginWriteAttribute("value", " value=\"", 941, "\"", 958, 1);
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 949, clientId, 949, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"billNo\"");
            BeginWriteAttribute("value", " value=\"", 1042, "\"", 1057, 1);
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 1050, billNo, 1050, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"payId\"");
            BeginWriteAttribute("value", " value=\"", 1140, "\"", 1154, 1);
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 1148, payId, 1148, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"amountOrder\"");
            BeginWriteAttribute("value", " value=\"", 1243, "\"", 1258, 1);
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 1251, amount, 1251, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"payment\"");
            BeginWriteAttribute("value", " value=\"", 1343, "\"", 1359, 1);
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 1351, payment, 1351, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" style=\"display:none !important\" name=\"name\" id=\"amountRemain\"");
            BeginWriteAttribute("value", " value=\"", 1449, "\"", 1470, 1);
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 1457, amountRemain, 1457, 13, false);

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
                <label class=""lbl mt5 mb0"">Mã phiếu </label>
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
            BeginWriteAttribute("href", " href=\"", 2220, "\"", 2263, 2);
            WriteAttributeValue("", 2227, "/CustomerManager/Detail?id=", 2227, 27, true);
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 2254, clientId, 2254, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"blue\">\r\n                        ");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                   Write(clientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 2480, "\"", 2523, 2);
            WriteAttributeValue("", 2487, "/Receipt/Detail?contractPayId=", 2487, 30, true);
#nullable restore
#line 64 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 2517, payId, 2517, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
               Write(billNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                  Write(amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                  Write(payment.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <label>");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                   Write(amountRemain.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input type=\"text\" id=\"amount\"");
            BeginWriteAttribute("value", " value=\"", 2957, "\"", 2978, 1);
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
WriteAttributeValue("", 2965, amountRemain, 2965, 13, false);

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
        <div class=""row"">
            <div class=""col-12"">
                <label class=""lbl mt5 mb0""> Ghi chú</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <textarea type=""text"" id=""note"" rows=""3"" style=""height:80px !important""></textarea>
            </div>
        </div>
    </div>
    <div class=""bg-white border pd10 "" id=""order-relate"">
        <div class=""bold gray mb10"">Đơn hàng liên quan</div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table "" id=""order-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Mã đơn</th>
                        <th>Người tạo</th>
                        <th class=""text-right"">Số ti");
            WriteLiteral(@"ền</th>
                        <th class=""text-right"">Đã giải trừ</th>
                        <th class=""text-right"">Chưa giải trừ</th>
                        <th class=""text-right"">Cần giải trừ</th>
                    </tr>
                </thead>
                <tbody id=""body_order_list"">
                </tbody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
</div>

<div class=""text-center"" style=""margin-top: 20px; margin-bottom: 20px;"">
    <button type=""submit"" class=""btn btn-default btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Bỏ qua</button>
    <button type=""submit"" class=""btn btn-default background-green"" onclick=""_add_debt_brick_contract_pay.AddNewContractPayDetail()"">Hoàn thành</button>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ba020d15a5440fb1ec56dc515a17ab3cdfa894f13991", async() => {
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
            WriteLiteral("\r\n<script>\r\n    _add_debt_brick_contract_pay.Initialization(");
#nullable restore
#line 125 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                                           Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 125 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                                                      Write(payId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 125 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                                                              Write(amountRemain);

#line default
#line hidden
#nullable disable
            WriteLiteral(", \'");
#nullable restore
#line 125 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\DebtBrick\AddWithContractPay.cshtml"
                                                                              Write(debtNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>\r\n");
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