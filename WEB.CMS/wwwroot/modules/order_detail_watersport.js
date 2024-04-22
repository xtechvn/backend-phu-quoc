var _order_detail_watersport = {
    ServiceType: 33,
    ServiceTypeList:[],
    Initialization: function (order_id, booking_id) {
        $('#watersportbooking-service').addClass('show')
        _order_detail_watersport.AddwatersportServicePackage(order_id, booking_id)
        _order_detail_common.SingleDatePicker($('.service-watersport-from-date'))
        _order_detail_common.UserSuggesstion($('.add-service-watersport-main-staff'))
        _order_detail_common.FileAttachment(booking_id, _order_detail_watersport.ServiceType)
       
        _order_detail_watersport.DynamicBind()
    },
    DynamicBind: function () {
        $('body').on('keyup', '.service-watersport-packages-baseprice, .service-watersport-packages-quantity', function () {
            var element = $(this)
            var row_element = element.closest('.service-watersport-packages-row')
            var table_element = element.closest('.service-watersport-packages-tbody')
            _order_detail_watersport.CalucateRowAmount(row_element)
            _order_detail_watersport.CalucateAmount(table_element)
            _order_detail_watersport.CalucateTotalServiceAmount()
            _order_detail_watersport.CalucateTotalServiceProfit()
        });
        $('body').on('keyup', '.servicemanual-watersport-others-amount, .servicemanual-watersport-commission', function () {
            
            _order_detail_watersport.CalucateTotalServiceAmount()
            _order_detail_watersport.CalucateTotalServiceProfit()
        });


        $('.service-watersport-note').keydown(function (e) {
            e.stopPropagation();
        });
    },
    RemoveDynamicBind: function () {
        $('body').off('keyup', '.service-watersport-packages-baseprice, .service-watersport-packages-quantity, .service-watersport-packages-profit', function () {

        });
        $('body').off('apply.daterangepicker', '.service-watersport-from-date', function () {

        });
        $('.service-watersport-note').keydown(null);
    },
    AddwatersportServicePackage: function (order_id, booking_id) {
        if (booking_id != undefined && !isNaN(parseInt(booking_id))) {
            $.ajax({
                url: "AddwatersportServicePackages",
                type: "post",
                data: { order_id: order_id, booking_id: booking_id },
                success: function (result) {
                    $('.service-watersport-packages').html(result)
                    _order_detail_watersport.WaterSportServiceTypeSuggesstion($('.service-watersport-service-type'))
                    _order_detail_watersport.CalucateTotalServiceAmount()
                    _order_detail_watersport.CalucateTotalServiceProfit()
                }
            });
        }

    },
    DeletewatersportBookingpackages: function (element) {
        var row_element = element.closest('.service-watersport-packages-row')
        var table_element = element.closest('.service-watersport-packages-tbody')

        row_element.remove()

        _order_detail_watersport.CalucateAmount(table_element)
        _order_detail_watersport.ReIndexPackages(table_element)
        _order_detail_watersport.CalucateTotalServiceAmount()
        _order_detail_watersport.CalucateTotalServiceProfit()
    },
    Summit: function () {
        var service_code = $('#add-service-watersport-form-select').attr('data-service-code')
        var from_date = _global_function.GetDayText($('.service-watersport-from-date').data('daterangepicker').startDate._d, true)
        var operator_id = $('.add-service-watersport-main-staff').find(':selected').val()
        var note = $('.service-watersport-note').val()
        if (operator_id == undefined || operator_id == null || operator_id.trim() == '') {
            _msgalert.error("Vui lòng chọn điều hành viên")
            return;
        }
        var pathname = window.location.pathname.split('/');

        var other_amount_element = $('#servicemanual-watersport-others-amount')
        var other_amount = other_amount_element.val() == undefined || isNaN(parseFloat(other_amount_element.val().replaceAll(',', ''))) ? 0 : parseFloat(other_amount_element.val().replaceAll(',', ''))

        var discount_element = $('#servicemanual-watersport-commission')
        var discount = discount_element.val() == undefined || isNaN(parseFloat(discount_element.val().replaceAll(',', ''))) ? 0 : parseFloat(discount_element.val().replaceAll(',', ''))

        var conf_no = $('.service-watersport-conf-no').val()
        var room_no = $('.service-watersport-room-no').val()
        var serial_no = $('.service-watersport-serial-no').val()
        var object_summit = {
            order_id: pathname[pathname.length - 1],
            id: $('#add-service-watersport-form-select').attr('data-id'),
            used_date: from_date,
            operator_id: operator_id,
            note: note,
            service_code: service_code,
            packages: [],
            others_amount: other_amount,
            commission: discount,
            conf_no: conf_no,
            room_no: room_no,
            serial_no: serial_no
        }
        var validate_failed = false
        $('.service-watersport-packages-row').each(function (index, item) {
            var extra_package_element = $(item);
            var service_type = extra_package_element.find('.service-watersport-service-type').find(':selected').val()

            var extra_package = {
                id: extra_package_element.attr('data-extra-package-id'),
                service_type: service_type,
                base_price: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-baseprice')),
                quantity: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-quantity')),
                amount: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-amount')),
                note: extra_package_element.find('.service-watersport-packages-note').val(),
                commission: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-commission'))
            }
            object_summit.packages.push(extra_package);
        });
        if (validate_failed) {
            return
        }
        var descriptiion = _order_detail_html.summit_confirmbox_create_watersport_service_description
        _msgconfirm.openDialog(_order_detail_html.summit_confirmbox_title, descriptiion, function () {
            $('.btn-summit-service-watersport').attr('disabled', 'disabled')
            $('.btn-summit-service-watersport').addClass('disabled')
            $.ajax({
                url: "SummitwatersportServicePackages",
                type: "post",
                data: { data: object_summit },
                success: function (result) {
                    if (result != undefined && result.status == 0) {
                        _msgalert.success(result.msg);
                        _order_detail_watersport.Close();
                        _global_function.ConfirmFileUpload($('.attachment-file-block'), result.data)
                        setTimeout(function () {
                            window.location.reload();
                        }, 300);
                    }
                    else {
                        _msgalert.error(result.msg);
                        $('.btn-summit-service-watersport').removeAttr('disabled')
                        $('.btn-summit-service-watersport').removeClass('disabled')
                    }
                }
            });
        });
    },
    Close: function () {
        $('#watersportbooking-service').removeClass('show')
        setTimeout(function () {
            $('#watersportbooking-service').remove();
            _order_detail_create_service.StartScrollingBody();
            _order_detail_watersport.RemoveDynamicBind();
        }, 300);
    },
    AddwatersportBookingpackages: function () {
        var table_element = $('.service-watersport-packages-tbody')
        var new_position = _order_detail_watersport.GetLastestPackagesNo() + 1;
        table_element.find('.service-watersport-packages-summary-row').before(_order_detail_html.html_service_watersport_new_packages.replaceAll('@(++index)', new_position))
        _order_detail_watersport.WaterSportServiceTypeSuggesstion($('.service-watersport-service-type-new'))
        $('.service-watersport-service-type-new').removeClass('service-watersport-service-type-new')
    },
    GetLastestPackagesNo: function () {
        var total = 0;
        $('.service-watersport-packages-row').each(function (index, item) {
            total++;
        });
        return total
    },
    ReIndexPackages: function (table_element) {
        var total = 0;
        if (!table_element.find('.service-watersport-packages-row')[0]) return;
        table_element.find('.service-watersport-packages-row').each(function (index, item) {
            var row_element = $(this);
            total++;
            row_element.find('.service-watersport-packages-order').html('' + total)
        });
    },
   
    CalucateAmount: function (table_element) {
        var total_amount = 0;

        table_element.find('.service-watersport-packages-amount').each(function (index, item) {
            var element = $(this);
            var amount = !isNaN(parseFloat(element.val().replaceAll(',', ''))) ? parseFloat(element.val().replaceAll(',', '')) : 0
            total_amount += amount
        });
        table_element.find('.service-watersport-packages-total-amount').html((total_amount >= 0 ? '' : '-') + _global_function.Comma(total_amount))
    },
    CalucateRowAmount: function (row_element) {
        var element_base_price = row_element.find('.service-watersport-packages-baseprice')
        var element_quanity = row_element.find('.service-watersport-packages-quantity')

        var base_price = !isNaN(parseFloat(element_base_price.val().replaceAll(',', ''))) && parseFloat(element_base_price.val().replaceAll(',', '')) > 0 ? parseFloat(element_base_price.val().replaceAll(',', '')) : 0
        var quanity = !isNaN(parseFloat(element_quanity.val().replaceAll(',', ''))) && parseFloat(element_quanity.val().replaceAll(',', '')) > 0 ? parseFloat(element_quanity.val().replaceAll(',', '')) : 0

        var element_amount = row_element.find('.service-watersport-packages-amount')

        var amount = base_price * quanity;
        var price = base_price * quanity;
        var profit = amount - price;

        var element_amount = row_element.find('.service-watersport-packages-amount')


        element_amount.val((amount >= 0 ? '' : '-') + _global_function.Comma(amount.toFixed(0))).change()
    },
    WaterSportServiceTypeSuggesstion: function (element) {
        _order_detail_watersport.GetServiceTypeList(function () {

            var html = _order_detail_html.html_hotel_option;
            var template = ''
            $(_order_detail_watersport.ServiceTypeList).each(function (index, item) {
                var if_selected = ''
                template += html.replaceAll('{if_selected}', '').replaceAll('{hotel_id}', item.codeValue).replaceAll('{name}', item.description)
            });

            element.each(function (index, item) {
                var element = $(this);
                var selected = element.find(':selected').val()
                element.html(template)
                _order_detail_common.Select2WithFixedOptionAndNoSearch(element)
                if (selected != null && selected != undefined) {
                    element.val(selected).trigger('change')
                }
            });

        })
      
    },
    GetServiceTypeList: function (callback) {
        if (_order_detail_watersport.ServiceTypeList.length <= 0) {
            $.ajax({
                url: "GetAllWaterSportType",
                type: "get",
                success: function (result) {
                    if (result.data != null && result.data != undefined) {
                        _order_detail_watersport.ServiceTypeList = result.data
                        callback()
                    }
                }
            })
        }
        else {
            callback()
        }
      
    },
    CalucateTotalServiceAmount: function () {
        var amount = $('.service-watersport-packages-total-amount').html()
        $('.servicemanual-watersport-total-service-amount').html(amount)
    },
    CalucateTotalServiceProfit: function () {
        var profit = _global_function.GetAmountFromHTMLElement( $('.service-watersport-packages-total-amount'))
        var other_amount = _global_function.GetAmountFromCurrencyInput($('.servicemanual-watersport-others-amount'))
        var discount = _global_function.GetAmountFromCurrencyInput($('.servicemanual-watersport-commission'))

        var total_profit = profit - discount - other_amount
        $('.servicemanual-watersport-service-profit').html((total_profit >= 0 ? '' : '-') + _global_function.Comma(total_profit)).change();
    },
}
