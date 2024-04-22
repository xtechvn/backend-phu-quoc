var _set_service_ws_html = {
    html_user_option: '<option class="select2-results__option" value="{user_id}">{user_name} - {user_email}{user_phone}</option>',
    confirm_box_description_grant_order: 'Bạn có chắc muốn nhận đặt dịch vụ {Mã dịch vụ} không?',
    confirm_box_description_send_service_code: 'Bạn có chắc muốn trả code dịch vụ {Mã dịch vụ} không?',
    confirm_box_description_change_to_payment: 'Bạn có chắc muốn quyết toán dịch vụ {Mã dịch vụ} không?',
    confirm_box_description_operator_order_price: 'Thông tin giá đặt dịch vụ sẽ được lưu lại, bạn có chắc chắn không?',
    confirm_box_description_decline: 'Bạn có chắc muốn từ chối dịch vụ {Mã dịch vụ} không?',
    confirm_box_title_grant_order: 'Confirm nhận đặt dịch vụ',
    confirm_box_title_send_service_code: 'Confirm trả Code dịch vụ',
    confirm_box_title_change_to_payment: 'Confirm quyết toán',
    confirm_box_title_operator_order_price: 'Thay đổi giá đặt dịch vụ',
    confirm_box_title_decline: 'Từ chối đặt dịch vụ',
    html_ordered_new_packages: `
                        <tr class="service-ws-ordered-row" data-id="0">
                        <td class="service-ws-ordered-order">@(++index)</td>
                        <td><p class="form-control service-ws-ordered-package-name input-disabled-background" disabled>@item.PackageName</p></td>
                        <td>
                            <select class="select2 service-ws-ordered-suplier service-ws-ordered-suplier-new" style="width:100% !important">

                            </select>
                        </td>
                        <td> <input class="form-control text-right currency service-ws-packages-baseprice-operator"  type="text" name="service-ws-packages-baseprice-operator" value=""></td>
                        <td> <input class="form-control text-right currency service-ws-packages-quantity"  type="text" name="service-ws-packages-quantity" value=""></td>
                        <td class="text-right"> <input class="form-control text-right currency service-ws-packages-unit-price input-disabled-background" disabled style="background-color: lightgray;" value=""></td>
                        <td> <textarea class="form-control style-width2 textarea service-ws-ordered-note "></textarea> </td>
                        <td> <a class="fa fa-trash-o service-ws-ordered-delete-row-disabled service-ws-ordered-delete-row" href="javascript:;"></a></td>
                    </tr>`
}

