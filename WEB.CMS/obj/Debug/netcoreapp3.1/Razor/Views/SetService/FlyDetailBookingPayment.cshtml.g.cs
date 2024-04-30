#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c3140a529b638bb3838efc584835ae8d14199e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_FlyDetailBookingPayment), @"mvc.1.0.view", @"/Views/SetService/FlyDetailBookingPayment.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
using Utilities.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c3140a529b638bb3838efc584835ae8d14199e", @"/Views/SetService/FlyDetailBookingPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_FlyDetailBookingPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PaymentRequestViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/zebra_datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/payment_request.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
  
    var counter = 1;
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mb15 bold txt_18\">\r\n    Danh sách yêu cầu chi\r\n");
            WriteLiteral(@"    <button type=""button"" class="" green txt_18 ml-1 border-0"" onclick=""_set_service_fly_detail.AddNewPayment()"" style=""color: #5cb566 !important"">
        <i class=""fa fa-plus-circle""></i>
    </button>
</div>
<div class=""wrap_bg wrap_bg_no-padding mb20"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th>STT</th>
                    <th>Mã phiếu</th>
                    <th>Ngày tạo</th>
                    <th>Nội dung</th>
                    <th class=""text-right"">Số tiền</th>
                    <th>Trạng thái</th>
                    <th>Thao tác</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                 if (Model.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1378, 2);
            WriteAttributeValue("", 1330, "/PaymentRequest/Detail?paymentRequestId=", 1330, 40, true);
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
WriteAttributeValue("", 1370, item.Id, 1370, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                               Write(item.PaymentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                           Write(item.CreatedDate.Value.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                 if (!string.IsNullOrEmpty(item.Note) && item.Note.Length > 100)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("title", " title=\"", 1808, "\"", 1826, 1);
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
WriteAttributeValue("", 1816, item.Note, 1816, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                                       Write(item.Note.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</div>\r\n");
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                               Write(item.Note);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                              
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td class=\"text-right\">");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                              Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                 if (item.Status == (int)(PAYMENT_REQUEST_STATUS.CHO_KTT_DUYET) ||
                             item.Status == (int)(PAYMENT_REQUEST_STATUS.CHO_TBP_DUYET))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status-wait\">");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                                         Write(item.PaymentRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                 if (item.Status == (int)(PAYMENT_REQUEST_STATUS.CHO_CHI) || item.Status == (int)(PAYMENT_REQUEST_STATUS.DA_CHI))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status-approve\">");
#nullable restore
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                                            Write(item.PaymentRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                 if (item.Status == (int)(PAYMENT_REQUEST_STATUS.TU_CHOI))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status-reject\">");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                                           Write(item.PaymentRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                 if (item.Status == (int)(PAYMENT_REQUEST_STATUS.LUU_NHAP))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status-draft\">");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                                          Write(item.PaymentRequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a class=\"fa fa-print txt_14\" href=\"#\"></a>\r\n");
            WriteLiteral("                                <button type=\"button\" class=\" ml-1 border-0\" style=\" background: none;\"");
            BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 3743, "\"", 3833, 3);
            WriteAttributeValue("", 3794, "_payment_request_service.Edit(", 3794, 30, true);
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
WriteAttributeValue("", 3824, item.Id, 3824, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3832, ")", 3832, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa fa-pencil txt_14 ml-1\"></i>\r\n                                </button>\r\n                                <button type=\"button\" class=\" ml-1 green border-0\" style=\" background: none;\"");
            BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 4067, "\"", 4170, 3);
            WriteAttributeValue("", 4118, "_payment_request_service.Delete(\'", 4118, 33, true);
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
WriteAttributeValue("", 4151, item.PaymentCode, 4151, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4168, "\')", 4168, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fa fa-trash-o txt_14 ml-1\"></i>\r\n                                </button>\r\n");
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 86 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                        counter++;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td colspan=\"7\">Không tìm thấy phiếu yêu cầu chi nào</td>\r\n                    </tr>\r\n");
#nullable restore
#line 94 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailBookingPayment.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>
        </table>
    </div>
</div>

<style scoped>
    .status-wait {
        background: #EEB442 !important;
        min-width: 130px;
        padding: 3px 15px;
        border-radius: 15px;
        color: #fff;
    }

    .status-approve {
        background: #5CB566 !important;
        min-width: 130px;
        padding: 3px 15px;
        border-radius: 15px;
        color: #fff;
    }

    .status-draft {
        background: #C9C9C9 !important;
        min-width: 130px;
        padding: 3px 15px;
        border-radius: 15px;
        color: #fff;
    }

    .status-reject {
        background: #FF0000 !important;
        min-width: 130px;
        padding: 3px 15px;
        border-radius: 15px;
        color: #fff;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2c3140a529b638bb3838efc584835ae8d14199e17738", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2c3140a529b638bb3838efc584835ae8d14199e18861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PaymentRequestViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
