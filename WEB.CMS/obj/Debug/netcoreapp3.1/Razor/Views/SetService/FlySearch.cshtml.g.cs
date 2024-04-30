#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a91c2f2653cc0249fe0820af8965e05ee55e90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_FlySearch), @"mvc.1.0.view", @"/Views/SetService/FlySearch.cshtml")]
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
#line 5 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a91c2f2653cc0249fe0820af8965e05ee55e90d", @"/Views/SetService/FlySearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_FlySearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericViewModel<Entities.ViewModels.SetServices.FlyBookingSearchViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
 if (Model != null)
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
                    <th style=""min-width: 150px !important; max-width: 350px !important;width: 300px !important;"">
                     Chi tiết dịch vụ
                    </th>
                    <th>
                        Ngày check in -
                        Ngày check out
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
       ");
            WriteLiteral("     <tbody>\r\n");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
        if (Model.ListData != null && Model.ListData.Count > 0)
                {
                    var STT = (Model.CurrentPage - 1) * Model.PageSize;
                    
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                        foreach (var item in Model.ListData)
                       {
                           var leg_count = item.GroupBookingId.Split(",").Count();
                           STT++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   Write(STT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 1711, "\"", 1780, 2);
            WriteAttributeValue("", 1718, "/SetService/fly/detail/", 1718, 23, true);
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
WriteAttributeValue("", 1741, item.GroupBookingId.Replace(",","_"), 1741, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                                                         Write(item.ServiceCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\r\n                    </td>\r\n                    <td>\r\n                        Hành trình: ");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                Write(leg_count>1?"Khứ hồi": "Một chiều");

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n                        <br />\r\n                        Điểm đi: ");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                            Write(item.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                              Write(item.StartDate.ToString("dd/MM/yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                        <br />\r\n                        Điểm đến: ");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                             Write(item.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                              Write(leg_count>1? "("+@item.EndDate.ToString("dd/MM/yyyy - HH:mm")+")": "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        Chiều đi: ");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                             Write(item.GoFlightNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                    Write(item.GoAirLines);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - Mã đặt chỗ: ");
#nullable restore
#line 56 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                                    Write(item.GoBookingCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        ");
#nullable restore
#line 58 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                    Write(leg_count>1? " Chiều về: "+item.BackFlightNumber+" - "+item.BackAirLines+" - Mã đặt chỗ: "+item.BackBookingCode: "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        Số người: ");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                             Write(item.PassengerNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   Write(item.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                             Write(leg_count>1? item.EndDate.ToString("dd/MM/yyyy") : "N/A");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 65 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                           double operator_amount = (item.AmountGo == null ? 0 : (double)item.AmountGo); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                    Write(operator_amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                           double operator_price = (item.PriceGo == null ? 0 : (double)item.PriceGo); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                    Write(operator_price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                          
                            double operator_profit = operator_amount - operator_price;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 76 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                    Write(operator_profit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td><a class=\"blue\"");
            BeginWriteAttribute("href", " href=\"", 3522, "\"", 3549, 2);
            WriteAttributeValue("", 3529, "/Order/", 3529, 7, true);
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
WriteAttributeValue("", 3536, item.OrderId, 3536, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                               Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n                    <td>");
#nullable restore
#line 79 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   Write(item.CreatedDate.ToString("dd/MM/yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   Write(item.SalerFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                              Write(item.SalerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                     Write(item.SalerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   Write(item.OperatorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"max-width:10%;width:8%\"> ");
#nullable restore
#line 82 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                    Write(item.BookingCode== null? "": item.BookingCode.TrimEnd(',', ' '));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 84 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                         switch (item.FlyBookingStatus)
                        {
                            case (int)Utilities.Contants.ServiceStatus.New:
                            case (int)Utilities.Contants.ServiceStatus.WaitingExcution:
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"status-oranger\">");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                        Write(item.FlyBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                               }
                                                break;
                                            case (int)Utilities.Contants.ServiceStatus.OnExcution:
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"status-blue\">");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                     Write(item.FlyBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                            }
                                                break;
                                            case (int)Utilities.Contants.ServiceStatus.ServeCode:
                                            case (int)Utilities.Contants.ServiceStatus.Payment:
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"status-green\">");
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                      Write(item.FlyBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 98 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                             }
                                                break;
                                            case (int)Utilities.Contants.ServiceStatus.Cancel:
                                            case (int)Utilities.Contants.ServiceStatus.Decline:
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"status-red\">");
#nullable restore
#line 103 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                    Write(item.FlyBookingStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>                                ");
#nullable restore
#line 103 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                                                          }
                                                break;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 108 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                   
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <input id=\"countFy\"");
            BeginWriteAttribute("value", "value=\"", 5675, "\"", 5700, 1);
#nullable restore
#line 114 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
WriteAttributeValue("", 5682, Model.TotalRecord, 5682, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\"/>\r\n    ");
#nullable restore
#line 115 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
Write(await Component.InvokeAsync("PagingNew", new
    {
        pageModel = new Paging()
        {
            TotalRecord = Model.TotalRecord,
            TotalPage = Model.TotalPage,
            CurrentPage = Model.CurrentPage,
            PageSize = Model.PageSize,
            RecordName = "Chính sách",
            PageAction = "_set_service_fly.OnPaging({0})",
            PageSelectPageSize = "_set_service_fly.onSelectPageSize()",
        }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n        $(\'#selectPaggingOptions\').val(\'");
#nullable restore
#line 129 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                   Write(Model.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').attr(\"selected\", \"selected\");\r\n                        _set_service_fly.ChangeTotalFlyTicketTotalCount(");
#nullable restore
#line 130 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                                                                   Write(Model.TotalRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                </script>\r\n                </div> ");
#nullable restore
#line 132 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
                       }
            else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"search-null center mb40\">\r\n                    <div class=\"mb24\">\r\n                        <img src=\"/images/graphics/icon-search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6647, "\"", 6653, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <h2 class=""title txt_24"">Không tìm thấy kết quả</h2>
                    <div class=""gray"">Chúng tôi không tìm thấy thông tin mà bạn cần, vui lòng thử lại</div>
                </div>
                <script>        _set_service_fly.ChangeTotalFlyTicketTotalCount(0) </script>
");
#nullable restore
#line 143 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\FlySearch.cshtml"
            }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericViewModel<Entities.ViewModels.SetServices.FlyBookingSearchViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
