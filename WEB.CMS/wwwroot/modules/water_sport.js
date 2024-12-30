let listid = []
$(document).ready(function () {
    _water_sport.Init();
    $("#ClientId").select2({
        theme: 'bootstrap4',
        placeholder: "Chọn người đại diện",
        ajax: {
            url: "/WaterSport/ClientSuggestion",
            type: "post",
            dataType: 'json',
            delay: 250,
            tags: true,
            data: function (params) {
                var query = {
                    txt_search: params.term,
                    type: 2,
                }
                return query;
            },
            processResults: function (response) {
                return {
                    results: $.map(response.data, function (item) {
                        return {
                            text: (item.clientname + ' - ' + item.email + ' - ' + item.phone).trimEnd("-"),
                            id: item.id,
                        }
                    })
                };
            },
            cache: true
        }
    });
    $('body').on('click', '#grid_data  input', function () {
        var element = $(this)
        if (element.is(":checked") == true) {
            $('#Create_Order').removeAttr('disabled')
        } else {
            if ($('#grid_data  input:checked').length == 0)
                $('#Create_Order').attr('disabled', 'disabled')
        }
    });
    $("#RoomN").on('keyup', function (e) {
        if (e.key === 'Enter' || e.keyCode === 13) {
            _water_sport.SearchData()
        }
    });
    $("#UserName").on('keyup', function (e) {
        if (e.key === 'Enter' || e.keyCode === 13) {
            _water_sport.SearchData()
        }
    });

})
var _water_sport = {
    WSTypeList: [],
    Init: function () {
        var data = {
            ClientId: null,
            RoomNo: null,
            UserName: null,
            PageIndex: 1,
            PageSize: 20,

        }
        _water_sport.Search(data);
    },

    Search: function (input) {
        $.ajax({
            url: "/WaterSport/search",
            type: "post",
            data: input,
            success: function (result) {
                $('#grid_data').html(result);
            }
        });
        if ($('#grid_data  input:checked').length == 0)
            $('#Create_Order').attr('disabled', 'disabled')
    },
    SearchData: function () {
        var input = _water_sport.getParam();
        _water_sport.Search(input);
    },
    getParam: function () {
        var Clientid = $('#ClientId').select2("val");
        var data = {
            ClientId: null,
            RoomNo: $('#RoomN').val().trim(),
            UserName: $('#UserName').val().trim(),
            PageIndex: 1,
            PageSize: $("#selectPaggingOptions").find(':selected').val() == undefined ? 20 : $("#selectPaggingOptions").find(':selected').val(),

        }
        if (Clientid != null) {
            data.ClientId = Clientid

        }

        return data;
    },
    ImportWSExcel: function () {
        let title = 'Danh sách khách lưu trú tại khách sạn';
        let url = '/WaterSport/ImportWSExcel';
        let param = {};
        _magnific.OpenSmallPopup(title, url, param);
    },
    StopScrollingBody: function () {
        $('body').addClass('stop-scrolling');
    },
    WaterSportService: function () {
        var listid = []
        if ($('#add-service-watersport').length) {
            $('#add-service-watersport').removeClass('show')
            setTimeout(function () {
                $('#add-service-watersport').remove();
            }, 300);

        }
        $('#grid_data  input:checked').each(function (index, item) {
            var element = $(this)
            listid.push(element.val())
        });
        var Clientid = $('#ClientId').select2("val");
        if (listid.length > 1 && Clientid == null) {
            _msgalert.error("Bạn chưa chọn người đại diện")
            return false;
        }

        $.ajax({
            url: "AddWaterSportService",
            type: "post",
            data: {
                ListId: listid,
                Clientid: Clientid == null ? 0 : Clientid
            },
            success: function (result) {
                $('body').append(result);
                setTimeout(function () {
                    _water_sport.StopScrollingBody();
                    _order_detail_watersport.Initialization(0, 0);
                }, 300);

            }
        });
    },
    Summit: function () {
        var client_id = $('#ClientId_order').val();
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
        var amount_discount = $('.servicemanual-watersport-discount').val()
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
            serial_no: serial_no,
            discount: amount_discount,
        }
        var passenger = []
        var validate_failed = false
        $('.service-watersport-packages-row').each(function (index, item) {
            var extra_package_element = $(item);
            var service_type = extra_package_element.find('.service-watersport-service-type').find(':selected').val()
            var duration_type = extra_package_element.find('.service-watersport-type').find(':selected').val()
            var extra_package = {
                id: extra_package_element.attr('data-extra-package-id'),
                service_type: service_type,
                duration_type: parseFloat(duration_type),
                base_price: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-baseprice')),
                quantity: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-quantity')),
                amount: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-amount')),
                note: extra_package_element.find('.service-watersport-packages-note').val(),
                commission: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-commission')),
                discount: _global_function.GetAmountFromCurrencyInput(extra_package_element.find('.service-watersport-packages-discount'))
            }
            object_summit.packages.push(extra_package);
        });
        $('.ListPassenger-name-row').each(function (index, item) {
            var extra_ws_element = $(item);

            var name = extra_ws_element.find('.name').text();

            passenger.push(name);
        });
        if (validate_failed) {
            return
        }

        var descriptiion = _order_detail_html.summit_confirmbox_create_watersport_service_description
        _msgconfirm.openDialog(_order_detail_html.summit_confirmbox_title, descriptiion, function () {
            $('.btn-summit-service-watersport').attr('disabled', 'disabled')
            $('.btn-summit-service-watersport').addClass('disabled')
            _global_function.AddLoading()
            $.ajax({
                url: "/WaterSport/SummitwatersportServicePackages",
                type: "post",
                data: { data: object_summit, passenger: passenger, client_id: client_id },
                success: function (result) {
                    _global_function.RemoveLoading()
                    if (result != undefined && result.status == 0) {
                        _msgalert.success(result.msg);
                        _order_detail_watersport.Close();
                        _global_function.ConfirmFileUpload($('.attachment-file-block'), result.data)
                        setTimeout(function () {
                            window.location.href = "/Order/" + result.data;
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
    OnPaging: function (value) {
        var input = _water_sport.getParam();
        input.PageIndex = value;
        _water_sport.Search(input);
    },
    Close: function () {
        $('#watersportbooking-service').removeClass('show')
        $('body').removeClass('stop-scrolling')
        setTimeout(function () {
            $('#watersportbooking-service').remove();

            _order_detail_watersport.RemoveDynamicBind();
        }, 300);
    },
    RemoveDynamicBind: function () {
        $('body').off('keyup', '.service-watersport-packages-baseprice, .service-watersport-packages-quantity, .service-watersport-packages-profit', function () {

        });
        $('body').off('apply.daterangepicker', '.service-watersport-from-date', function () {

        });
        $('.service-watersport-note').keydown(null);
    },
    AddwatersportBookingpackages: function (id) {
        var check = false;
        var type = 1;
        $('.service-watersport-packages-tbody .service-watersport-packages-row').each(function (index, item) {
            var element = $(this);
            var service_type = element.find('.service-watersport-service-type').val()
            if (parseFloat(service_type) == parseFloat(id)) {
                type = element.find('.service-watersport-type').val()
            }
        })
        $('#watersportbooking-service .checkbox-service').each(function (index, item) {
            var element = $(this);
            if (element.is(":checked") == true && element.val() == id) {
                check = true;
            }
        });
        var price = 0;
        if (check == true) {
            if (parseFloat(type) == 0) { type = 1; }

            var table_element = $('.service-watersport-packages-tbody')
            var new_position = _order_detail_watersport.GetLastestPackagesNo() + 1;
            table_element.find('.service-watersport-packages-summary-row').before(_order_detail_html.html_service_watersport_new_packages.replaceAll('@(++index)', new_position).replaceAll('@(classname)', "Row-packages-" + id).replaceAll('{price-name}', id))
            _water_sport.WaterSportServiceTypeSuggesstion($('.service-watersport-service-type-new'), id)
            debugger
            $.ajax({
                url: "/WaterSport/GetPriceSportWaterPackage",
                type: "post",
                data: { id: id, type: parseFloat(type) },
                success: function (result) {
                    if (result != undefined && result.status == 0) {
                        price = result.price
                        $('.price-name-' + id).val(price)
                    } else {
                        $('.price-name-' + id).val(price)
                    }
                }
            });
            _water_sport.WaterSportTypeSuggesstionadd($('.service-watersport-type-new-' + id), id)
            $('.service-watersport-service-type-new').removeClass('service-watersport-service-type-new')
        } else {
            $('.Row-packages-' + id).remove()
        }

    },
    WaterSportServiceTypeSuggesstion: function (element, id) {
        _order_detail_watersport.GetServiceTypeList(function () {

            var html = _order_detail_html.html_hotel_option;
            var template = ''
            $(_order_detail_watersport.ServiceTypeList).each(function (index, item) {
                var if_selected = ''
                template += html.replaceAll('{if_selected}', '').replaceAll('{hotel_id}', item.codeValue).replaceAll('{name}', item.description)
            });

            element.each(function (index, item) {
                var element = $(this);
                var selected = id
                element.html(template)
                _order_detail_common.Select2WithFixedOptionAndNoSearch(element)
                if (selected != null && selected != undefined) {
                    element.val(selected).trigger('change')
                    element.attr('disabled', 'disabled')
                }
            });

        })

    },
    WaterSportTypeSuggesstionadd: function (element, id) {
        _water_sport.GetTypeList(function () {

            var html = _order_detail_html.html_hotel_option;
            var template = ''
            $(_water_sport.WSTypeList).each(function (index, item) {
                var if_selected = ''
                template += html.replaceAll('{if_selected}', '').replaceAll('{hotel_id}', item.codeValue).replaceAll('{name}', item.description)
            });

            element.html(template)

        }, id)

    },
    GetTypeList: function (callback, id) {

        $.ajax({
            url: "/WaterSport/WaterSportTypeSuggesstion",
            type: "POST",
            data: { id: id },
            success: function (result) {
                if (result.data != null && result.data != undefined) {
                    _water_sport.WSTypeList = result.data
                    callback()
                } else {
                    callback()
                }
            }
        })
    },
  
}