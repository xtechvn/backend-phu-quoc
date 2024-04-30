#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2fbe5d9b20fb76b96209797d4723376d2780631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Note_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Note/Default.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fbe5d9b20fb76b96209797d4723376d2780631", @"/Views/Shared/Components/Note/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Note_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoteViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/note_component.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
  
    var ManageUser = (int)ViewBag.UserId;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""mb15 italic medium"">
    Ghi chú đơn hàng
    <div class=""gray txt_12"">
        Lưu ý : Thời gian hiệu lực để xóa bình luận là 24 giờ kể từ lần cập nhật cuối cùng
    </div>
</div>
<ul class=""list-note scrollbar-inner"" id=""grid-comment-data"">
");
#nullable restore
#line 13 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
     if (Model != null && Model.Count > 0)
    {
        foreach (var item in Model.OrderByDescending(s => s.UpdateTime))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div><strong class=\"note-comment\" data-id=\"");
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                                                                Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n                <div class=\"txt_12\">");
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                                Write(item.UpdateTime != null ? item.UpdateTime.Value.ToString("dd/MM/yyyy HH:mm") : "N/A");

#line default
#line hidden
#nullable disable
            WriteLiteral(" by <strong>");
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                                                                                                                                  Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n");
#nullable restore
#line 20 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                 if (item.UserId == ManageUser &&
                 (DateTime.Now - (item.UpdateTime == null ? item.CreateDate.Value : item.UpdateTime.Value)).TotalHours <= 24)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"option\">\r\n                        <a class=\"delete blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1072, "\"", 1113, 3);
            WriteAttributeValue("", 1082, "_note.OnEditComment(\'", 1082, 21, true);
#nullable restore
#line 24 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
WriteAttributeValue("", 1103, item.Id, 1103, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1111, "\')", 1111, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a>\r\n                        &nbsp;&nbsp;\r\n                        <a class=\"delete red\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1232, "\"", 1273, 3);
            WriteAttributeValue("", 1242, "_note.DeleteComment(\'", 1242, 21, true);
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
WriteAttributeValue("", 1263, item.Id, 1263, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1271, "\')", 1271, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></a>\r\n                    </div>\r\n");
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<div class=\"form-group mt20\">\r\n    <input type=\"hidden\" id=\"ip-note-id\" value=\"0\" />\r\n    <input type=\"hidden\" id=\"ip-note-data-id\"");
            BeginWriteAttribute("value", " value=\"", 1530, "\"", 1553, 1);
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
WriteAttributeValue("", 1538, ViewBag.DataId, 1538, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"ip-note-type\"");
            BeginWriteAttribute("value", " value=\"", 1601, "\"", 1622, 1);
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Shared\Components\Note\Default.cshtml"
WriteAttributeValue("", 1609, ViewBag.Type, 1609, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <textarea type=""text"" id=""ip-note-comment"" class=""form-control"" placeholder=""Nhập nội dung ghi chú ...""></textarea>
</div>
<div class=""text-right"">
    <button type=""button"" class=""btn btn-default cancel mfp-hide"" id=""btn-reset-comment"" onclick=""_note.ResetComment();""><i class=""fa fa-minus-circle""></i> Hủy</button>
    <button type=""button"" class=""btn btn-default"" onclick=""_note.SendComment()""><i class=""fa fa-paper-plane-o""></i> Gửi</button>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2fbe5d9b20fb76b96209797d4723376d27806319598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
