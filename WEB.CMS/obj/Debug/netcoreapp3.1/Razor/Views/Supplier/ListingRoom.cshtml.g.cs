#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2b09f66aa41b1772a253c4f8788ed78d62d076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_ListingRoom), @"mvc.1.0.view", @"/Views/Supplier/ListingRoom.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
using Entities.ViewModels.Funding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
using Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2b09f66aa41b1772a253c4f8788ed78d62d076", @"/Views/Supplier/ListingRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_ListingRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<SupplierRoomGridModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
  
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
                <th>ID</th>
                <th style=""min-width: 250px;"">Hạng phòng</th>
                <th>Loại giường</th>
                <th>Số lượng</th>
                <th>Trạng thái</th>
                <th style=""min-width: 100px;"">Tác vụ</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
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
#line 30 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <div class=\"blue txt_14\">");
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                                                Write(item.TypeOfRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <small>Diện tích: (");
#nullable restore
#line 34 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                                          Write(item.RoomArea);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²)</small>\r\n                            <small>Số khách tối đa: ");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                                               Write(item.NumberOfAdult);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (NL) - ");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                                                                          Write(item.NumberOfChild);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (TE)</small>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                       Write(item.BedRoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                       Write(item.NumberOfRoom.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
                        Write(item.IsActive == 1 ? "Kích hoạt":"Tạm ngừng");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\" class=\"blue\" title=\"Chỉnh sửa\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 1738, "\"", 1815, 3);
            WriteAttributeValue("", 1772, "_supplier_detail.ShowUpsertRoom(\'", 1772, 33, true);
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
WriteAttributeValue("", 1805, item.Id, 1805, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1813, "\')", 1813, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-edit\"></i>\r\n                            </a> &nbsp;&nbsp;\r\n                            <a href=\"#\" class=\"blue\" title=\"Copy\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 1991, "\"", 2066, 3);
            WriteAttributeValue("", 2025, "_supplier_detail.ShowCopyRoom(\'", 2025, 31, true);
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
WriteAttributeValue("", 2056, item.Id, 2056, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2064, "\')", 2064, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-copy\"></i>\r\n                            </a> &nbsp;&nbsp;\r\n                            <a href=\"#\" class=\"red\" title=\"Xóa\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 2241, "\"", 2314, 3);
            WriteAttributeValue("", 2275, "_supplier_detail.DeleteRoom(\'", 2275, 29, true);
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
WriteAttributeValue("", 2304, item.Id, 2304, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2312, "\')", 2312, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-times\"></i>\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
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
            BeginWriteAttribute("alt", " alt=\"", 2810, "\"", 2816, 0);
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
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ListingRoom.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<SupplierRoomGridModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
