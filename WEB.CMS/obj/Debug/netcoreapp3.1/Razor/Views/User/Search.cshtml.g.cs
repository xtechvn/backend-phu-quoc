#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbacff3ea47c3536a7d3e7ef99a99533af878da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Search), @"mvc.1.0.view", @"/Views/User/Search.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbacff3ea47c3536a7d3e7ef99a99533af878da1", @"/Views/User/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<UserGridModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-nowrap"">
    <thead>
        <tr class=""bg-main2"">
            <th>STT</th>
            <th>Tên đăng nhập</th>
            <th width=""20%"">Họ tên</th>
            <th>Điện thoại</th>
            <th>Ngày sinh</th>
            <th>Email</th>
            <th>Vai trò</th>
            <th>Phòng ban</th>
            <th>Chức vụ</th>
            <th class=""mfp-hide"">Địa chỉ</th>
            <th class=""mfp-hide"">Trạng thái</th>
            <th class=""mfp-hide"">Ngày tạo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
          
            int counter = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
         foreach (var item in Model.ListData)
        {
            counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 822, "\"", 886, 1);
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
WriteAttributeValue("", 830, (counter % 2 == 0)? "line-item bg-gray" : "line-item", 830, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-ajaxdetail=\"false\">\r\n            <td>");
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
            Write((Model.CurrentPage-1) * Model.PageSize + counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"name_img\">\r\n                <div class=\"flex align-center\">\r\n                    <div class=\"ava\">\r\n                        <span class=\"thumb_img thumb_5x5\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1259, "\"", 1295, 1);
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
WriteAttributeValue("", 1265, item.Avata ?? string.Empty , 1265, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onerror=\"_imageError(this)\" />\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        ");
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </td>\r\n            <td>");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
            Write(item.BirthDay == null ? "N/A" : ((DateTime)item.BirthDay).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
           Write(string.Join(", ", item.RoleList.Select(s => s.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
            Write(item.UserDepartment==null || item.UserDepartment.DepartmentName==null?"": item.UserDepartment.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
            Write(item.UserPosition==null || item.UserPosition.Name==null?"": item.UserPosition.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"mfp-hide\">");
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
                            Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"mfp-hide\">");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
                             Write(item.Status == 1 ? "Tạm ngừng":"Đang hoạt động");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"mfp-hide\">");
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
                             Write(item.CreatedOn == null ? "N/A" : ((DateTime)item.CreatedOn).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\User\Search.cshtml"
Write(await Component.InvokeAsync("Paging", new
{
    pageModel = new Paging()
    {
        TotalRecord = Model.TotalRecord,
        TotalPage = Model.TotalPage,
        CurrentPage = Model.CurrentPage,
        PageSize = Model.PageSize,
        RecordName = "người dùng",
        PageAction = "_user.OnPaging({0})"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<UserGridModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
