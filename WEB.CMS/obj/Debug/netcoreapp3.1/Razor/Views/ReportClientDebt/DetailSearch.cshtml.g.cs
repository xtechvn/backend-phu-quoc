#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f827195cde06962d03d45ba2de936275f2f7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportClientDebt_DetailSearch), @"mvc.1.0.view", @"/Views/ReportClientDebt/DetailSearch.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
using Entities.ViewModels.Report;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f827195cde06962d03d45ba2de936275f2f7be", @"/Views/ReportClientDebt/DetailSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportClientDebt_DetailSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
  
    Layout = null;
    int index = 0;
    GenericViewModel<ReportDetailClientDebtViewModel> model = (GenericViewModel<ReportDetailClientDebtViewModel>)ViewBag.Model;
    ReportClientDebtViewModel sum_model = (ReportClientDebtViewModel)ViewBag.SumModel;
    ReportDetailClientDebtSearchModel search_model = (ReportDetailClientDebtSearchModel)ViewBag.SearchModel;

    index = (model.CurrentPage - 1) * model.PageSize;
    double opening_credit = (double)ViewBag.OpeningCredit;
    double current_amount_credit = (sum_model.AmountCredit != null ? (double)sum_model.AmountCredit : 0) - (sum_model.AmountDebit != null ? (double)sum_model.AmountDebit : 0);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
 if (model.ListData != null && model.ListData.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
     foreach (var item in model.ListData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
            Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 23 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.CreatedDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 24 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.CreatedDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 25 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.LicenceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 26 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.BillNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 27 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 28 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.DebtAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\">");
#nullable restore
#line 29 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                      Write(item.CorrespondingAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td style=\"text-align: right;\" class=\"item-amount-debit\">");
#nullable restore
#line 31 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                                                 Write((item.AmountDebit != null ? (double)item.AmountDebit : 0).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right;\" class=\"item-amount-credit\">");
#nullable restore
#line 32 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                                                  Write((item.AmountCredit != null ? (double)item.AmountCredit : 0).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
              
                opening_credit = opening_credit + (item.AmountDebit != null ? (double)item.AmountDebit : 0) - (item.AmountCredit != null ? (double)item.AmountCredit : 0);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"text-align: right; \">");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                        Write(opening_credit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: right; \"></td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    _report_client_debt_detail.searchModel.OpeningCredit =  ");
#nullable restore
#line 42 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
                                                       Write(opening_credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>\r\n");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
 if (model.CurrentPage >= model.TotalPage || model.ListData == null || model.ListData.Count <= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(\'#view-more-tr\').remove()\r\n    </script>\r\n");
#nullable restore
#line 49 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\ReportClientDebt\DetailSearch.cshtml"
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
