#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554e36edc6b3bcde5b1eee9bf5a3b6f8c7471940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VinWonderPolicy_Upsert), @"mvc.1.0.view", @"/Views/VinWonderPolicy/Upsert.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554e36edc6b3bcde5b1eee9bf5a3b6f8c7471940", @"/Views/VinWonderPolicy/Upsert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_VinWonderPolicy_Upsert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/vin_wonder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
  
    var common_profits = (List<AllCode>)ViewBag.CommonProfit;
    var profit_value = 0;
    if (common_profits != null && common_profits.Any())
    {
        var profit_model = common_profits.FirstOrDefault(s => s.CodeValue == 2);
        profit_value = profit_model != null ? int.Parse(profit_model.Description) : 0;
    }

    var str_date = string.Empty;
    if (Model != null && Model.Id > 0)
    {
        str_date = $"{Model.FromDate.ToString("dd/MM/yyyy HH:mm")} - {Model.ToDate.ToString("dd/MM/yyyy HH:mm")}";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"tab-default border-bottom\">\r\n");
#nullable restore
#line 24 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
     if (Model.Id > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <a href=\"#\" class=\"active\">Sửa chiến dịch</a>\r\n");
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"active\">Nhập thông tin</a>\r\n");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<p>Sau khi hoàn thành chỉnh sửa, vui lòng đăng tập tin Excel lên. Bạn có thể kiểm tra những sản phẩm mới tạo 1 lần nữa ở bên dưới </p>
<div class=""mb10"">
    <label class=""btn btn-success"" style=""margin-right:10px"">
        <input class=""mfp-hide"" type=""file"" id=""file_import_vinwonder"">
        Tải tập tin
    </label>
    <span style=""color:#ADB0B1"">Import file mẫu của Vinwonder. Định dạng: xlsx</span>
</div>
<div class=""red p-3 rounded mb20 mfp-hide"" id=""file_import_vinwonder_error_message"" style=""background: #F3DFDF;"">
    Lỗi xảy ra: File upload không đúng định dạng, Hệ thống không nhận biết được các cột
</div>

<div class=""flex"">
    <div class=""flex-form-group mb15"">
        <label class=""flex-text"">Hiệu lực</label>
        <div class=""flex-input"">
            <div class=""datepicker-wrap row row_min"">
                <div class=""col-12"">
                     <input type=""hidden"" id=""ip_campaign_id""");
            BeginWriteAttribute("value", " value=\"", 1812, "\"", 1829, 1);
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
WriteAttributeValue("", 1820, Model.Id, 1820, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    <input class=""form-control text-center datepicker-input dateranger_picker_input""
                           id=""ip_effect_time"" type=""text""
                           placeholder=""Khoảng thời gian hiệu lực""
                           style=""min-width:280px;""");
            BeginWriteAttribute("value", " value=\"", 2120, "\"", 2137, 1);
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
WriteAttributeValue("", 2128, str_date, 2128, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>
        </div>
    </div>
    <div class=""ml-5""></div>
    <div class=""flex-form-group mb15"">
        <label class=""flex-text"">Lợi nhuận chung</label>
        <div class=""flex-input"">
            <div class=""flex align-center"">
                <div class=""input-tag-price"" id=""vinwonder_common_profit"">
                    <input type=""text"" class=""form-control currency"" id=""ip_common_profit""");
            BeginWriteAttribute("value", " value=\"", 2588, "\"", 2624, 1);
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
WriteAttributeValue("", 2596, profit_value.ToString("N0"), 2596, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-type=\"2\" disabled style=\"width: 100px;\">\r\n");
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
                     if (common_profits != null && common_profits.Any())
                    {
                        foreach (var item in common_profits.OrderByDescending(s => s.OrderNo))
                        {
                            if (item.CodeValue == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"status-gray currency_type ml-2 cur-pointer\" data-type=\"1\" data-value=\"");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
                                                                                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">%</span>\r\n");
#nullable restore
#line 74 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"status-green currency_type cur-pointer\" data-type=\"2\" data-value=\"");
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
                                                                                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">VNĐ</span>\r\n");
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <button type=""button"" class=""btn btn-default agray ml-2"" id=""btn_edit_common_profit"" style=""padding: 0 10px;"">
                    <i class=""fa fa-edit mr-0""></i>
                </button>
                <button type=""button"" class=""btn btn-default ml-2 bg-main mfp-hide"" id=""btn_save_common_profit""
                        title=""Lưu lợi nhuận chung"" style=""padding: 0 10px;"">
                    <i class=""fa fa-floppy-o mr-0""></i>
                </button>
                <button type=""button"" class=""btn btn-default ml-2 cancel mfp-hide"" id=""btn_cancel_common_profit""
                        title=""Hủy"" style=""padding: 0 10px;"">
                    <i class=""fa fa-minus-circle mr-0""></i>
                </button>
            </div>
        </div>
    </div>
</div>
<div class=""flex-form-group mb15"">
    <label class=""flex-text"">Tên chiến dịch</label>
    <div class=""flex-input"">
        <input type=""text"" id=""ip_campaign_name""");
            BeginWriteAttribute("value", " value=\"", 4440, "\"", 4466, 1);
#nullable restore
#line 100 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
WriteAttributeValue("", 4448, Model.Description, 4448, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\" id=\"grid_vinwonder_price\">\r\n");
#nullable restore
#line 109 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\VinWonderPolicy\Upsert.cshtml"
         if (Model.PricePolycies != null && Model.PricePolycies.Any())
        {
            await Html.RenderPartialAsync("~/Views/VinWonderPolicy/GridPrice.cshtml", Model.PricePolycies);
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""form-default"">
    <div class=""form-group align-right mt20 block"">
        <button type=""button"" class=""btn btn-default bg-main"" id=""btn_save_vinwonder_campaign"" onclick=""_vin_wonder.UpsertCampaign()"">
            <i class=""fa fa-floppy-o""></i>Cập nhật
        </button>
        <button type=""button"" class=""btn btn-default cancel"" data-dismiss=""modal""><i class=""fa fa-minus-circle""></i>Đóng</button>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554e36edc6b3bcde5b1eee9bf5a3b6f8c747194013238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
