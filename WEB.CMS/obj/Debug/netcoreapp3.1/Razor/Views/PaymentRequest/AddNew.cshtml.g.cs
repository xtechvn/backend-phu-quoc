#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0494a7f4361af257001e8a9d388a5ffb1771601a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentRequest_AddNew), @"mvc.1.0.view", @"/Views/PaymentRequest/AddNew.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0494a7f4361af257001e8a9d388a5ffb1771601a", @"/Views/PaymentRequest/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_PaymentRequest_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/add_payment_request.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
  
    var allCode_PAY_TYPE = (List<AllCode>)ViewBag.allCode_PAY_TYPE;
    var allCode_PAYMENT_VOUCHER_TYPE = (List<AllCode>)ViewBag.allCode_PAYMENT_VOUCHER_TYPE;
    var listPayment = (List<BankingAccount>)ViewBag.listPayment;
    var serviceId = (long)ViewBag.serviceId;
    var serviceType = (int)ViewBag.serviceType;
    var supplierId = (long)ViewBag.supplierId;
    var amount = (decimal)ViewBag.amount;
    var totalPayment = (decimal)ViewBag.totalPayment;
    var supplierName = (string)ViewBag.supplierName;
    var serviceCode = (string)ViewBag.serviceCode;
    var orderId = (long)ViewBag.orderId;
    var clientId = (int)ViewBag.clientId;
    var clientName = (string)ViewBag.clientName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .white-popup {
        max-width: 900px !important;
    }

    .content_lightbox .head {
        font-weight: 500 !important;
        font-size: 16px !important;
        margin-bottom: 20px !important;
    }

    .content_lightbox {
        padding: 20px !important;
    }

    .check-list1 {
        padding-left: 25px;
        position: unset;
        cursor: pointer;
        display: block;
        margin-bottom: 0;
    }

        .check-list1 .number {
            padding-right: 25px;
            padding-left: 0;
            display: inline-block;
        }
</style>


