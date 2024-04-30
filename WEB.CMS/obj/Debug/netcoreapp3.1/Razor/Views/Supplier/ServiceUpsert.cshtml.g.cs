#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b667aeedbf412144d9ddd9ac610642c7fdd6acf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_ServiceUpsert), @"mvc.1.0.view", @"/Views/Supplier/ServiceUpsert.cshtml")]
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
#line 4 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
using Entities.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b667aeedbf412144d9ddd9ac610642c7fdd6acf4", @"/Views/Supplier/ServiceUpsert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_ServiceUpsert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .item_selected_hotel {
        padding: 10px 5px;
        border-bottom: 1PX SOLID #CCC;
    }

        .item_selected_hotel:last-child {
            border-bottom: none;
        }

    .cursor-pointer {
        cursor: pointer;
    }
</style>

<div class=""tab-default nav nav-tabs"">
    <a class=""active"" href=""#tab-hotel"" data-toggle=""tab"">Khách sạn</a>
    <a class=""mfp-hide"" href=""#tab-tour"" data-toggle=""tab"">Tour du lịch</a>
</div>
<div class=""tab-content"">
    <div class=""tab-pane show active"" id=""tab-hotel"" role=""tabpanel"">
        <div class=""form-default3"">
            <div class=""row row_min"">
                <div class=""col-md-12 mb20"">
                    <select class=""form-control"" id=""service_hotel_suggest"" style=""width:100%"">
                    </select>
                </div>

                <div class=""col-md-12 mb20"" id=""grid_selected_hotel"">
");
#nullable restore
#line 36 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
                     if (Model != null && Model.Any())
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item_selected_hotel red\" data-value=\"");
#nullable restore
#line 40 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <span class=\"blue\">");
#nullable restore
#line 41 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <a class=\"cursor-pointer\" onclick=\"$(this).parent().remove()\"><i class=\"fa fa-times\" style=\"float:right;\"></i></a>\r\n                            </div>\r\n");
#nullable restore
#line 44 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Supplier\ServiceUpsert.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <div class=""col-md-12 text-right"">
                    <button type=""button"" class=""btn btn-default btn btn-default cancel"" data-dismiss=""modal"">Bỏ qua</button>
                    <button type=""button"" class=""btn btn-default"" onclick=""_supplier_service.Upsert()"">
                        <i class=""fa fa-save""></i> Lưu
                    </button>
                </div>
            </div>
        </div>
    </div>
    <div class=""tab-pane mfp-hide"" id=""tab-tour"" role=""tabpanel"">
        <div class=""form-default3"">
            <div class=""row row_min"">
                <div class=""grid-item col-md-12"">
                    <div class=""border mb20"">
                        nothing hể
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"" defer>
    $(document).ready(function(){
        $(""#service_hotel_suggest"").select2({
            placeholder: ""Tìm kiếm khách sạn"",");
            WriteLiteral(@"
            ajax: {
                url: ""/Hotel/Suggest"",
                type: ""get"",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    var query = {
                        text: params.term,
                        size: 10
                    }
                    return query;
                },
                processResults: function (data) {
                    var data = {
                        results: $.map(data, function (item) {
                            return {
                                text: item.name,
                                id: item.id,
                            }
                        })
                    }
                    return data;
                }
            }
        });
    });

    $(""#service_hotel_suggest"").change(function(){
        let seft = $(this);
        let gridSelectHotel = $('#grid_selected_hotel');
        let value = seft.val();
     ");
            WriteLiteral(@"   let text = seft.find("":selected"").text();

        let arr_value = [];
        gridSelectHotel.find('.item_selected_hotel').each(function(){
            arr_value.push($(this).data('value'));
        });

        if(!arr_value.includes(parseInt(value))){
            gridSelectHotel.append(`<div class=""item_selected_hotel red"" data-value=""${value}"">
                <span class=""blue"">${text}</span>
                <a class=""cursor-pointer"" onclick=""$(this).parent().remove()""><i class=""fa fa-times"" style=""float:right;""></i></a>
            </div>`);
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
