#pragma checksum "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e841ea812100dc993023f1e8a60f3124f699ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Add), @"mvc.1.0.view", @"/Views/Invoice/Add.cshtml")]
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
#line 1 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
using Utilities.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e841ea812100dc993023f1e8a60f3124f699ed", @"/Views/Invoice/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
  
    var allCode_PAY_TYPE = (List<AllCode>)ViewBag.allCode_PAY_TYPE;
    var listBankingAccount = (List<BankingAccount>)ViewBag.listBankingAccount;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .white-popup {
        max-width: 1300px !important;
    }

    .content_lightbox .head {
        font-weight: 500 !important;
        font-size: 16px !important;
        margin-bottom: 20px !important;
    }

    .content_lightbox {
        padding: 20px !important;
    }

    .check-list1 {
        padding-left: 25px;
        position: unset;
        cursor: pointer;
        display: block;
        margin-bottom: 0;
    }

        .check-list1 .number {
            padding-right: 25px;
            padding-left: 0;
            display: inline-block;
        }

    .form-default .form-group .lbl {
        width: 100px;
    }

    .choose-ava {
        text-align: center !important;
        padding-bottom: 100% !important;
        width: 200px !important;
        min-height: 150px !important;
        position: relative !important;
        margin: 0 !important;
        height: 0 !important;
        cursor: pointer !important;
        border: 1px dashed #dfdf");
            WriteLiteral(@"df !important;
    }

        .choose-ava img {
            -o-object-fit: cover !important;
            object-fit: cover !important;
            -o-object-position: center !important;
            object-position: center !important;
            position: absolute !important;
            top: 0 !important;
            bottom: 0 !important;
            left: 0 !important;
            right: 0 !important;
            width: 100% !important;
            height: 100% !important;
        }

    .list-choose.row {
        margin: 0 -5px !important;
    }

    img {
        border: 0 !important;
        font-size: 0 !important;
        line-height: 0 !important;
        max-width: 100% !important;
    }

    img {
        vertical-align: middle !important;
        border-style: none !important;
    }

    .list-choose .choose-ava {
        margin-bottom: 5px !important;
    }
</style>

<div class=""grid grid__1 grid-don-hang gap10 mb20"">

    <div class=""grid-item border"">

 ");
            WriteLiteral(@"       <div class=""row row_min"">
            <div class=""col-md-6 form-group"">
                <label class=""lbl"">Tên khách hàng <sup class=""red"">*</sup></label>
                <div class=""wrap_input"">
                    <select class=""select2 client-select"" id=""client-select"" style=""width:100% !important"" multiple=""multiple""
                            onchange=""_add_invoice.GetInvoiceRequestsByClientId()"">
                    </select>
                    <div class=""validate-client-select""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Hình thức thanh toán <sup class=""red"">*</sup></label>
                <div class=""wrap_input"">
                    <select class=""form-control"" style=""width: 100%; height: 34px ;"" id=""pay-type""
                            onchange=""_add_invoice.OnChoosePaymentType()"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e841ea812100dc993023f1e8a60f3124f699ed7353", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 107 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                         foreach (var item in allCode_PAY_TYPE)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e841ea812100dc993023f1e8a60f3124f699ed9434", async() => {
#nullable restore
#line 109 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                               WriteLiteral(item.CodeValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                    <div class=""validate-pay_type""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl mt5 mb0"" id=""lblBankAccountRequired"">Tài khoản ngân hàng <sup class=""red"">*</sup></label>
                <label class=""lbl mt5 mb0"" id=""lblBankAccount"">Tài khoản ngân hàng</label>
                <div");
            BeginWriteAttribute("class", " class=\"", 3869, "\"", 3877, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <select class=\"form-control\" style=\"width: 100%; height: 34px ;\" id=\"bankingAccount\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e841ea812100dc993023f1e8a60f3124f699ed12166", async() => {
                WriteLiteral("Chọn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                         foreach (var item in listBankingAccount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e841ea812100dc993023f1e8a60f3124f699ed14250", async() => {
#nullable restore
#line 123 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                                                Write(item.BankId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 123 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                                                               Write(item.AccountNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 124 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                    <div class=""validate-bankingAccount""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Mẫu số</label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""denominator"" maxlength=""20""");
            BeginWriteAttribute("value", " value=\"", 4654, "\"", 4662, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""validate-denominator""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Ký hiệu</label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""symbol"" maxlength=""20"">
                    <div class=""validate-symbol""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Số  <sup class=""red"">*</sup></label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""number"" maxlength=""7"">
                    <div class=""validate-number""></div>
                </div>
            </div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Ngày xuất <sup class=""red"">*</sup></label>
                <div class=""wrap_input"">
                    <input class=""form-control datepicker-payment");
            WriteLiteral(@""" type=""text"" name=""exportDate"" id=""exportDate""
                           style=""width: 100% !important;min-width: 200px !important;"">
                    <div class=""validate-exportDate""></div>
                </div>
            </div>

        </div>
        <div class=""border-bottom mb15""></div>
        <div class=""bold mb10 txt_14"">Yêu cầu xuất liên quan <sup class=""red"">*</sup></div>
        <div class=""validate-invoice_request""></div>
");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""bold mb10"">Mã phiếu</div>
                <div class=""w-100 mb15"" style="" padding-right: 10px !important;"">
                    <select class=""select2 invoiceRequestCode"" id=""invoiceRequestCode""
                            onchange=""_add_invoice.OnCheckedRequest()"" multiple=""multiple"" style=""width: 100% !important""> </select>
                </div>
            </div>
            <div class=""col-md-4"" style=""display:none"">
                <div class=""bold mb10"">Ngày dự kiến xuất </div>
                <div class=""wrap_input"">
                    <div class=""datepicker-wrap"" style=""width:100%"">
                        <input class=""form-control date text-left filter_date_daterangepicker"" id=""filter_date_create_daterangepicker"" type=""text""
                               name=""datetimeCreateFilter"" style=""        min-width: 200px !important"" placeholder=""Ngày dự kiến xuất"" />
                    </div>
        ");
            WriteLiteral(@"        </div>
            </div>
            <div class=""col-md-4"" style=""display:none"">
                <div class=""bold mb10"">Người tạo</div>
                <div class=""wrap_input"" style=""min-width: 200px;"">
                    <select class=""select2 client-select main-staff-select"" id=""invoiceRequestCreate"" multiple=""multiple"" style=""width:100% !important""
                            onchange=""_add_invoice.OnCheckedRequest()"">
                    </select>
                </div>
            </div>
        </div>
        <div class=""table-responsive table-default table-gray table-modal mb20"">
            <table class=""table table-nowrap"" id=""request-relate-table"">
                <thead>
                    <tr>
                        <th>
                            <label class='check-list number'>
                                <input type='checkbox' id=""checkAllRequest"" onclick=""_add_invoice.CheckOrUnCheckALl()"" />
                                <span class='checkmark'></span>STT");
            WriteLiteral(@"
                            </label>
                        </th>
                        <th>Mã phiếu</th>
                        <th>Ngày dự kiến xuất</th>
                        <th>Người tạo</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Tổng tiền</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Xuất thêm</th>
                        <th class=""text-right"" style=""min-width: 130px;"">Thu thêm</th>
                    </tr>
                </thead>
                <tbody id=""body_invoice_request_list"">
                </tbody>
            </table>
        </div>
        <div class=""row"">
            <div class=""col-12 bold mb10 txt_14"">Thông tin công ty trên hóa đơn</div>
            <div class=""col-md-3 form-group"">
                <label class=""lbl"">Mã số thuế</label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""taxtNo"" maxlength=""50"" disabled>
                </di");
            WriteLiteral(@"v>
            </div>
            <div class=""col-md-4 form-group"">
                <label class=""lbl"">Tên công ty</label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""companyName"" maxlength=""500"" disabled>
                </div>
            </div>
            <div class=""col-md-5 form-group"">
                <label class=""lbl"">Địa chỉ</label>
                <div class=""wrap_input"">
                    <input type=""text"" class=""form-control"" id=""address"" maxlength=""500"" disabled>
                </div>
            </div>
        </div>

        <div class=""bold mb10 txt_14"">Nội dung dịch vụ</div>
        <div class=""mb10 txt_14 validate-detail-info""></div>
        <div class=""table-responsive table-default table-gray bg-white mb15"">
            <table class=""table table-nowrap"" id=""table_contenxt_request"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th style=""m");
            WriteLiteral(@"in-width: 250px;"">Tên hàng hóa, dịch vụ</th>
                        <th>Đơn vị tính </th>
                        <th class=""text-right"">Số lượng </th>
                        <th class=""text-right"">Đơn giá</th>
                        <th class=""text-right"">Thành tiền</th>
                        <th class=""text-right"">Xuất thêm</th>
                        <th>Thu thêm</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id=""body_contenxt_request"">
                </tbody>
            </table>
        </div>
        <div class=""mb15"" style=""max-width: 300px;margin-left: auto;"">
            <ul class=""bold txt_14"">
                <li class=""flex space-between mb10"">
                    <div>Tổng tiền cần xuất </div>
                    <div id=""totalPriceBeforeVAT"">0</div>
                </li>
                <li class=""flex space-between mb10"">
                    <div>Tổng tiền thu thêm</div>
                    <div id=""t");
            WriteLiteral(@"otalPriceExportAfter"">0</div>
                </li>
            </ul>
        </div>
        <div class=""bold mb10 txt_14"">Thông tin thêm</div>
        <div class=""row row_min"">
            <div class=""form-group col-md-6"">
                <label class=""lbl"">Ghi chú (0/3,000 ký tự)</label>
                <div class=""wrap_input"">
                    <textarea class=""form-control"" style=""height: 90px;"" id=""note"" maxlength=""3000""></textarea>
                </div>
                <div class=""validate-note""></div>
            </div>
            <div class=""form-group col-md-6 attachment-addnew"">
               
            </div>
        </div>
        <div class=""row row_min"">
            <div class=""row list-choose"" id=""suplier_room_list_image"">
");
            WriteLiteral(@"            </div>
        </div>

        <div class=""text-right border-top pt-3"">
            <button type=""button"" class=""btn btn-default btn btn-default cancel"" onclick=""$.magnificPopup.close();"">Bỏ qua</button>
            <button type=""button"" class=""btn btn-default background-button"" background-button onclick=""_add_invoice.AddInvoice(0)"">Thêm</button>
        </div>

    </div>

</div>
<script type=""text/javascript"" src=""/modules/add_invoice.js""></script>
<script>
    $('.datepicker-payment').Zebra_DatePicker({
        format: 'd/m/Y'
    }).removeAttr('readonly');
    $('.datepicker-planDate').Zebra_DatePicker({
        format: 'd/m/Y'
    }).removeAttr('readonly');
    $('input[name=""datetimeCreateFilter""]').daterangepicker({
        autoUpdateInput: false,
        locale: {
            cancelLabel: 'Clear'
        }
    });
    $('input[name=""datetimeCreateFilter""]').on('cancel.daterangepicker', function (ev, picker) {
        $(this).val('');
        isPickerCreateAddInvo");
            WriteLiteral(@"ice = false;
        _add_invoice.OnCheckedRequest(true)
    });
    $('input[name=""datetimeCreateFilter""]').on('apply.daterangepicker', function (ev, picker) {
        $(this).val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
        isPickerCreateAddInvoice = true;
        _add_invoice.OnCheckedRequest()
    });
     _global_function.RenderFileAttachment($('.attachment-addnew'),0, ");
#nullable restore
#line 323 "F:\PROJECT\ADAVIGO\BACKEND\PHU_QUOC\WEB.CMS\Views\Invoice\Add.cshtml"
                                                                  Write((int)AttachmentType.Invoice_Request);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n\r\n    _add_invoice.Initialization();\r\n</script>");
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
