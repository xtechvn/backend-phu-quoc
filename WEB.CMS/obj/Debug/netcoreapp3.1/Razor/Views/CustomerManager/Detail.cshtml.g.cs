#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d9e7a8a85aa474c119bf6738219a76f67883b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerManager_Detail), @"mvc.1.0.view", @"/Views/CustomerManager/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d9e7a8a85aa474c119bf6738219a76f67883b2", @"/Views/CustomerManager/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerManager_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\Detail.cshtml"
   ViewData["Title"] = "Chi tiết khách hàng"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"main-container\">\r\n    <div class=\"row-main container\">\r\n");
            WriteLiteral("        <h2 class=\"txt_16 bold mb15\">Thông tin cơ bản khách hàng</h2>\r\n        <input id=\"id_userid\" style=\"display:none\"");
            BeginWriteAttribute("value", " value=\"", 276, "\"", 295, 1);
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\Detail.cshtml"
WriteAttributeValue("", 284, ViewBag.id, 284, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></input>
        <div id=""grid_detail_Customer_Manager"">
            <img src=""/images/icons/loading.gif"" style="" width: 100px; height: 100px; margin-left:46%;"" id=""imgLoading_Customer_Manager"" />
        </div>


        <div class=""white-popup"" style=""max-width: 400px; display:none"">
            <div class=""content_lightbox"">
                <div class=""head line-bottom"">
                    Chi tiết công nợ khách hàng DL100001
                </div>
                <div class=""row"">
                    <div class=""col-6 mb10"">Công nợ VMB</div>
                    <div class=""col-6 mb10"">: 30,000,000 vnđ</div>
                    <div class=""col-6 mb10"">Công nợ KS</div>
                    <div class=""col-6 mb10"">: 0/0</div>
                    <div class=""col-6 mb10"">Thời gian thu hồi công nợ</div>
                    <div class=""col-6 mb10"">: 15/02/2023</div>
                    <div class=""col-6 mb10"">Nhân viên phụ trách</div>
                    <div class=""col-6 mb10"">: Nguyễn Thanh");
            WriteLiteral(@" Bình - Kinh doanh 1</div>
                </div>
            </div>
            <button title=""Close (Esc)"" type=""button"" class=""mfp-close"">×</button>
        </div>
        <div class=""tab-default"" style=""border-bottom: 1px solid #CCCCCC;"">
            <div class=""row"" style="" width: 100%; "">
                <div class=""tab-default col-md-9 mb0 mt10"">
                    <a href=""javascript:;"" onclick=""_customer_manager_Detail.OnStatuse(1);_customer_manager_Detail.SetActive(1)"" id=""data_order"" class=""active"">Lịch sử mua hàng</a>
                    <a href=""javascript:;"" onclick=""_customer_manager_Detail.OnStatuse(3);_customer_manager_Detail.SetActive(3)"" id=""data_deposit_history"">Lịch sử ký quỹ</a>
                    <a href=""javascript:;"" onclick=""_customer_manager_Detail.OnStatuse(4);_customer_manager_Detail.SetActive(4)"" id=""data_Contract"">Lịch sử hợp đồng</a>
                    <a href=""javascript:;"" onclick=""_customer_manager_Detail.OnStatuse(2);_customer_manager_Detail.SetActive(2)"" id=""");
            WriteLiteral(@"data_payment_account"">Thông tin thanh toán</a>
                    <div id=""bt_data_payment_account"" style=""display:none"">
                        <button type=""button"" class=""btn btn-default bg-main mb10 mr-2"" onclick=""_customer_manager_Detail.OpenPopupPaymentAccount('')""><i class=""fa fa-plus-circle""></i>Thêm thông tin thanh toán</button>
                    </div>

                </div>

            </div>


        </div>
        <div>
");
            WriteLiteral("\r\n            <input id=\"id_userid\" style=\"display:none\"");
            BeginWriteAttribute("value", " value=\"", 2890, "\"", 2909, 1);
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\Detail.cshtml"
WriteAttributeValue("", 2898, ViewBag.id, 2898, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n            <div id=\"grid_data_order\">\r\n                <img src=\"/images/icons/loading.gif\" style=\" width: 100px; height: 100px; margin-left:46%;\" id=\"imgLoading_order\" />\r\n            </div>\r\n");
            WriteLiteral("\r\n            <div id=\"grid_data_payment_account\" style=\"display:none\">\r\n                <img src=\"/images/icons/loading.gif\" style=\" width: 100px; height: 100px; margin-left:46%;\" id=\"imgLoading_payment_account(\" />\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n            <div id=\"grid_data_deposit_history\" style=\"display:none\">\r\n                <img src=\"/images/icons/loading.gif\" style=\" width: 100px; height: 100px; margin-left:46%;\" id=\"imgLoading_deposit_history\" />\r\n            </div>\r\n\r\n\r\n");
            WriteLiteral(@"

            <div id=""grid_data_Contract"" style=""display:none"">
                <img src=""/images/icons/loading.gif"" style="" width: 100px; height: 100px; margin-left:46%;"" id=""imgLoading_Contract"" />
            </div>
        </div>

        <div class=""flex flex-end"">
            <b class=""btn btn-default cancel ml-1"" onclick=""history.back()"">Quay lại</b>
            <button type=""button"" class=""btn btn-default ml-1""");
            BeginWriteAttribute("onclick", " onclick=\"", 4134, "\"", 4186, 3);
            WriteAttributeValue("", 4144, "_customer_manager.OpenPopup(\'", 4144, 29, true);
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\CustomerManager\Detail.cshtml"
WriteAttributeValue("", 4173, ViewBag.id, 4173, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4184, "\')", 4184, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Sửa thông tin khách hàng</button>\r\n            <button type=\"button\" class=\"btn btn-default ml-1\" onclick=\"_customer_manager_Detail.OpenPopupUserAgent(\'\')\">Đổi nhân viên phụ trách</button>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"/modules/customer_manager_Detail.js\"></script>\r\n    <script type=\"text/javascript\" src=\"/modules/customer_manager.js\"></script>\r\n");
            }
            );
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
