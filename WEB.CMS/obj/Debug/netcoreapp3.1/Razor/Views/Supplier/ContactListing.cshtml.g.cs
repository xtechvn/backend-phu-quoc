#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f2fd13eccdc4239a451cba1fbf47a51626e200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_ContactListing), @"mvc.1.0.view", @"/Views/Supplier/ContactListing.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
using Entities.ViewModels.SupplierConfig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f2fd13eccdc4239a451cba1fbf47a51626e200", @"/Views/Supplier/ContactListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_ContactListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<SupplierContactViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive table-default table-gray"">
    <table class=""table table-nowrap"">
        <thead>
            <tr>
                <th style=""min-width: 30px;"">STT</th>
                <th>Họ tên</th>
                <th>Điện thoại</th>
                <th>Email</th>
                <th>Chức vụ</th>
                <th>Người tạo</th>
                <th>Ngày tạo</th>
                <th style=""min-width: 100px;"">Tác vụ</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
             if (Model.ListData != null && Model.ListData.Count > 0)
            {
                var counter = (Model.CurrentPage - 1) * Model.PageSize;
                foreach (var item in Model.ListData)
                {
                    counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.UserCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                       Write(item.CreateDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\" class=\"blue\" title=\"Chỉnh sửa\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 1603, "\"", 1680, 3);
            WriteAttributeValue("", 1637, "_supplier_contact.OnAddOrUpdate(\'", 1637, 33, true);
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
WriteAttributeValue("", 1670, item.Id, 1670, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1678, "\')", 1678, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-edit\"></i>\r\n                            </a> &nbsp;&nbsp;\r\n                            <a href=\"#\" class=\"red\" title=\"Xóa\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 1855, "\"", 1925, 3);
            WriteAttributeValue("", 1889, "_supplier_contact.Delete(\'", 1889, 26, true);
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
WriteAttributeValue("", 1915, item.Id, 1915, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1923, "\')", 1923, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-times\"></i>\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr>
                    <td colspan=""13"" class=""text-center"">
                        <div class=""search-null center mt40 mb40"">
                            <div class=""mb24"">
                                <img src=""/images/graphics/icon-search.png""");
            BeginWriteAttribute("alt", " alt=\"", 2421, "\"", 2427, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <h2 class=""title txt_24"">Không tìm thấy kết quả</h2>
                            <div class=""gray"">Chúng tôi không tìm thấy thông tin mà bạn cần, vui lòng thử lại</div>
                        </div>
                    </td>
                </tr>
");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ContactListing.cshtml"
Write(await Component.InvokeAsync("Paging", new
{
    pageModel = new Paging()
    {
        TotalRecord = Model.TotalRecord,
        TotalPage = Model.TotalPage,
        CurrentPage = Model.CurrentPage,
        PageSize = Model.PageSize,
        RecordName = "kết quả lọc",
        PageAction = "_supplier_detail.PagingRoom({0})"
    }
}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<SupplierContactViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591