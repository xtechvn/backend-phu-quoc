#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailChangeOperator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bd9b3a9e43a25a2f4581df90db8f55d10199bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_FlyDetailChangeOperator), @"mvc.1.0.view", @"/Views/SetService/FlyDetailChangeOperator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd9b3a9e43a25a2f4581df90db8f55d10199bbd", @"/Views/SetService/FlyDetailChangeOperator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_FlyDetailChangeOperator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailChangeOperator.cshtml"
  
    Layout=null;
    string current_operator_name = (string)ViewBag.Name;
    string group_booking_id = (string)ViewBag.GroupBookingId;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.stop-scrolling {
        height: 100%;
        overflow: hidden;
    }

    .client-suggestion {

        overflow-y: scroll;
        overflow-x: hidden;
        max-height: 300px;
        width:100%;
        cursor: pointer;
        min-height: 150px;
        z-index: 2;
    }
</style>
<div class=""modal fade"" id=""change_operator_popup"" style=""display: block;"" data-select2-id=""myModal0"" aria-modal=""true"" role=""dialog"">
    <div class=""modal-dialog"" style=""max-width: 35%; margin-top: 15%;"">
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Đổi điều hành viên</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""_set_service_fly_detail.PopupChangeOperatorClose()"">×</button>
            </div>
            <!-- Modal body -->
            <div class=""modal-body"">
                <div class=""form-operator-change"" data-group-booking=""");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailChangeOperator.cshtml"
                                                                 Write(group_booking_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <div class=""row"">
                        <div class=""col-md-4 mb10""><label class=""lbl mt5 mb0"">Nhân viên hiện tại </label></div>
                        <div class=""col-md-8 mb10"">
                            <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1450, "\"", 1480, 1);
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlyDetailChangeOperator.cshtml"
WriteAttributeValue("", 1458, current_operator_name, 1458, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                        </div>
                        <div class=""col-md-4 mb10""><label class=""lbl mt5 mb0"">Nhân viên mới </label><sup class=""red"">*</sup></div>
                        <div class=""col-md-8 mb10"" id=""change-operator-parent-div"">
                            <select class=""service-fly-change-operator"" style=""width:100% !important"">
                            </select>
                            <div id=""change-operator-dropdown-div"">

                            </div>
                        </div>

                    </div>
                    <div class=""text-right""style=""margin-top: 15px;"" >
                        <button onclick=""_set_service_fly_detail.PopupChangeOperatorClose()"" class=""btn btn-default btn btn-default cancel"">Bỏ qua</button>
                        <button onclick=""_set_service_fly_detail.ChangeServiceOperator();"" class=""btn btn-default"">Lưu</button>
                    </div>
                </div>
            </div>

        </div>
   ");
            WriteLiteral(" </div>\r\n</div>\r\n<script>\r\n    _set_service_fly_detail.PopupChangeOperatorInit();\r\n</script>\r\n\r\n");
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
