#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb31fa904ae6fc3795ba9a384fe2cda78c616add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receipt_AddNew), @"mvc.1.0.view", @"/Views/Receipt/AddNew.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb31fa904ae6fc3795ba9a384fe2cda78c616add", @"/Views/Receipt/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipt_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/add_contract_pay_new.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
  
    var allCode_PAY_TYPE = (List<AllCode>)ViewBag.allCode_PAY_TYPE;
    var allCode_CONTRACT_PAY_TYPE = (List<AllCode>)ViewBag.allCode_CONTRACT_PAY_TYPE;
    var listBankingAccount = (List<BankingAccount>)ViewBag.listBankingAccount;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .white-popup {
        max-width: 1300px !important;
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


<div class=""grid grid__2 grid-don-hang gap10 mb20"">
    <div class=""grid-item border"">

        <div class=""col-md-6 mb10""><label class=""lbl mt5 mb0"">Loại nghiệp vụ <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""contract-type""
                    onchange=""_contract_pay_create_new.OnChooseContractPayType()"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add6726", async() => {
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
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                 foreach (var item in allCode_CONTRACT_PAY_TYPE)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add8794", async() => {
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""col-md-12 mb10""><label class=""lbl mt5 mb0"">Tên đối tượng <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 m-0 p-0 row"">
            <div class=""col-md-2"">
                <select class=""select2"" style=""width: 60px; height: 34px ;"" id=""partner_choose_type"" onchange=""_contract_pay_create_new.OnChoosePartnerType()"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add11226", async() => {
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add12715", async() => {
                WriteLiteral("KH");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add13891", async() => {
                WriteLiteral("NCC");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add15068", async() => {
                WriteLiteral("NV");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
            </div>
            <div class=""col-md-10 mb10"" id=""divCustomer"">
                <select class=""select2 client-select"" id=""client-select"" style=""width:100% !important"" multiple=""multiple""
                        onchange=""_contract_pay_create_new.GetDataByClientId()"">
                </select>
            </div>
            <div class=""col-md-10 mb10"" id=""divSupplier"">
                <select class=""select2 supplier-select"" id=""supplier-select"" style=""width:100% !important"" multiple=""multiple""
                        onchange=""_contract_pay_create_new.GetDataBySupplierId()"">
                </select>
            </div>
            <div class=""col-md-10 mb10"" id=""divEmployee"">
                <select class=""select2 main-staff-select"" id=""createdBy"" multiple=""multiple"" style=""width:100% !important""
                        onchange=""_contract_pay_create_new.GetListBankAccountAdavigo()"">
                </select>
            </div>
        </div>

       ");
            WriteLiteral(@" <div class=""col-md-6 mb10"">
            <label class=""lbl mt5 mb0"" id=""lblBankAccountRequired"">Tài khoản ngân hàng nhận <sup class=""red"">*</sup></label>
            <label class=""lbl mt5 mb0"" id=""lblBankAccount"">Tài khoản ngân hàng nhận</label>
        </div>
        <div class=""col-md-12 mb10"">
            <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""bankingAccount"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add17757", async() => {
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
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                 foreach (var item in listBankingAccount)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add19819", async() => {
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                                        Write(item.BankId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>

        <div class=""col-md-6 mb10""> Ghi chú</div>
        <div class=""col-md-12 mb10"">
            <textarea class=""form-control"" id=""description"" maxlength=""3000"" style=""height: 100px;"" autocomplete=""off""></textarea>
        </div>
    </div>
    <div class=""grid-item border"">

        <div class=""col-md-6 mb10""> <label class=""lbl mt5 mb0""> Hình thức <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""contract-pay-type""
                    onchange=""_contract_pay_create_new.OnChoosePaymentType()"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add22780", async() => {
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
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                 foreach (var item in allCode_PAY_TYPE)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add24840", async() => {
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
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
#line 94 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Receipt\AddNew.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>

        <div class=""col-md-6 mb10""><label class=""lbl mt5 mb0""> Số tiền <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <input type=""text"" class=""form-control"" id=""amount"" onkeyup=""_contract_pay_create_new.FormatNumber();"" autocomplete=""off"">
        </div>

        <div class=""col-md-6 mb10""> <label class=""lbl mt5 mb0""> Nội dung <sup class=""red"">*</sup></label></div>
        <div class=""col-md-12 mb10"">
            <input type=""text"" id=""content"" maxlength=""500"" name=""name"" placeholder=""Nhập text(tối đa 500 kí tự)"" autocomplete=""off"" />
        </div>

        <div class=""col-md-6 mb10""> Ảnh đính kèm</div>
        <div class=""col-md-12 mb10"">
            <input type=""file"" id=""imagefile"" name=""imagefile"" onchange=""_contract_pay_create_new.OnChangeImage()"">

        </div>

    </div>
</div>
<div class=""row m-0 p-0"">
    <div class=""bg-white border pd10 hidden"" id=""order-relate"" style=""display: none; width: 100%");
            WriteLiteral(@" !important;"">
        <div class=""bold gray mb10"">Đơn hàng liên quan</div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""bold mb10"">Mã đơn hàng</div>
                <div class=""w-100 mb15"" style="" padding-right: 10px !important;"">
                    <input type=""text"" name=""name"" id=""orderCodeInput"" onkeyup=""_contract_pay_create_new.GetOrderDetail()""
                           placeholder=""Nhập mã đơn hàng để tìm kiếm nhanh"" />
                </div>
            </div>
            <div class=""col-md-6 "" style=""display:none"">
                <div class=""bold mb10"">Ngày tạo</div>
                <div class=""wrap_input"">
                    <div class=""datepicker-wrap"" style=""width:100%"">
                        <input class=""form-control date text-left filter_date_daterangepicker"" id=""filter_date_create_daterangepicker"" type=""text""
                               name=""datetimeCreateFilter"" style=""        min-width: 200px !important"" placeholder=""Ngày ");
            WriteLiteral(@"tạo"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table "" id=""order-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Mã đơn</th>
                        <th style=""min-width: 100px;"">Ngày bắt đầu-Ngày kết thúc</th>
                        <th>Trạng thái</th>
                        <th");
            BeginWriteAttribute("class", " class=\"", 7040, "\"", 7048, 0);
            EndWriteAttribute();
            WriteLiteral(">Nhân viên chính</th>\r\n                        <th");
            BeginWriteAttribute("class", " class=\"", 7099, "\"", 7107, 0);
            EndWriteAttribute();
            WriteLiteral(@">Ngày tạo</th>
                        <th class=""text-right"">Số tiền</th>
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
    <div class=""bg-white border pd10 hidden"" id=""deposit-relate"" style=""display: none; width: 100% !important;"">
        <div class=""bold gray mb10"">Nạp quỹ liên quan</div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table"" id=""deposit-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""min-width: 80px;"">Mã nạp quỹ</th>
                        <th>Loại quỹ");
            WriteLiteral(@"</th>
                        <th>Trạng thái</th>
                        <th style=""min-width: 130px;"">Người tạo</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Số tiền</th>
                    </tr>
                </thead>
                <tbody id=""body_deposit_history_list"">
                </tbody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
    <div class=""bg-white border pd10 hidden"" id=""supplier-refund-relate"" style=""display: none; width: 100% !important;"">
        <div class=""bold gray mb10"">Dịch vụ liên quan</div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""w-100 mb15"" style="" padding-right: 10px !important;"">
                    <select class=""select2 "" id=""serviceCodeFilter""
                            onchange=""_add_payment_voucher.OnCheckedRequest()"" multiple=""multiple"" style=""width: 100% !important""> </select>
                </div>
            <");
            WriteLiteral(@"/div>
        </div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table"" id=""supplier-refund-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""min-width: 80px;"">Mã dịch vụ</th>
                        <th>Ngày bắt đầu - Ngày kết thúc</th>
                        <th>Mã đơn hàng</th>
                        <th style=""min-width: 130px;"">Nhân viên điều hành</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Số tiền</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Đã hoàn trả</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Có thể hoàn trả</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Cần hoàn trả</th>
                    </tr>
                </thead>
                <tbody id=""body_supplier_refund_list"">
                </tb");
            WriteLiteral(@"ody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
    <div class=""bg-white border pd10 hidden"" id=""supplier-commision-relate"" style=""display: none; width: 100% !important;"">
        <div class=""bold gray mb10"">Dịch vụ liên quan</div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""w-100 mb15"" style="" padding-right: 10px !important;"">
                    <select class=""select2 "" id=""serviceCodeCommissionFilter""
                            onchange=""_add_payment_voucher.OnCheckedRequest()"" multiple=""multiple"" style=""width: 100% !important""> </select>
                </div>
            </div>
        </div>
        <div class=""table-responsive table-default table-gray table-modal scroll-inner"">
            <table class=""table"" id=""supplier-commision-relate-table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""min-width: 80px;");
            WriteLiteral(@""">Mã dịch vụ</th>
                        <th>Ngày bắt đầu - Ngày kết thúc</th>
                        <th>Mã đơn hàng</th>
                        <th style=""min-width: 130px;"">Nhân viên điều hành</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Số tiền</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Đã trả hoa hồng</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Có thể trả hoa hồng</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Cần trả hoa hồng</th>
                    </tr>
                </thead>
                <tbody id=""body_supplier_commision_list"">
                </tbody>
            </table>
        </div>
        <div class=""flex flex-end"">
        </div>
    </div>
</div>

<div class=""text-center"" style=""margin-top: 20px; margin-bottom: 20px;"">
    <button type=""submit"" class=""btn btn-default btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Bỏ qua");
            WriteLiteral("</button>\r\n    <button type=\"submit\" class=\"btn btn-default\" onclick=\"_contract_pay_create_new.AddNewContractPay()\">Thêm</button>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb31fa904ae6fc3795ba9a384fe2cda78c616add35528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    _contract_pay_create_new.Initialization();\r\n</script>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $().ready(function () {
            $('input').attr('autocomplete', 'off');
            setTimeout(function () {
                $('#order-relate').hide()
                $('#deposit-relate').hide()
                $('#supplier-refund-relate').hide()
                $('#supplier-commision-relate').hide()
            }, 1000)
        })
    </script>
");
            }
            );
            WriteLiteral(@"<style scoped>

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
        background: #fff;
        width: 100%;
        font-size: 13px;
        height: 30px;
");
            WriteLiteral(@"        line-height: 30px;
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