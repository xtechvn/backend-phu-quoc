#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74c88e51e8b59935abfb22c97e0a2d10ee87d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_RelationSearch), @"mvc.1.0.view", @"/Views/News/RelationSearch.cshtml")]
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
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74c88e51e8b59935abfb22c97e0a2d10ee87d97", @"/Views/News/RelationSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_News_RelationSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<ArticleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table table-gird"" style=""border: 1px solid #dee2e6;"">
    <thead>
        <tr class=""bg-main2"">
            <th class=""center"">#</th>
            <th class=""center"">STT</th>
            <th>Tiêu đề</th>
            <th>Thời gian đăng</th>
            <th>Tác giả</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
         if (Model.ListData != null && Model.ListData.Count > 0)
        {
            var counter = (Model.CurrentPage - 1) * Model.PageSize;
            foreach (var item in Model.ListData)
            {
                counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"center\">\r\n                        <label class=\"check-list mb10\">\r\n                            <input type=\"checkbox\" class=\"ckb-select-relation\"");
            BeginWriteAttribute("value", " value=\"", 913, "\"", 929, 1);
#nullable restore
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
WriteAttributeValue("", 921, item.Id, 921, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"checkmark\"></span>\r\n                        </label>\r\n                        <input type=\"hidden\" class=\"article-image\"");
            BeginWriteAttribute("value", " value=\"", 1094, "\"", 1152, 1);
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
WriteAttributeValue("", 1102, (item.Image11 ?? item.Image43) ?? item.Image169, 1102, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td class=\"center\">");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
                                  Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"article-title\">");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <a class=\"italic blue\">");
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
                                          Write(item.ArticleCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
                    Write(item.PublishDate != DateTime.MinValue ? item.PublishDate.Value.ToString("dd/MM/yyyy HH:mm") : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><span class=\"article-author\">");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
                                                Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"5\"><span class=\"error\">Không tìm thấy dữ liệu</span></td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\News\RelationSearch.cshtml"
Write(await Component.InvokeAsync("Paging", new
{
    pageModel = new Paging()
    {
        TotalRecord = Model.TotalRecord,
        TotalPage = Model.TotalPage,
        CurrentPage = Model.CurrentPage,
        PageSize = Model.PageSize,
        RecordName = "bài viết",
        PageAction = "_newsRelation.OnPaging({0})"
    }
}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<ArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591