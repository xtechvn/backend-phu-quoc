#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f997edc9cd2c3c089948d7a69165c45bd8d8f695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_AddVinWonderServiceGuests), @"mvc.1.0.view", @"/Views/Order/AddVinWonderServiceGuests.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f997edc9cd2c3c089948d7a69165c45bd8d8f695", @"/Views/Order/AddVinWonderServiceGuests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_AddVinWonderServiceGuests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
  
    Layout = null;
    List<Entities.Models.VinWonderBookingTicketCustomer> list = (List<Entities.Models.VinWonderBookingTicketCustomer>)ViewBag.Guest;
    int index = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""form-group"">
    <input type=""file"" style=""display:none;"" class=""import_data_guest"">
    <button type=""button"" class=""btn upload size upload-file-guest-btn"" onclick=""$('.import_data_guest').trigger('click');"">
        <svg class=""icon-svg mr-1"" width=""17"" height=""16"" viewBox=""0 0 17 16"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
            <path d=""M16.9414 15.0002C16.9414 15.5525 16.4937 16.0002 15.9414 16.0002H1.94141C1.38912 16.0002 0.941406 15.5525 0.941406 15.0002C0.941406 14.448 1.38912 14.0002 1.94141 14.0002H15.9414C16.4937 14.0002 16.9414 14.4479 16.9414 15.0002ZM5.39838 5.5433C5.65428 5.5433 5.91022 5.44567 6.10547 5.25039L7.94141 3.41445V11.1253C7.94141 11.6775 8.38912 12.1253 8.94141 12.1253C9.49369 12.1253 9.94141 11.6775 9.94141 11.1253V3.41445L11.7773 5.25039C12.1679 5.64092 12.801 5.64092 13.1916 5.25039C13.5821 4.85986 13.5821 4.22671 13.1916 3.83617L9.6485 0.293143C9.25797 -0.0973887 8.62481 -0.0973887 8.23428 0.293143L4.69125 3.83617C4.30072 4.22671 4.30072 4.85986 4.6");
            WriteLiteral(@"9125 5.25039C4.88653 5.44567 5.14244 5.5433 5.39838 5.5433Z"" fill=""#1254FF"" />
        </svg>
        Upload danh sách khách nhanh (VinWonder)
    </button>
    <a type=""button"" class=""btn download size download_data_guest"" href=""/Template/import/template-danh-sach-doan-vinwonder.xlsx"" download>
        <svg class=""icon-svg mr-1"" width=""9"" height=""13"" viewBox=""0 0 9 13"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
            <path d=""M7.90141 8.64C7.58141 8.32 7.10141 8.32 6.78141 8.64L5.34141 10.08V0.8C5.34141 0.32 5.02141 0 4.54141 0C4.06141 0 3.74141 0.32 3.74141 0.8V10.08L2.30141 8.64C1.98141 8.32 1.50141 8.32 1.18141 8.64C0.861406 8.96 0.861406 9.44 1.18141 9.76L3.98141 12.56C4.14141 12.72 4.38141 12.8 4.54141 12.8C4.70141 12.8 4.94141 12.72 5.10141 12.56L7.90141 9.76C8.22141 9.44 8.22141 8.88 7.90141 8.64Z"" fill=""#1254FF"" />
        </svg>
        Tải mẫu danh sách khách nhanh (VinWonder)
    </a>
    <img src=""/images/icons/loading.gif"" style=""width: 55px;height: 55px;margin-left: 10px;ma");
            WriteLiteral(@"rgin-bottom: 10px; display:none;"" class=""img_loading_upload_file coll"">

</div>
<table class=""table table-nowrap"">
    <thead>
        <tr>
            <th>STT</th>
            <th style=""min-width: 200px;"">Họ và tên </th>
            <th style=""min-width: 150px;"">Email</th>
            <th style=""min-width: 150px;"">Số điện thoại</th>
            <th style=""min-width: 200px;"">Ghi chú</th>
            <th style=""width: 60px;""></th>
        </tr>
    </thead>
    <tbody class=""service-vinwonder-guest-tbody"">
");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
         if (list != null && list.Count > 0)
        {
            foreach (var item in list)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"service-vinwonder-guest-row\" data-extra-guest-id=\"");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <td class=\"service-vinwonder-guest-order\">");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
                                                          Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 3061, "\"", 3069, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <input type=\"text\" class=\"form-control service-vinwonder-guest-name\" style=\"width:100% !important\"");
            BeginWriteAttribute("value", " value=\"", 3195, "\"", 3217, 1);
#nullable restore
#line 43 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
WriteAttributeValue("", 3203, item.FullName, 3203, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"text\" class=\"form-control service-vinwonder-guest-email\" style=\"width:100% !important\"");
            BeginWriteAttribute("value", " value=\"", 3397, "\"", 3416, 1);
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
WriteAttributeValue("", 3405, item.Email, 3405, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </td>\r\n\r\n                    <td><input class=\"form-control service-vinwonder-guest-phone\" type=\"text\" name=\"service-vinwonder-guest-phone\"");
            BeginWriteAttribute("value", " value=\"", 3581, "\"", 3600, 1);
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
WriteAttributeValue("", 3589, item.Phone, 3589, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    <td><input type=\"text\" class=\"form-control service-vinwonder-guest-note\"");
            BeginWriteAttribute("value", " value=\"", 3701, "\"", 3719, 1);
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
WriteAttributeValue("", 3709, item.Note, 3709, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                    <td>\r\n                        <a class=\"red\" href=\"javascript:;\" onclick=\"_order_detail_vinwonder.DeletevinwonderGuest($(this));\"><i class=\"fa fa-times\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Order\AddVinWonderServiceGuests.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tr class=""service-vinwonder-guest-summary-row"">
            <td></td>
            <td>
                <a href=""javascript:;"" class=""blue ml-2 mb10"" onclick=""_order_detail_vinwonder.AddvinwonderGuest($(this));""><i class=""fa fa-plus-circle green""></i> Thêm thành viên</a>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
           
        </tr>
    </tbody>
</table>
");
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