var _set_service_ws = {
    Initialization: function () {
        _common_function_ws.SingleDateRangePicker($('.set-service-ws-search-startdate'))
        _common_function_ws.SingleDateRangePicker($('.set-service-ws-search-enddate'))
        _common_function_ws.SingleDateRangePicker($('.set-service-ws-search-createddate'))

        _common_function_ws.UserSuggesstionMultiple($('.set-service-ws-search-saler'))
        _common_function_ws.UserSuggesstionMultiple($('.set-service-ws-search-main-staff'))
        _common_function_ws.UserSuggesstionMultiple($('.set-service-ws-search-usercreate'))
      
        _set_service_ws.DynamicBindInput()
        _set_service_ws.SearchData()
        setTimeout(function () {

            $('.set-service-ws-search-status').select2({
                placeholder: "Tất cả trạng thái dịch vụ"
            })
        }, 500)
    },
    DynamicBindInput: function () {
        $("body").on('apply.daterangepicker', ".set-service-ws-search-startdate", function (ev, picker) {
            _common_function_ws.OnApplyStartDateTimeOfBookingRange($(this), $('.set-service-ws-search-enddate'))

        });
        $("body").on('apply.daterangepicker', ".set-service-ws-search-daterange", function (ev, picker) {
            $(this).val(picker.startDate.format('DD/MM/YYYY') + ' - ' + picker.endDate.format('DD/MM/YYYY'));
        });
        $("body").on('focusout', ".set-service-ws-search-startdate", function (ev, picker) {
            if ($(this).val() == undefined || $(this).val().trim() == '') {
                _common_function_ws.SingleDateRangePicker($('.set-service-ws-search-enddate'))
            }
        });
        $("body").on('click', ".service-ws-filter-by-status", function (ev, picker) {
            var element = $(this)

            $('.service-ws-filter-by-status').removeClass('active')
            element.addClass('active')

            var status = [];
            if (element.attr('data-status').trim() != '-1') status = [element.attr('data-status')]
            $('.set-service-ws-search-status').val(status).change();
            _set_service_ws.SearchData()


        });



    },
    Search: function (input) {
        window.scrollTo(0, 0);
        $.ajax({
            url: "/SetService/WaterSportSearch",
            type: "Post",
            data: input,
            success: function (result) {
                $('#search_data_grid').html(result);
                _common_function_ws.OrderNoSuggesstion($('.set-service-ws-search-orderno'))
                _common_function_ws.ServiceCodeSuggesstion($('.set-service-ws-search-servicecode'))
                _common_function_ws.Select2BookingCode($("#BookingCode"))
            }
        });
    },
    OnPaging: function (value) {
        if (value > 0) {
            var objSearch = _set_service_ws.GetParam(value);
            _set_service_ws.Search(objSearch);
        }
    },
    onSelectPageSize: function () {
        _set_service_ws.SearchData();

    },
    SearchData: function () {
        var objSearch = _set_service_ws.GetParam(1);
        _set_service_ws.Search(objSearch);
    },
    GetParam: function (PageIndex) {
        var object_search_summit = {
            searchModel: {
                ServiceCode: $('.set-service-ws-search-servicecode').find(':selected').val() == undefined || $('.set-service-ws-search-servicecode').find(':selected').val().trim() == '' ? '' : $('.set-service-ws-search-servicecode').find(':selected').val().trim(),
                OrderCode: $('.set-service-ws-search-orderno').find(':selected').val() == undefined || $('.set-service-ws-search-orderno').find(':selected').val().trim() == '' ? '' : $('.set-service-ws-search-orderno').find(':selected').val().trim(),
            }

        }
        var status = '';
        $('.set-service-ws-search-status').find(':selected').each(function (index, item) {
            var element = $(item);
            if (element.val().includes(',')) {
                status = '' + element.val()
                return false;
            }
            if (status == '') status = '' + element.val()
            else status = status + ',' + element.val()
        });
        object_search_summit.searchModel.StatusBooking = status
        object_search_summit.searchModel.BookingCode =  $("#BookingCode").val(),

        object_search_summit.searchModel.UserCreate = $('.set-service-ws-search-usercreate').find(':selected').val() == undefined || $('.set-service-ws-search-usercreate').find(':selected').val().trim() == '' ? null : $('.set-service-ws-search-usercreate').find(':selected').val()
        object_search_summit.searchModel.SalerId = $('.set-service-ws-search-saler').find(':selected').val() == undefined || $('.set-service-ws-search-saler').find(':selected').val().trim() == '' ? null : $('.set-service-ws-search-saler').find(':selected').val()
        object_search_summit.searchModel.OperatorId = $('.set-service-ws-search-main-staff').find(':selected').val() == undefined || $('.set-service-ws-search-main-staff').find(':selected').val().trim() == '' ? null : $('.set-service-ws-search-main-staff').find(':selected').val()
        object_search_summit.searchModel.PageIndex = PageIndex
        object_search_summit.searchModel.pageSize = isNaN(parseInt($('#selectPaggingOptions').find(':selected').val())) || parseInt($('#selectPaggingOptions').find(':selected').val()) == undefined ? 30 : parseInt($('#selectPaggingOptions').find(':selected').val())
        var compare_from = _global_function.GetDayText($('.set-service-ws-search-startdate').data('daterangepicker').startDate._d, true).trim().split(' ')[0]
        var compare_to = _global_function.GetDayText($('.set-service-ws-search-startdate').data('daterangepicker').endDate._d, true).trim().split(' ')[0]

        if ($('.set-service-ws-search-startdate').val() == undefined || $('.set-service-ws-search-startdate').val().trim() == '') {
            object_search_summit.searchModel.StartDateFrom = undefined;
            object_search_summit.searchModel.StartDateTo = undefined;

        }
        else {
            object_search_summit.searchModel.StartDateFrom = _global_function.GetDayText($('.set-service-ws-search-startdate').data('daterangepicker').startDate._d, true);
            object_search_summit.searchModel.StartDateTo = _global_function.GetDayText($('.set-service-ws-search-startdate').data('daterangepicker').endDate._d, true);
        }
        compare_from = _global_function.GetDayText($('.set-service-ws-search-enddate').data('daterangepicker').startDate._d, true).trim().split(' ')[0]
       compare_to = _global_function.GetDayText($('.set-service-ws-search-enddate').data('daterangepicker').endDate._d, true).split(' ')[0]
        if ($('.set-service-ws-search-enddate').val() == undefined || $('.set-service-ws-search-enddate').val().trim() == '') {
            object_search_summit.searchModel.EndDateFrom = undefined;
            object_search_summit.searchModel.EndDateTo = undefined;
        }
        else {
            object_search_summit.searchModel.EndDateFrom = _global_function.GetDayText($('.set-service-ws-search-enddate').data('daterangepicker').startDate._d, true);
            object_search_summit.searchModel.EndDateTo = _global_function.GetDayText($('.set-service-ws-search-enddate').data('daterangepicker').endDate._d, true);
        }
        compare_from = _global_function.GetDayText($('.set-service-ws-search-createddate').data('daterangepicker').startDate._d, true).trim().split(' ')[0]
        compare_to = _global_function.GetDayText($('.set-service-ws-search-createddate').data('daterangepicker').endDate._d, true).split(' ')[0]
        if ($('.set-service-ws-search-createddate').val() == undefined || $('.set-service-ws-search-createddate').val().trim() == '') {
            object_search_summit.searchModel.CreateDateFrom = undefined;
            object_search_summit.searchModel.CreateDateTo = undefined;

        }
        else {
            object_search_summit.searchModel.CreateDateFrom = _global_function.GetDayText($('.set-service-ws-search-createddate').data('daterangepicker').startDate._d, true);
            object_search_summit.searchModel.CreateDateTo = _global_function.GetDayText($('.set-service-ws-search-createddate').data('daterangepicker').endDate._d, true);
        }

        return object_search_summit;
    },
    Export: function () {
        $('#btnExport').prop('disabled', true);
        $('#icon-export').removeClass('fa-file-excel-o');
        $('#icon-export').addClass('fa-spinner fa-pulse');
        var objSearch = _set_service_ws.GetParam(1);
        objSearch.PageIndex = 1;
        objSearch.searchModel.pageSize = $('#countws').val();
        this.searchModel = objSearch
        _global_function.AddLoading()
        $.ajax({
            url: "/SetService/wsExportExcel",
            type: "Post",
            data: this.searchModel,
            success: function (result) {
                _global_function.RemoveLoading()
                $('#btnExport').prop('disabled', false);
                if (result.isSuccess) {
                    _msgalert.success(result.message);
                    window.location.href = result.path;
                } else {
                    _msgalert.error(result.message);
                }
                $('#icon-export').removeClass('fa-spinner fa-pulse');
                $('#icon-export').addClass('fa-file-excel-o');
            }
        });
    },
}

