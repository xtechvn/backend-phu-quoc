#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399611bc4c8e7654d6b518fcf38fbab6a95604b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_SendEmailSupplier), @"mvc.1.0.view", @"/Views/SetService/SendEmailSupplier.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
using Entities.ViewModels.HotelBookingCode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
using Entities.ViewModels.HotelBooking;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399611bc4c8e7654d6b518fcf38fbab6a95604b6", @"/Views/SetService/SendEmailSupplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_SendEmailSupplier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SendEmailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Subject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Tên tiêu đề"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2 js-example-basic-multiple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "To_Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("multiple", new global::Microsoft.AspNetCore.Html.HtmlString("multiple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100% !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CC_Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BCC_Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-send-email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
  
    var order = (OrderDetailViewModel)ViewBag.Order;
    var User = (User)ViewBag.user;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n    .white-popup {\r\n        max-width: 800px !important;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399611bc4c8e7654d6b518fcf38fbab6a95604b69863", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 20 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
     if (order == null || order.SalerId == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p style=\"font-size:12px;\" class=\"red\">Thông tin phụ trách chính của đơn hàng chưa có vui lòng tiến hành bổ xung</p>");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                                                                                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        <label class=\"lbl\">Tiêu đề <sup class=\"red\">*</sup></label>\r\n        <div class=\"wrap_input\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "399611bc4c8e7654d6b518fcf38fbab6a95604b610961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 25 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Subject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"text\" class=\"form-control\" id=\"ServiceId\"");
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1136, 1);
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
WriteAttributeValue("", 1118, ViewBag.ServiceId, 1118, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">\r\n            <input type=\"text\" class=\"form-control\" id=\"Orderid\"");
                BeginWriteAttribute("value", " value=\"", 1225, "\"", 1249, 1);
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
WriteAttributeValue("", 1233, ViewBag.Orderid, 1233, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">\r\n            <input type=\"text\" class=\"form-control\" id=\"Type\"");
                BeginWriteAttribute("value", " value=\"", 1335, "\"", 1356, 1);
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
WriteAttributeValue("", 1343, ViewBag.type, 1343, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-group-booking=\"");
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                                                                                   Write(ViewBag.GroupBookingId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" style=\"display:none\">\r\n            <input type=\"text\" class=\"form-control\" id=\"ServiceType\"");
                BeginWriteAttribute("value", " value=\"", 1494, "\"", 1522, 1);
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
WriteAttributeValue("", 1502, ViewBag.ServiceType, 1502, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">\r\n        </div>\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
         if (ViewBag.type == 8)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <label class=""lbl"">Nhà cung cấp </label>
            <div class=""wrap_input"">
                <select class=""select2 js-example-basic-multiple"" id=""SupplierId"" name=""SupplierId"" multiple=""multiple"" onchange=""_SetService_Detail.TemplateSupplier()"" style=""width:100% !important"">
                </select>

                <label id=""To_Email-error"" class=""error"" for=""To_Email"" style=""display: none;""></label>
            </div>
            <label class=""lbl"">Email nhà cung cấp nhận</label>
            <div class=""wrap_input"">
                <input type=""text"" id=""Email""");
                BeginWriteAttribute("value", " value=\"", 2224, "\"", 2232, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"nguyenvanA@gmail.com\">\r\n            </div>\r\n");
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label class=\"lbl\">Nhân viên nhận <sup class=\"red\">*</sup></label>\r\n            <div class=\"wrap_input\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399611bc4c8e7654d6b518fcf38fbab6a95604b616871", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                     if (User != null)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399611bc4c8e7654d6b518fcf38fbab6a95604b617433", async() => {
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                                                   Write(User.FullName);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" - ");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                                                                    Write(User.Email);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                               WriteLiteral(User.Email);

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
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.To_Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <label id=\"To_Email-error\" class=\"error\" for=\"To_Email\" style=\"display: none;\"></label>\r\n            </div>\r\n");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <label class=\"lbl\">CC</label>\r\n        <div class=\"wrap_input\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399611bc4c8e7654d6b518fcf38fbab6a95604b622318", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CC_Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <label id=\"CC_Email-error\" class=\"error\" for=\"CC_Email\" style=\"display: none;\"></label>\r\n        </div>\r\n        <label class=\"lbl\">BCC</label>\r\n        <div class=\"wrap_input\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399611bc4c8e7654d6b518fcf38fbab6a95604b624571", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BCC_Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <label id=""BCC_Email-error"" class=""error"" for=""BCC_Email"" style=""display: none;""></label>
        </div>
    </div>
    <div class=""attachment-email border pd10"">
        <img src=""/images/icons/loading.gif"" style=""width: 55px;height: 55px;margin-left: 10px;margin-bottom: 10px;"" class=""img_loading_summit coll"">
    </div>
    <div class=""data-supplier"">

    </div>

    <div class=""line-bottom""></div>
    <div class=""text-right"">
        <button type=""submit"" class=""btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Đóng</button>
");
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
         if (ViewBag.ServiceType != 0 && order != null && order.SalerId != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" id=\"SendEmailDv\" class=\"btn btn-default\" onclick=\"_SetService_Detail.SendEmail()\">Gửi</button>\r\n");
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 91 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
         if (ViewBag.ServiceType == 0 && order.SalerId != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" id=\"SendEmailDv\" class=\"btn btn-default\" onclick=\"_SetService_Detail.SendEmail()\">Gửi</button>");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\SendEmailSupplier.cshtml"
                                                                                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    _SetService_Sendemail.loadformSenmail();\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SendEmailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