<div class=""grid grid__2 grid-don-hang gap10 mb20"">
    <div class=""grid-item border"">
        <input type=""text"" name=""serviceId"" id=""serviceId""");
            BeginWriteAttribute("value", " value=\"", 1508, "\"", 1526, 1);
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 1516, serviceId, 1516, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"serviceType\" id=\"serviceType\"");
            BeginWriteAttribute("value", " value=\"", 1616, "\"", 1636, 1);
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 1624, serviceType, 1624, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"supplierId_service\" id=\"supplierId_service\"");
            BeginWriteAttribute("value", " value=\"", 1740, "\"", 1759, 1);
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 1748, supplierId, 1748, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"amount_service\" id=\"amount_service\"");
            BeginWriteAttribute("value", " value=\"", 1855, "\"", 1870, 1);
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 1863, amount, 1863, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"totalPayment_service\" id=\"totalPayment_service\"");
            BeginWriteAttribute("value", " value=\"", 1978, "\"", 1999, 1);
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 1986, totalPayment, 1986, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"orderId\" id=\"orderId\"");
            BeginWriteAttribute("value", " value=\"", 2081, "\"", 2097, 1);
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 2089, orderId, 2089, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"clientId_service\" id=\"clientId_service\"");
            BeginWriteAttribute("value", " value=\"", 2197, "\"", 2214, 1);
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 2205, clientId, 2205, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"clientId_name\" id=\"clientId_name\"");
            BeginWriteAttribute("value", " value=\"", 2308, "\"", 2327, 1);
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 2316, clientName, 2316, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"supplierName\" id=\"supplierName\"");
            BeginWriteAttribute("value", " value=\"", 2419, "\"", 2440, 1);
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 2427, supplierName, 2427, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none\" />\r\n        <input type=\"text\" name=\"serviceCode\" id=\"serviceCode\"");
            BeginWriteAttribute("value", " value=\"", 2530, "\"", 2550, 1);
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
WriteAttributeValue("", 2538, serviceCode, 2538, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none"" />

        <div class=""col-md-6 mb10""><label class=""lbl mt5 mb0"">Loại nghiệp vụ <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""payment-request-type""
                    onchange=""_add_payment_request.OnChooseRequestType()"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a11334", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                 foreach (var item in allCode_PAYMENT_VOUCHER_TYPE)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a13413", async() => {
#nullable restore
#line 68 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
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
#line 68 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
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
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
            <div class=""validate-payment-request-type""></div>
        </div>

        <div class=""col-md-6 mb10"" id=""lblSupplier""><label class=""lbl mt5 mb0"">Tên nhà cung cấp <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"" id=""divSupplier"" style="" max-width: 425px !important;"">
            <select class=""select2 supplier-select"" id=""supplier-select"" style=""width:100% !important"" multiple=""multiple""
                    onchange=""_add_payment_request.OnChooseRequestType();_add_payment_request.OnChooseSupllier()"">
            </select>
            <div class=""validate-supplier-select""></div>
        </div>

        <div class=""col-md-6 mb10"" id=""lblCustomer""><label class=""lbl mt5 mb0"">Tên khách hàng <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"" id=""divCustomer"" style="" max-width: 425px !important;"">
            <select class=""select2 client-select"" id=""client-select"" style=""width:100% !important"" multiple=""multiple""
     ");
            WriteLiteral(@"               onchange=""_add_payment_request.OnChooseRequestType()"">
            </select>
            <div class=""validate-client-select""></div>
        </div>

        <div class=""col-md-6 mb10""><label class=""lbl mt5 mb0""> Số tiền <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <input type=""text"" class=""form-control"" id=""amount"" onkeyup=""_add_payment_request.FormatNumber();"" autocomplete=""off"" maxlength=""15"">
            <div class=""validate-amount""></div>
        </div>

        <div class=""col-md-12 mb10""> <label class=""lbl mt5 mb0""> Nội dung <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <input type=""text"" id=""content"" maxlength=""500"" name=""name"" placeholder=""Nhập text(tối đa 500 kí tự)"" autocomplete=""off"" />
            <div class=""validate-content""></div>
        </div>

    </div>
    <div class=""grid-item border"">

        <div class=""col-md-6 mb10""> <label class=""lbl mt5 mb0""> Hình thức <sup class=""");
            WriteLiteral(@"red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""payment-request-pay-type""
                    onchange=""_add_payment_request.OnChoosePaymentType()"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a17925", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                 foreach (var item in allCode_PAY_TYPE)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a19993", async() => {
#nullable restore
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
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
#line 112 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
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
#line 113 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n            <div class=\"validate-payment-request-pay-type\"></div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 118 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
         if (clientId > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-6 mb10 "">
                <label class=""lbl mt5 mb0"" id=""lblBankAccountRequired"">Tài khoản ngân hàng nhận <sup class=""red"">*</sup></label>
                <label class=""lbl mt5 mb0"" id=""lblBankAccount"">Tài khoản ngân hàng nhận</label>
            </div>
            <div class=""col-md-12 mb10 "">
                <select class=""form-control "" style=""width: 100%; height: 34px ;"" id=""bankingAccount""
                        onchange=""_add_payment_request.GetAccountName()"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a22915", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 128 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                     foreach (var item in listPayment)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a24990", async() => {
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                                            Write(item.BankId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                                                           Write(item.AccountNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                           WriteLiteral(item.Id);

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
#line 131 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <div class=\"validate-bankingAccount\"></div>\r\n            </div>\r\n");
#nullable restore
#line 135 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-6 mb10 "">
                <label class=""lbl mt5 mb0"" id=""lblBankAccountRequired"">Tài khoản ngân hàng nhận <sup class=""red"">*</sup></label>
                <label class=""lbl mt5 mb0"" id=""lblBankAccount"">Tài khoản ngân hàng nhận</label>
            </div>
            <div class=""col-md-12 mb10 "">
                <select class=""form-control "" style=""width: 100%; height: 34px ;"" id=""bankingAccount""
                        onchange=""_add_payment_request.GetAccountName()"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a28186", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n                <div class=\"validate-bankingAccount\"></div>\r\n            </div>\r\n");
#nullable restore
#line 149 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\PaymentRequest\AddNew.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""col-md-6 mb10"">
            <label class=""lbl mt5 mb0"">Tên người thụ hưởng</label>
        </div>
        <div class=""col-md-12 mb10"">
            <input class=""form-control background-disabled"" type=""text"" name=""bankName"" id=""bankName"" disabled>
        </div>

        <div class=""col-md-6 mb10""><label class=""lbl mt5 mb0"">Thời hạn thanh toán<sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"" style=""width: 100% !important"">
            <input class=""form-control datepicker-payment"" type=""text"" name=""paymentDate"" id=""paymentDate""
                   style=""width: 100% !important"">
            <div class=""validate-paymentDate""></div>
        </div>

        <div class=""col-md-6 mb10"" style="" margin-top: 50px !important;"" id=""divIsSupplierDebt"">
            <label class=""lbl mb0"">Công nợ với nhà cung cấp </label>
            <label class=""check-list  number"" style=""display: contents !important;"">
                <input type=""checkbox"" id=""isSupplierDeb");
            WriteLiteral(@"t"">
                <span class=""checkmark""></span>
            </label>
        </div>
    </div>

</div>
<div class=""row m-0 p-0"">

    <div class=""col-md-12 mb10""> Ghi chú</div>
    <div class=""col-md-12 mb10"">
        <textarea class=""form-control"" id=""description"" maxlength=""3000"" style=""height: 100px;"" autocomplete=""off""></textarea>
        <div class=""validate-description""></div>
    </div>

</div>
<div class=""row m-0 p-0"">
    <div class=""bg-white border pd10 hidden"" id=""service-relate"" style=""display: none; width: 100% !important;"">
        <div class=""bold gray mb10"">Dịch vụ liên quan</div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table"" id=""service-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""min-width: 80px;"">Mã dịch vụ</th>
                        <th style=""min-width: 100px;"">Ngày bắt đầu - Ngày kết thúc</th>");
            WriteLiteral(@"
                        <th style=""min-width: 80px;"">Mã đơn hàng</th>
                        <th style=""min-width: 100px;"">Nhân viên điều hành</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Số tiền</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Đã giải trừ</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Chưa giải trừ</th>
                        <th class=""text-right"" style=""min-width: 100px;"">Cần giải trừ</th>
                    </tr>
                </thead>
                <tbody id=""body_service_list"">
                </tbody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
    <div class=""bg-white border pd10 hidden"" id=""order-relate"" style=""display: none; width: 100% !important;"">
        <div class=""bold gray mb10"">Đơn hàng liên quan</div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <tabl");
            WriteLiteral(@"e class=""table "" id=""order-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""min-width: 80px;"">Mã đơn hàng</th>
                        <th style=""min-width: 100px;"">Ngày bắt đầu - Ngày kết thúc</th>
                        <th style=""min-width: 100px;"">Nhân viên chính</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Số tiền</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Đã hoàn trả</th>
                        <th class=""text-right"" style=""min-width: 50px;"">Chưa hoàn trả</th>
                        <th class=""text-right"" style=""min-width: 100px;"">Có thể hoàn trả</th>
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

<div class=""text-center"" style=""margin-top: 20px; margi");
            WriteLiteral(@"n-bottom: 20px;"">
    <button type=""submit"" class=""btn btn-default btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Bỏ qua</button>
    <button type=""submit"" class=""btn btn-default btn-send-payment-request"" onclick=""_add_payment_request.AddRequest()"" style=""background: #5cb566 !important;"">Lưu nháp</button>
    <button type=""submit"" class=""btn btn-default btn-send-payment-request"" onclick=""_add_payment_request.AddRequest(1)"" style=""background: #5cb566 !important;"">Gửi đi</button>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0494a7f4361af257001e8a9d388a5ffb1771601a35201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $('.datepicker-payment').Zebra_DatePicker({
        format: 'd/m/Y H:i'
    }).removeAttr('readonly');
    _add_payment_request.Initialization();
    $().ready(function () {
        $('input').attr('autocomplete', 'off');
        setTimeout(function () {
            $('#service-relate').hide()
            $('#order-relate').hide()
        }, 800)
    })

</script>
<style scoped>

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
            padding: 0 5");
            WriteLiteral(@"px !important;
            outline: 0 !important;
            box-shadow: none !important;
            color: #000 !important;
            border-radius: 0.25rem !important;
        }

    .row-main-head .down-up .form-down {
        width: 345px !important;
    }

    .form-control {
        background: #fff;
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

    .Zebra_DatePicker_Icon_Wrapper {
        width: 100% !important
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