var _set_service_ws_detail = {
    ServiceType: 34,
    ServiceTypeSale: 33,
    Initialization: function () {
        _set_service_ws_detail.DynamicBindInput()
        $('.service-ws-detail-change-tab-button').click()
        switch ($('#service-ws-detail-data').attr('data-status')) {
            case '1':
            case '2': {
                _set_service_ws_detail.ShowNeedToOrderTab()

            } break;
            case '3':
            case '4': {
                _set_service_ws_detail.ShowPaymentTab()

            } break;
            default: {
                _set_service_ws_detail.ShowOrderTab()

            } break;
        }
        $("body").on('click', ".service-code-send-email2", function (ev, picker) {
            _set_service_ws_detail.PopupSendEmailSupplier()

        });
    },
    DynamicBindInput: function () {
        $('body').on('click', '.service-ws-detail-change-tab-button', function (event) {
            var element = $(this)
            switch (element.attr('data-tab-id')) {
                case '0': {
                    _set_service_ws_detail.ShowOrderTab()

                } break;
                case '1': {
                    _set_service_ws_detail.ShowNeedToOrderTab()

                } break;
                case '2': {
                    _set_service_ws_detail.ShowOrderedTab()

                } break;
                case '3': {
                    _set_service_ws_detail.ShowPaymentTab()

                } break;
                case '4': {
                    _set_service_ws_detail.ShowServiceCodeTab()

                } break;
                case '5': {
                    _set_service_ws_detail.ShowRefundTab()

                } break;
            }

        });
    },
    Back: function () {
        window.location.href = '/SetService/watersports';
    },
  
    ShowOrderTab: function () {
        $('.service-ws-detail-change-tab-button').removeClass('active')
        $('.service-ws-detail-button-order').addClass('active')
        $('.service-ws-detail-tab').hide()
        $('.service-ws-detail-tab-order').show()
        if ($('.service-ws-detail-button-order').attr('data-loaded').trim() == '0') {
            $.ajax({
                url: "/SetService/ListOrder",
                type: "Post",
                data: { id: $('#service-ws-detail-data').attr('data-order-id') },
                success: function (result) {
                    $('.service-ws-detail-tab-order').html(result);
                    $('.service-ws-detail-button-order').attr('data-loaded', '1')

                }
            });
        }
    },
    ShowNeedToOrderTab: function () {
        $('.service-ws-detail-change-tab-button').removeClass('active')
        $('.service-ws-detail-button-need-to-order').addClass('active')
        $('.service-ws-detail-tab').hide()
        $('.service-ws-detail-tab-need-to-order').show()
        if ($('.service-ws-detail-button-need-to-order').attr('data-loaded').trim() == '0') {
            $.ajax({
                url: "/SetService/WSDetailBookingSale",
                type: "Post",
                data: {
                    id: $('#service-ws-detail-data').attr('data-booking-id')
                },
                success: function (result) {
                    $('.service-ws-detail-tab-need-to-order').html(result);
                    $('.service-ws-detail-button-need-to-order').attr('data-loaded', '1')
                    $(".service-watersport-service-type").select2();
                    $(".service-watersport-service-type").prop("disabled", true);
                    _global_function.RenderFileAttachment($('.attachment-sale'), $('#service-ws-detail-data').attr('data-booking-id'), _set_service_ws_detail.ServiceTypeSale, false, false)

                }
            });
        }
    },
    ShowOrderedTab: function () {
      
        $('.service-ws-detail-change-tab-button').removeClass('active')
        $('.service-ws-detail-button-ordered').addClass('active')
        $('.service-ws-detail-tab').hide()
        $('.service-ws-detail-tab-ordered').show()
        if ($('.service-ws-detail-button-ordered').attr('data-loaded').trim() == '0') {
            $.ajax({
                url: "/SetService/wsDetailBookingOperator",
                type: "Post",
                data: {
                    id: $('#service-ws-detail-data').attr('data-booking-id')
                },
                success: function (result) {
                    $('.service-ws-detail-tab-ordered').html(result);
                    $('.service-ws-detail-button-ordered').attr('data-loaded', '1')
                    $('.service-ws-ordered-suplier').each(function (index, item) {
                        var element = $(this);
                        _common_function_ws.Select2SupplierWithSearch(element)
                    });
                    _set_service_ws_detail.TabReCalucateTotalAmount()
                    _common_function_ws.Select2WithFixedOptionAndNoSearch($('.add-service-ws-select-service'))
                    $(".add-service-ws-select-service").prop("disabled", true);
                    _global_function.RenderFileAttachment($('.attachment-operator'), $('#service-ws-detail-data').attr('data-booking-id'), _set_service_ws_detail.ServiceType, true, false, true)
                    $('.service-ws-ordered-note').attr('disabled', 'disabled')
                    $('.service-ws-ordered-note').addClass('input-disabled-background')
                }
            });
        }
    },
    ShowPaymentTab: function () {
        $('.service-ws-detail-change-tab-button').removeClass('active')
        $('.service-ws-detail-button-payment').addClass('active')
        $('.service-ws-detail-tab').hide()
        $('.service-ws-detail-tab-payment').show()
        var serviceCode = $('#service-ws-detail-data').attr('data-servicecode')
        var status = $('#service-ws-detail-data').attr('data-status')
        if (status.trim() == '2') status='3'

        $.ajax({
            url: "/SetService/ListHotelBookingpayment",
            type: "Post",
            data: {
                HotelBookingID: $('#service-ws-detail-data').attr('data-booking-id'),
                serviceType: 9,
                supplierId: $('#suplier-detail').attr('data-suplier-id'),
                supplierName: $('#suplier-detail').attr('data-suplier-name'),
                orderId: $('#service-ws-detail-data').attr('data-order-id'),
                amount: $('#operator-order-amount').attr('data-amount'),
                HotelBookingstatus: status,
                serviceCode: $('#service-ws-detail-data').attr('data-servicecode')

            },
            success: function (result) {
                $('.service-ws-detail-tab-payment').html(result);
            }
        });
    },
    ReloadPaymentTab: function () {
        var status = $('#service-ws-detail-data').attr('data-status')
        if (status.trim() == '2') status = '3'
        $.ajax({
            url: "/SetService/ListHotelBookingpayment",
            type: "Post",
            data: {
                HotelBookingID: $('#service-ws-detail-data').attr('data-booking-id'),
                serviceType: 9,
                supplierId: $('#suplier-detail').attr('data-suplier-id'),
                supplierName: $('#suplier-detail').attr('data-suplier-name'),
                orderId: $('#service-ws-detail-data').attr('data-order-id'),
                amount: $('#operator-order-amount').attr('data-amount'),
                HotelBookingstatus: status,
                serviceCode: $('#service-ws-detail-data').attr('data-servicecode')

            },
            success: function (result) {
                $('.service-ws-detail-tab-payment').html(result);
            }
        });
    },
    ShowServiceCodeTab: function () {
      
    },
    ShowRefundTab: function () {
        $('.service-ws-detail-change-tab-button').removeClass('active')
        $('.service-ws-detail-button-refund').addClass('active')
        $('.service-ws-detail-tab').hide()
        $('.service-ws-detail-tab-refund').show()

        $.ajax({
            url: "/SetService/ListPaymentRequestByClient",
            type: "Post",
            data: {
                clientId: $('#service-ws-detail-data').attr('data-clientid'),
                bookingId: $('#service-ws-detail-data').attr('data-booking-id'),
                amount: $('#service-ws-detail-data').attr('data-amount'),
                orderId: $('#service-ws-detail-data').attr('data-orderid'),
                bookingstatus: $('#service-ws-detail-data').attr('data-status'),
                serviceType: 9,
                serviceCode: $('#service-ws-detail-data').attr('data-servicecode')
            },
            success: function (result) {
                $('.service-ws-detail-tab-refund').html(result);

            }
        });
    },
    wsDetailBookingOrderedInitialization: function () {

        _set_service_ws_detail.TabReCalucateTotalAmount()
        _set_service_ws_detail.TabServiceOrderedDynamicBind()
        _common_function_ws.Select2SupplierWithSearch($('.service-ws-ordered-suplier'))
        $('.service-ws-ordered-summary-row').find('td').eq(1).html('<a href="javascript:;" class="blue ml-2 mb10 service-ws-ordered-add-new-disabled service-ws-ordered-add-new" style="display:none;"><i class="fa fa-plus-circle green"></i> Thêm dòng</a>')
        $('.service-ws-ordered-summary-row').find('td').eq(5).css('text-align', 'right')
        $('.service-ws-ordered-summary-row').find('td').eq(5).addClass('service-ws-ordered-total-amount')
    },
    TabServiceOrderedDynamicBind: function () {
        /*
        $("body").on('keyup', ".service-ws-packages-unit-price", function () {
            _set_service_ws_detail.TabReCalucateTotalAmount()

        });*/
        $("body").on('keyup', ".service-ws-packages-baseprice-operator, .service-ws-packages-quantity ", function () {
            var element = $(this)
            var row_element = element.closest('.service-ws-ordered-row')
            _set_service_ws_detail.CalucateRowAmount(row_element)
            _set_service_ws_detail.TabReCalucateTotalAmount()

        });
        $("body").on('click', ".service-ws-ordered-delete-row", function () {
            var element = $(this)
            var row_element = element.closest('.service-ws-ordered-row')
            row_element.remove()
            _set_service_ws_detail.TabReCalucateTotalAmount()
            _set_service_ws_detail.ReIndexPackages()

        });
        $("body").on('click', ".service-ws-ordered-add-new", function () {
            _set_service_ws_detail.AddNewOrderedExtraPackage()
        });
        $("body").on('click', ".update-operator-order-amount", function () {
            $('.service-ws-ordered-package-name').removeAttr('disabled')
            $('.service-ws-ordered-package-name').removeClass('input-disabled-background')
            $('.service-ws-ordered-suplier').removeAttr('disabled')
            $('.service-ws-ordered-suplier').removeClass('input-disabled-background')

            $('.service-ws-packages-baseprice-operator').removeAttr('disabled')
            $('.service-ws-packages-baseprice-operator').removeClass('input-disabled-background')
            $('.service-ws-packages-quantity').removeAttr('disabled')
            $('.service-ws-packages-quantity').removeClass('input-disabled-background')

            $('.service-ws-ordered-note').removeAttr('disabled')
            $('.service-ws-ordered-note').removeClass('input-disabled-background')
            $('.service-ws-ordered-note').css('background','')
            $('.service-ws-ordered-delete-row').show()
            $('.service-ws-ordered-add-new').show()
            $('.update-operator-order-amount-save').show()
            $('.update-operator-order-amount-cancel').show()
            $('.update-operator-order-amount').hide()
        });
        $("body").on('click', ".update-operator-order-amount-save", function () {

            _set_service_ws_detail.UpdateOperatorPrice();


        });
        $("body").on('click', ".update-operator-order-amount-cancel", function () {
            $('.service-ws-detail-button-ordered').attr('data-loaded', '0')
            _set_service_ws_detail.ReloadOrderedTab();

        });
    },
    ReloadOrderedTab: function () {
        $("body").off('keyup', ".service-ws-extrapackage-amount",null);
        $("body").off('keyup', ".service-ws-ordered-delete-add-new", null);
        $("body").off('keyup', ".service-ws-ordered-delete-row", null);
        $("body").off('click', ".service-ws-ordered-add-new", null);
        $("body").off('click', ".update-operator-order-amount", null);
        $("body").off('click', ".update-operator-order-amount-save", null);
        $("body").off('click', ".update-operator-order-amount-cancel", null);
        $("body").on('keyup', ".service-ws-packages-baseprice-operator, .service-ws-packages-quantity ", null);
        _set_service_ws_detail.ShowOrderedTab()
        _set_service_ws_detail.ReloadPaymentTab()

    },
    ReIndexPackages: function () {
        var index = 0
        $('.service-ws-ordered-order').each(function (index, item) {
            var element = $(item);
            element.html(_global_function.Comma(++index))
        });
    },
    GetLastestSetServiceOrderedTable: function () {
        var last_order = 0;
        if (!$('.service-ws-ordered-order')[0]) return 0;
        //-- Get Lastest Order
        $('.service-ws-ordered-order').each(function (index, item) {
            last_order++
        });
        return last_order;
    },
    CalucateRowAmount: function (row_element) {
        var base_price_val = row_element.find('.service-ws-packages-baseprice-operator').val().replaceAll(',', '')
        var quantity_val = row_element.find('.service-ws-packages-quantity').val().replaceAll(',', '')
        var base_price = (base_price_val == undefined ? 0 : parseFloat(base_price_val))
        var quantity = (quantity_val == undefined ?0 : parseInt(quantity_val))
        var total = base_price * quantity
        row_element.find('.service-ws-packages-unit-price').val(_global_function.Comma(total));
        row_element.find('.service-ws-packages-unit-price').attr('data-amount', total);

    },
    TabReCalucateTotalAmount: function () {
        var total = 0;
        $('.service-ws-packages-unit-price').each(function (index, item) {
            var element = $(this);
            if (element.val() != undefined && element.val().trim() != '') {
                total += parseFloat(element.val().replaceAll(',', ''))
            }

        });
        $('.service-ws-ordered-total-amount').html('' + _global_function.Comma(total));
        $('.service-ws-ordered-total-amount').attr('data-amount', total);
       
    },
    AddNewOrderedExtraPackage: function () {
        var lastest_order = _set_service_ws_detail.GetLastestSetServiceOrderedTable()
        var code = _set_service_ws_detail.GenerateNewPackageOptionalCode()
        var html_append = _set_service_ws_html.html_ordered_new_packages.replaceAll('@(++index)', ('' + (lastest_order + 1))).replaceAll('@item.PackageName', code)
        $('.service-ws-ordered-summary-row').before(html_append)
        _set_service_ws_detail.ReIndexPackages()
        _common_function_ws.Select2SupplierWithSearch($('.service-ws-ordered-suplier-new'))
        $('.service-ws-ordered-suplier-new').removeClass('service-ws-ordered-suplier-new')
    },
    GenerateNewPackageOptionalCode: function () {
        var code = ''
        var list_exists = []
        var count = 0
        $('.service-ws-ordered-package-name').each(function (index, item) {
            var element = $(item)
            count++
            list_exists.push(element.text().trim())
        });
        var service_code = $('.set-service-ws-packages-optional-tbody').attr('data-code')
        var no_duplicate = true
        for (var i = (count + 1); i < 300; i++) {
            code = service_code + '-' + i
            no_duplicate = true
            $('.service-ws-ordered-package-name').each(function (index, item) {
                var element = $(item)
                if (element.text().trim() == code.trim()) {
                    no_duplicate = false
                    return false
                }
            });
            if (no_duplicate) break;
        }
        if (no_duplicate) return code
        else {
            return ''
        }
    },
    PopupChangeOperator: function (operator_name) {
        if ($('#change_operator_popup').length) {
            $('#change_operator_popup').removeClass('show')
            setTimeout(function () {
                $('#change_operator_popup').remove();
            }, 300);

        }
        $.ajax({
            url: "/SetService/wsDetailBookingChangeOperator",
            type: "post",
            data: {
                operator_name: operator_name,
                booking_id: $('#service-ws-detail-data').attr('data-booking-id')
            },
            success: function (result) {
                $('body').append(result);
                setTimeout(function () {
                    $('#change_operator_popup').addClass('show')
                }, 300);

            }
        });
    },
    PopupChangeOperatorInit: function () {
        _set_service_ws_detail.UserSuggesstionMultiple($('.service-ws-change-operator'))
    },
    PopupChangeOperatorClose: function () {
        $('#change_operator_popup').removeClass('show')
        setTimeout(function () {
            $('#change_operator_popup').remove();
        }, 300);
    },
    ChangeServiceOperator: function () {
        var operator_id = $('.service-ws-change-operator option:selected').val()
        if (operator_id == undefined || operator_id.trim() == '') {
            _msgalert.error('Vui lòng chọn điều hành viên mới')
            return
        }
        $.ajax({
            url: "/SetService/SummitwsDetailChangeOperator",
            type: "Post",
            data: {
                booking_id: $('.form-operator-change').attr('data-id'),
                user_id: operator_id
            },
            success: function (result) {
                if (result.status === 0) {
                    _msgalert.success(result.msg);
                    _set_service_ws_detail.PopupChangeOperatorClose()
                    setTimeout(function () {
                        window.location.reload();
                    }, 500)
                }
                else {
                    _msgalert.error(result.smg);

                }

            }
        });
    },
    UpdateOperatorPrice: function () {
        var obj_summit = []
        if (!$('.service-ws-ordered-row')[0]) {
            _msgalert.error('Vui lòng nhập ít nhất bản ghi dịch vụ tại bảng kê dịch vụ')
            return
        }
        var is_success = true
        $('.service-ws-ordered-row').each(function (index, item) {
            var element = $(item)
            var id = element.attr('data-id')
            var package_name = element.find('.service-ws-ordered-package-name').html()
            var suplier_id = element.find('.service-ws-ordered-suplier').find(':selected').val()
            var amount = element.find('.service-ws-packages-unit-price').val().replaceAll(',', '')
            var base_price = element.find('.service-ws-packages-baseprice-operator').val().replaceAll(',', '')
            var quantity = element.find('.service-ws-packages-quantity').val().replaceAll(',', '')
            if (isNaN(parseFloat(element.find('.service-ws-packages-unit-price').val().replaceAll(',', '')))) {
                _msgalert.error('Tổng thành tiền cho nhà cung cấp phải là số')
                is_success = false
                return false
            }
            if (suplier_id == undefined || suplier_id.trim() == '') {
                _msgalert.error('Vui lòng nhập & chọn thông tin nhà cung cấp')
                is_success = false

                return false
            }
            var note = element.find('.service-ws-ordered-note').val()
            var go_id = $('.set-service-ws-packages-optional-tbody').attr('data-go-id')
            var item_push = {
                Id: id,
                BookingId: go_id,
                SuplierId: suplier_id,
                Amount: amount,
                Note: note,
                PackageName: package_name,
                BasePrice: base_price == undefined ? amount : base_price,
                Quantity: quantity == undefined ? '1' : quantity
            }
            obj_summit.push(item_push)
        });
        if (!is_success) return;
        $.ajax({
            url: "/SetService/UpdatewsOperatorOrderPrice",
            type: "post",
            data: { data: obj_summit },
            success: function (result) {
                if (result != undefined && result.status == 0) {
                    _msgalert.success(result.msg)
                    $('#operator-order-amount').html(':  ' + _global_function.Comma(result.amount))
                    $('#operator-order-amount').attr('data-amount', result.amount)
                    $('#operator-total-profit').html(':  ' + _global_function.Comma(result.profit))

                    $('.service-ws-ordered-package-name').attr('disabled', 'disabled')
                    $('.service-ws-ordered-package-name').addClass('input-disabled-background')
                    $('.service-ws-ordered-suplier').attr('disabled', 'disabled')
                    $('.service-ws-ordered-suplier').addClass('input-disabled-background')
                    $('.service-ws-packages-unit-price').attr('disabled', 'disabled')
                    $('.service-ws-packages-unit-price').addClass('input-disabled-background')
                    $('.service-ws-packages-baseprice-operator').attr('disabled', 'disabled')
                    $('.service-ws-packages-baseprice-operator').addClass('input-disabled-background')
                    $('.service-ws-packages-quantity').attr('disabled', 'disabled')
                    $('.service-ws-packages-quantity').addClass('input-disabled-background')
                    $('.service-ws-ordered-note').attr('disabled', 'disabled')
                    $('.service-ws-ordered-note').addClass('input-disabled-background')
                    $('.service-ws-ordered-delete-row').hide()
                    $('.service-ws-ordered-add-new').hide()
                    $('.update-operator-order-amount-save').hide()
                    $('.update-operator-order-amount-cancel').hide()
                    $('.update-operator-order-amount').show()
                    _set_service_ws_detail.ReloadOrderedTab();
                    _set_service_ws_detail.wsDetailBookingOrderedInitialization();

                }
                else {
                    _msgalert.error(result.msg)

                }

            }
        });
    },
    UserSuggesstionMultiple: function (element) {
        var selected = element.find(':selected').val()
        var placeholder = element.attr('placeholder')
        $.ajax({
            url: "/Order/UserSuggestion",
            type: "post",
            data: { txt_search: "" },
            success: function (result) {
                if (result != undefined && result.data != undefined && result.data.length > 0) {
                    result.data.forEach(function (item) {
                        element.append(_set_service_ws_html.html_user_option.replaceAll('{user_id}', item.id).replace('{user_email}', item.email).replace('{user_name}', item.username).replace('{user_phone}', item.phone == undefined ? "" : ' - ' + item.phone))

                    });
                    element.val(selected).trigger('change');
                }
                else {
                    element.trigger('change');

                }
                element.select2({
                    placeholder: placeholder,
                    allowClear: true
                });
            }
        });
    },
    GrantOrderPermission: function (element) {
        element.attr('disabled', true)
        var booking_id = $('#service-ws-detail-data').attr('data-booking-id')
        var service_code = $('#service-ws-detail-data').attr('data-servicecode')
        _msgconfirm.openDialog(_set_service_ws_html.confirm_box_title_grant_order, _set_service_ws_html.confirm_box_description_grant_order.replace('{Mã dịch vụ}', service_code), function () {
            $.ajax({
                url: "/SetService/GrantwsServiceOrderPermission",
                type: "post",
                data: { booking_id: booking_id },
                success: function (result) {
                    if (result != undefined && result.status == 0) {
                        _msgalert.success(result.msg);
                        setTimeout(function () { window.location.reload() }, 500)
                    }
                    else {
                        _msgalert.error(result.msg);
                    }

                }
            });

        });
        element.attr('disabled', false)
    },
    SendServiceCode: function (element) {
        element.attr('disabled', true)
        var booking_id = $('#service-ws-detail-data').attr('data-booking-id')
        var service_code = $('#service-ws-detail-data').attr('data-servicecode')
        _msgconfirm.openDialog(_set_service_ws_html.confirm_box_title_send_service_code, _set_service_ws_html.confirm_box_description_send_service_code.replace('{Mã dịch vụ}', service_code), function () {
            $.ajax({
                url: "/SetService/wsServiceSendServiceCode",
                type: "post",
                data: { booking_id: booking_id },
                success: function (result) {
                    if (result != undefined && result.status == 0) {
                        _msgalert.success(result.msg);
                        setTimeout(function () { window.location.reload() }, 500)

                    }
                    else {
                        _msgalert.error(result.msg);
                        element.removeAttr('disabled');
                    }

                }
            });
        });
        element.removeAttr('disabled');

    },
    ChangeToPayment: function (element) {
        element.attr('disabled', true)
        var booking_id = $('#service-ws-detail-data').attr('data-booking-id')
        var service_code = $('#service-ws-detail-data').attr('data-servicecode')
        _msgconfirm.openDialog(_set_service_ws_html.confirm_box_title_change_to_payment, _set_service_ws_html.confirm_box_description_change_to_payment.replace('{Mã dịch vụ}', service_code), function () {
            $.ajax({
                url: "/SetService/wsServiceChangeToConfirmPaymentStatus",
                type: "post",
                data: { booking_id: booking_id },
                success: function (result) {
                    if (result != undefined && result.status == 0) {
                        _msgalert.success(result.msg);
                        setTimeout(function () { window.location.reload() }, 500)

                    }
                    else {
                        _msgalert.error(result.msg);
                        element.removeAttr('disabled');

                    }
                }
            });
        });
        element.removeAttr('disabled');

    },
    PopupSendEmailSupplier: function () {
        let title = 'Gửi Email nhà cung cấp';
        let url = '/SetService/SendEmailSupplier';
        let param = {
            id: $('#service-ws-detail-data').attr('data-booking-id').trim(),
            Orderid: $('#service-ws-detail-data').attr('data-order-id').trim(),
            type: 8,
            SupplierId: 0,
            ServiceType: 9,
        };
        _magnific.OpenSmallPopup(title, url, param);

    },
}
var _common_function_ws = {

    
    OrderNoSuggesstion: function (element) {

        element.select2({
            theme: 'bootstrap4',
            placeholder: "Mã đơn hàng",
            minimumInputLength: 1,
            allowClear: true,
            tags: true,
            ajax: {
                url: "/SetService/OrderSuggestion",
                type: "post",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    var query = {
                        txt_search: params.term,
                    }
                    return query;
                },
                processResults: function (response) {
                    return {
                        results: $.map(response.data, function (item) {
                            return {
                                text: item.orderno,
                                id: item.orderno,
                            }
                        })
                    };
                },
                createTag: function (params) {
                    let term = $.trim(params.term);
                    return {
                        id: term,
                        text: term,
                        newTag: true,
                    }
                },
                cache: true
            }
        });
    },

    ServiceCodeSuggesstion: function (element) {
        element.select2({
            theme: 'bootstrap4',
            placeholder: "Mã dịch vụ",
            minimumInputLength: 1,
            allowClear: true,
            ajax: {
                url: "/SetService/wsServiceCodeSuggestion",
                type: "post",
                dataType: 'json',
                delay: 1000,
                tags: true,
                data: function (params) {
                    var query = {
                        txt_search: params.term,
                    }
                    return query;
                },
                processResults: function (response) {
                    return {
                        results: $.map(response.data, function (item) {
                            return {
                                text: item.serviceCode,
                                id: item.serviceCode,
                            }
                        })
                    };
                },

                createTag: function (params) {
                    let term = $.trim(params.term);
                    return {
                        id: term,
                        text: term,
                        newTag: true,
                    }
                },
                cache: true
            }
        });

    },
    UserSuggesstionMultiple: function (element) {
        var selected = element.find(':selected').val()
        var placeholder = element.attr('placeholder')
        $.ajax({
            url: "/Order/UserSuggestion",
            type: "post",
            data: { txt_search: "" },
            success: function (result) {
                if (result != undefined && result.data != undefined && result.data.length > 0) {
                    result.data.forEach(function (item) {
                        element.append(_set_service_ws_html.html_user_option.replaceAll('{user_id}', item.id).replace('{user_email}', item.email).replace('{user_name}', item.username).replace('{user_phone}', item.phone == undefined ? "" : ' - ' + item.phone))

                    });
                    element.val(selected).trigger('change');
                }
                else {
                    element.trigger('change');

                }
                element.select2({
                    placeholder: placeholder,
                    allowClear: true
                });
            }
        });
    },
    Select2FixedOptionWithAddNew: function (element) {
        element.select2({
            tags: true,

            createTag: function (params) {
                var term = $.trim(params.term);

                if (term === '') {
                    return null;
                }

                return {
                    id: term,
                    text: term,
                }
            }
        });
    },
    Select2WithFixedOptionAndNoSearch: function (element) {
        var placeholder = element.attr('placeholder')
        element.select2({
            placeholder: placeholder,
            allowClear: true,
            minimumResultsForSearch: Infinity
        });
    },
    SingleDateRangePicker: function (element) {

        var today = new Date();
        var yyyy = today.getFullYear();
        var yyyy_max = yyyy + 10;
        var current_date = element.val();
        var min_range = '01/01/2020';
        var max_range = '31/12/' + yyyy_max;

        element.daterangepicker({
            autoApply: true,
            autoUpdateInput: false,
            showDropdowns: true,
            drops: 'down',
            minDate: min_range,
            maxDate: max_range,
            locale: {
                format: 'DD/MM/YYYY',
                cancelLabel: 'Clear'

            }
        }, function (start, end, label) {


        });

        //.data('daterangepicker').setStartDate(current_date);
    },
    OnApplyStartDateTimeOfBookingRange: function (start_date_element, end_date_element) {
        var today = new Date();

        var min_range = _global_function.GetDayTextDateRangePicker(start_date_element.data('daterangepicker').startDate._d);
        var yyyy = today.getFullYear();
        var yyyy_max = yyyy + 10;
        var max_range = '31/12/' + yyyy_max;
        end_date_element.daterangepicker({
            autoApply: true,
            autoUpdateInput: false,
            showDropdowns: true,
            drops: 'down',
            minDate: min_range,
            maxDate: max_range,
            locale: {
                format: 'DD/MM/YYYY',
                cancelLabel: 'Clear'

            }
        }, function (start, end, label) {


        });
    },
    Select2SupplierWithSearch: function (element) {
        var selected = element.find(':selected').val()
        var selected_text = element.find('option').text()
        if (selected != null && selected != undefined) {
            var s_ele = element.find('option');
            selected = s_ele.val()
            selected_text = s_ele.html()
        }
        element.select2({
            theme: 'bootstrap4',
            placeholder: "Tên NCC ",
            hintText: "Nhập từ khóa tìm kiếm",
            searchingText: "Đang tìm kiếm...",
            minimumInputLength: 0,
            ajax: {
                url: "/PaymentRequest/GetSuppliersSuggest",
                type: "post",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    var query = {
                        name: params.term,
                    }
                    return query;
                },
                processResults: function (response) {
                    return {
                        results: $.map(response, function (item) {
                            return {
                                text: item.id + ' - ' + item.fullname,
                                id: item.id,
                            }
                        })
                    };
                },
                cache: true
            }
        });
        if (selected != null && selected != undefined) {
            element.select2('data', { id: selected, text: selected_text });
        }
        else {
            element.val(selected).change()
        }

    },
    Select2BookingCode: function (element) {
        element.select2({
            theme: 'bootstrap4',
            placeholder: "Mã Code",

            allowClear: true,
            tags: true,
            ajax: {
                url: "/SetService/BookingCodeSuggestion",
                type: "post",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    var query = {
                        txt_search: params.term,
                        type: 9,
                    }
                    return query;
                },
                processResults: function (response) {
                    return {
                        results: $.map(response.data, function (item) {
                            return {
                                text: item.bookingcode,
                                id: item.bookingcode,
                            }
                        })
                    };
                },
                createTag: function (params) {
                    let term = $.trim(params.term);
                    return {
                        id: term,
                        text: term,
                        newTag: true,
                    }
                },
                cache: true
            }
        });
    },
}