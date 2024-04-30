#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e7e55ae15b8275d307058d162cf15766dcc6da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Search), @"mvc.1.0.view", @"/Views/Supplier/Search.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
using Entities.ViewModels.Funding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e7e55ae15b8275d307058d162cf15766dcc6da", @"/Views/Supplier/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<SupplierViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
  
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
                <th>Mã</th>
                <th style=""min-width: 250px;"">Tên NCC</th>
                <th>Liên hệ</th>
                <th>Địa chỉ</th>
                <th style=""width: 250px;"">Dịch vụ</th>
                <th>Người tạo</th>
                <th>Ngày tạo</th>
                <th>Người cập nhật</th>
                <th>Ngày cập nhật</th>
                <th style=""min-width: 100px;"">Tác vụ</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
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
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                       Write(item.SupplierId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1306, 2);
            WriteAttributeValue("", 1273, "/supplier/detail/", 1273, 17, true);
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
WriteAttributeValue("", 1290, item.SupplierId, 1290, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"blue txt_14\">\r\n                                ");
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                             if (!string.IsNullOrEmpty(item.Phone))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>SĐT: ");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                             if (!string.IsNullOrEmpty(item.Email))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>Email: ");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>N/A</td>\r\n                        <td>");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                       Write(item.CreatedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                        Write(item.CreatedDate.HasValue && item.CreatedDate != DateTime.MinValue ? item.CreatedDate.Value.ToString("dd-MM-yyyy HH:mm") : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                       Write(item.UpdatedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
                        Write(item.UpdatedDate.HasValue && item.UpdatedDate != DateTime.MinValue ? item.UpdatedDate.Value.ToString("dd-MM-yyyy HH:mm") : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"delete blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2612, "\"", 2675, 3);
            WriteAttributeValue("", 2622, "_supplier_service.ShowAddOrUpdate(\'", 2622, 35, true);
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
WriteAttributeValue("", 2657, item.SupplierId, 2657, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2673, "\')", 2673, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></a> &nbsp;&nbsp;\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
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
            BeginWriteAttribute("alt", " alt=\"", 3200, "\"", 3206, 0);
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
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\Search.cshtml"
Write(await Component.InvokeAsync("Paging", new
{
    pageModel = new Paging()
    {
        TotalRecord = Model.TotalRecord,
        TotalPage = Model.TotalPage,
        CurrentPage = Model.CurrentPage,
        PageSize = Model.PageSize,
        RecordName = "kết quả lọc",
        PageAction = "_supplier_service.OnPaging({0})"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<SupplierViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
