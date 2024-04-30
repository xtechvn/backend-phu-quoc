#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c8ff6a658db4abe9ffbf2c3f6d94d4ce1230fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_OtherSearch), @"mvc.1.0.view", @"/Views/SetService/OtherSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c8ff6a658db4abe9ffbf2c3f6d94d4ce1230fa", @"/Views/SetService/OtherSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_OtherSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
   
    Layout = null;
    Entities.ViewModels.GenericViewModel<Entities.ViewModels.SetServices.OtherBookingSearchViewModel> model = (Entities.ViewModels.GenericViewModel<Entities.ViewModels.SetServices.OtherBookingSearchViewModel>)ViewBag.Model;
    int index = 0;
    long countOther = model.TotalRecord;
    if(model!=null && model.ListData!=null && model.ListData.Count > 0)
    {
        index = (model.CurrentPage - 1) * model.PageSize;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .green {\r\n        color: #4BAC4D;\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
 if (model != null && model.ListData != null && model.ListData.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrap_bg wrap_bg_no-padding mb20"">
    <div class=""table-responsive table-default table-gray"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>
                    <th>STT</th>
                    <th>Mã dịch vụ</th>
                    <th>Chi tiết dịch vụ</th>
                    <th>
                        Ngày bắt đầu -
                        Ngày kết thúc
                    </th>
                    <th>Doanh thu dịch vụ</th>
                    <th>Giá NET thực tế</th>
                    <th>Lợi nhuận thực tế</th>
                    <th>Mã đơn hàng</th>
                    <th>Ngày tạo</th>
                    <th>Nhân viên bán</th>
                    <th>Điều hành</th>
                    <th>Mã code</th>
                    <th>Trạng thái</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                 foreach (var item in model.ListData)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 48 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                    Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1713, "\"", 1744, 2);
            WriteAttributeValue("", 1720, "Others/Detail/", 1720, 14, true);
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
WriteAttributeValue("", 1734, item.Id, 1734, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                    Write(item.ServiceCode==null || item.ServiceCode.Trim()==""?"{Unknown Code}": item.ServiceCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </td>\r\n                    <td>\r\n                        Dịch vụ : ");
#nullable restore
#line 53 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                              Write(item.ServiceTypeName == null?"": item.ServiceTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                   Write(item.StartDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 55 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                  Write(item.EndDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                    Write(item.Amount==null ?"": ((double)item.Amount).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                    Write(item.Price==null ?"": ((double)item.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                           double operator_profit = (item.Amount == null ? 0 : (double)item.Amount) - (item.Price == null ? 0 : (double)item.Price); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 64 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                    Write(operator_profit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div><a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 2750, "\"", 2777, 2);
            WriteAttributeValue("", 2757, "/Order/", 2757, 7, true);
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
WriteAttributeValue("", 2764, item.OrderId, 2764, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                    Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                   Write(item.CreatedDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                   Write(item.SalerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                    Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                    <td>");
#nullable restore
#line 71 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                   Write(item.OperatorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"max-width:10%;width:8%\"> ");
#nullable restore
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                    Write(item.BookingCode== null? "": item.BookingCode.TrimEnd(',', ' '));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-oranger\">");
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                    Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 77 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-oranger\">");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                    Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-blue\">");
#nullable restore
#line 83 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                 Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 83 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-green\">");
#nullable restore
#line 86 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                  Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 86 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 4)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-green\">");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                  Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                         if (item.OtherBookingStatus == 5 || item.OtherBookingStatus == 6)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"status-red\">");
#nullable restore
#line 92 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                Write(item.OtherBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 92 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 95 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
#nullable restore
#line 100 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
     if (model != null && model.ListData != null && model.ListData.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input id=\"countOther\"");
            BeginWriteAttribute("value", " value=\"", 4535, "\"", 4555, 1);
#nullable restore
#line 102 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
WriteAttributeValue(" ", 4543, countOther, 4544, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\" />\r\n");
#nullable restore
#line 103 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
   Write(await Component.InvokeAsync("PagingNew", new
        {
            pageModel = new Entities.ViewModels.Paging()
            {
                TotalRecord = model.TotalRecord,
                TotalPage = model.TotalPage,
                CurrentPage = model.CurrentPage,
                PageSize = model.PageSize,
                RecordName = "Other",
                PageAction = "_set_service_other.OnPaging({0})",
                PageSelectPageSize = "_set_service_other.onSelectPageSize()",
            }
        }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> ");
#nullable restore
#line 117 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"search-null center mb40\">\r\n    <div class=\"mb24\">\r\n        <img src=\"/images/graphics/icon-search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5282, "\"", 5288, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <h2 class=\"title txt_24\">Không tìm thấy kết quả</h2>\r\n    <div class=\"gray\">Chúng tôi không tìm thấy thông tin mà bạn cần, vui lòng thử lại</div>\r\n</div>");
#nullable restore
#line 126 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\OtherSearch.cshtml"
      }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591