#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa38f0f7c8dba7be985bc0006b6a5a20f2b14edd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetService_HotelServiceDetai), @"mvc.1.0.view", @"/Views/SetService/HotelServiceDetai.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
using Entities.ViewModels.HotelBooking;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa38f0f7c8dba7be985bc0006b6a5a20f2b14edd", @"/Views/SetService/HotelServiceDetai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SetService_HotelServiceDetai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelBookingDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table table-nowrap\" id=\"hotelBookingDetail\">\r\n    <tbody>\r\n\r\n        <tr>\r\n            <td colspan=\"3\">\r\n                <strong>Dịch vụ khách sạn: ");
#nullable restore
#line 9 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                      Write(Model.ServiceCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 10 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-oranger\">");
#nullable restore
#line 11 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 11 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-oranger\">");
#nullable restore
#line 13 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 13 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-blue\">");
#nullable restore
#line 15 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                      Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 15 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-green\">");
#nullable restore
#line 17 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                       Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 17 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-green\">");
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                       Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                 if (Model.Status == 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"status-red\">");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                     Write(Model.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td style=\"min-width: 400px;\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-4 mb10 gray\">Tên khách sạn</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Nhà cung cấp</div>\r\n                    <div class=\"col-8 mb10\" id=\"suplier-detail\" data-suplier-name=\"");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                              Write(Model.SuplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-suplier-id=\"");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                                                   Write(Model.SupplierId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">: ");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                                                                        Write(Model.SuplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a class=\"blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1435, "\"", 1500, 3);
            WriteAttributeValue("", 1445, "_SetService_Detail.OpenPopupSupplier(", 1445, 37, true);
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
WriteAttributeValue("", 1482, Model.SupplierId, 1482, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1499, ")", 1499, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit blue\"></i></a></div>\r\n                    <div class=\"col-4 mb10 gray\">Ngày check in</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                          Write(Convert.ToDateTime(Model.ArrivalDate).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Ngày check out</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                          Write(Convert.ToDateTime(Model.DepartureDate).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Số lượng phòng</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 35 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.NumberOfRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Nhân viên bán</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.UserCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Điều hành viên</div>\r\n                    <div class=\"col-8 mb10\" id=\"Saler-Name\" data-sale=\"");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                  Write(Model.SalerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">: ");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                      Write(Model.SalerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2422, "\"", 2498, 6);
            WriteAttributeValue("", 2432, "_SetService_Detail.OpenPopupUserAgent(", 2432, 38, true);
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
WriteAttributeValue("", 2470, Model.Id, 2470, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2479, ",", 2479, 1, true);
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
WriteAttributeValue("", 2480, Model.OrderId, 2480, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2494, ",", 2494, 1, true);
            WriteAttributeValue(" ", 2495, "1)", 2496, 3, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-edit blue""></i></a></div>
                </div>
            </td>
            <td style=""min-width: 400px;"">
                <div class=""row"">
                    <div class=""col-4 mb10 gray"">Tổng giá trị đơn hàng</div>
                    <div class=""col-8 mb10"">: ");
#nullable restore
#line 45 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.OrderPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Tổng giá trị dịch vụ</div>\r\n                    <div class=\"col-8 mb10\" id=\"sale-order-amount\" data-amount=\"");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                           Write(Model.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">: ");
#nullable restore
#line 47 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                                 Write(Model.TotalAmount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Tổng chi dịch vụ thực tế</div>\r\n");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                      
                        if (Model.Price == null) Model.Price = Model.TotalAmount - Model.TotalProfit - Model.TotalOthersAmount - Model.TotalDiscount;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-8 mb10\" id=\"operator-order-amount\" data-amount=\"");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                Write(((double)Model.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">: ");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                                                           Write(((double)Model.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Lợi nhuận dịch vụ thực tế</div>\r\n");
#nullable restore
#line 54 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                      
                        if (Model.TotalOthersAmount == null) Model.TotalOthersAmount = 0;
                        if (Model.TotalDiscount == null) Model.TotalDiscount = 0;
                        var operator_profit = Model.TotalAmount - Convert.ToDouble(Model.Price); //- (double)Model.TotalOthersAmount - (double)Model.TotalDiscount;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-8 mb10\" id=\"operator-order-profit\" data-profit=\"");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                Write(operator_profit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">: ");
#nullable restore
#line 59 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                                                                                                     Write(operator_profit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-4 mb10 gray\">Lợi nhuận sale nhập</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.TotalProfit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                    <div class=\"col-4 mb10 gray\">Hoàn trả khách hàng</div>\r\n                    <div class=\"col-8 mb10\">: ");
#nullable restore
#line 63 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.TotalAmountPaymentRequest.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n                </div>\r\n            </td>\r\n            <td style=\"min-width: 400px;\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-5 mb10 gray\">Người tạo</div>\r\n                    <div class=\"col-7 mb10\">: ");
#nullable restore
#line 69 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                         Write(Model.UserCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-5 mb10 gray\">Ngày tạo</div>\r\n                    <div class=\"col-7 mb10 \">: ");
#nullable restore
#line 71 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                           Write(Convert.ToDateTime(Model.CreatedDate).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-5 mb10 gray\">Người cập nhật</div>\r\n                    <div class=\"col-7 mb10\">: ");
#nullable restore
#line 73 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                          Write(Model.UserUpdate ==null?"N/A": Model.UserUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-5 mb10 gray\">Ngày cập nhật</div>\r\n                    <div class=\"col-7 mb10\">: ");
#nullable restore
#line 75 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\SetService\HotelServiceDetai.cshtml"
                                          Write(Model.UserUpdate == null ? "N/A" : Model.UpdatedDate.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelBookingDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591