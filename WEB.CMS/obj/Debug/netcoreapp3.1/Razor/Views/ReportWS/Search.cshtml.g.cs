#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a5637b1917d654d13d7200d36faad56e005b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportWS_Search), @"mvc.1.0.view", @"/Views/ReportWS/Search.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
using Entities.ViewModels.Report;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a5637b1917d654d13d7200d36faad56e005b59", @"/Views/ReportWS/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportWS_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
  
    Layout = null;
    int index = 0;
    var service_type = (List<AllCode>)ViewBag.Type;
    List<WSReportTotalViewModel> sum_model = (List<WSReportTotalViewModel>)ViewBag.TotalReport;
    WSReportTotalViewModel summary = (WSReportTotalViewModel)ViewBag.Summary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
 if (sum_model != null && sum_model.Any())
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive table-default table-gray wrap_bg wrap_bg_no-padding  table-scroll table-report"" style=""max-height:1200px;"">
        <table class=""table table-nowrap"">
            <thead>
                <tr>

                    <th rowspan=""2"" style=""text-align: center; font-weight:bold;"">Ngày</th>
");
#nullable restore
#line 21 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                      
                        foreach (var type in service_type)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th colspan=\"2\" style=\"text-align: center; font-weight:bold;\">");
#nullable restore
#line 24 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                                     Write(type.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 25 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <th rowspan=""2""style=""text-align: center; font-weight: bold;"">Tổng doanh thu</th>
                    <th rowspan=""2""style=""text-align: center; font-weight: bold;"">Tổng hoa hồng</th>
                    <th rowspan=""2""></th>
                </tr>
                <tr>
");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                      
                        foreach (var type in service_type)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>Doanh thu</th>\r\n                            <th>Hoa hồng</th>\r\n");
#nullable restore
#line 37 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr style=\"background-color: yellow; font-weight: bold;\">\r\n                    <td >Tổng cộng</td>\r\n");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                      
                        foreach (var type in service_type)
                        {
                            var item_by_service_type = summary.ServicesList.FirstOrDefault(x => x.ServiceType == type.CodeValue);
                            if (item_by_service_type != null && item_by_service_type.ServiceType > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"text-align: right; font-weight: bold;\">");
#nullable restore
#line 50 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                              Write(item_by_service_type.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align: right; font-weight: bold;\">");
#nullable restore
#line 51 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                              Write(item_by_service_type.Commission.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"text-align: right; font-weight: bold;\">0</td>\r\n                                <td style=\"text-align: right; font-weight: bold;\">0</td>\r\n");
#nullable restore
#line 57 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"text-align: right; font-weight:bold;\">");
#nullable restore
#line 60 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                 Write((summary.ServicesList==null ? 0: summary.ServicesList.Sum(x=>x.Amount)).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align: right; font-weight:bold;\">");
#nullable restore
#line 61 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                 Write((summary.ServicesList == null ? 0 : summary.ServicesList.Sum(x => x.Commission)).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n\r\n                </tr>\r\n\r\n");
#nullable restore
#line 66 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                 foreach (var item in sum_model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td class=\"date_used\">");
#nullable restore
#line 70 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                         Write(item.DateUsed.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 72 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                          
                            foreach (var type in service_type)
                            {
                                var item_by_service_type = item.ServicesList.FirstOrDefault(x => x.ServiceType == type.CodeValue);
                                if (item_by_service_type != null && item_by_service_type.ServiceType > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"text-align: right;\">");
#nullable restore
#line 78 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                               Write(item_by_service_type.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td style=\"text-align: right;\">");
#nullable restore
#line 79 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                               Write(item_by_service_type.Commission.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 80 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"text-align: right;\">0</td>\r\n                                    <td style=\"text-align: right;\">0</td>\r\n");
#nullable restore
#line 85 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"text-align: right;\">");
#nullable restore
#line 88 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                   Write((item.ServicesList==null ? 0: item.ServicesList.Sum(x=>x.Amount)).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align: right;\">");
#nullable restore
#line 89 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                   Write((item.ServicesList == null ? 0 : item.ServicesList.Sum(x => x.Commission)).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a href=\"javascript:;\" style=\"font-weight:bold;\" onclick=\"_report_ws.Detail($(this))\" data-date=\"");
#nullable restore
#line 90 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                                                                                                                        Write(item.DateUsed.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem chi tiết</a></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 93 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 97 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"search-null center mb40\">\r\n        <div class=\"mb24\">\r\n            <img src=\"/images/graphics/icon-search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5051, "\"", 5057, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <h2 class=\"title txt_24\">Không tìm thấy kết quả</h2>\r\n        <div class=\"gray\">Chúng tôi không tìm thấy thông tin mà bạn cần, vui lòng thử lại</div>\r\n    </div>\r\n");
#nullable restore
#line 108 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportWS\Search.cshtml"
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
