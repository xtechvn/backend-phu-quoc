var _report_ws_search = {
    searchModel: {
        FromDate: null,
        ToDate: null,
        ClientIds: null,
        ServiceType: null,
        VAT: null
    },
    MainLoading: false
}
var _report_ws = {
    Initialization: function () {
        $('.from-date').val('01/01/2024');
        var today = new Date();
        var yyyy = today.getFullYear();
        var mm = today.getMonth() + 1;
        var dd = today.getDate();
        $('.to-date').val(dd+'/'+mm+'/'+yyyy);
        _report_ws.SingleDateTimePicker($('.from-date'))
        _report_ws.SingleDateTimePicker($('.to-date'))
       
        $('.select-btn-service-type').click(function () {
            var element = $(this)
            if (element.hasClass('open')) {
                element.removeClass('open')
            } else {
                element.addClass('open')
            }
        });
        $('.item-service-type').click(function () {
            var element = $(this)
            if (element.hasClass('checked')) {
                element.removeClass('checked')
            } else {
                element.addClass('checked')
            }
            var count=0
            $('.item-service-type').each(function (index, item) {
                var element = $(this)
                if (element.hasClass('checked')) {
                    count++;
                }
               
            });
            if (count <= 0) {
                $('.text-service-type').html('Tất cả sản phẩm')
            } else {
                $('.text-service-type').html('0' + count + ' loại sản phẩm')
            }
        });
        
        _report_ws.GetFilter()
        _report_ws.Search()
    },
    GetFilter: function () {
        var service_type_text=''
        $('.item-service-type').each(function (index, item) {
            var element = $(this)
            if (element.hasClass('checked')) {
                if (service_type_text == '') {
                    service_type_text = element.attr('data-value')
                }
                else {
                    service_type_text += ',' + element.attr('data-value')
                }
            } 
        });
        _report_ws_search.searchModel = {
            FromDate: _global_function.GetDayText($('#from-date').data('daterangepicker').startDate._d, true),
            ToDate: _global_function.GetDayText($('#to-date').data('daterangepicker').startDate._d, true),
            ClientIds: $('#filter-client').find(':selected').val(),
            ServiceType: service_type_text,
            VAT: $('#vat-value').find(':selected').val(),
            
        }
    },
    SearchData: function () {
        _report_ws.GetFilter()
        _report_ws.Search()
    },
    Search: function () {
        $('#imgLoading').show();

        $.ajax({
            url: "/ReportWS/Search",
            type: "post",
            data: _report_ws_search.searchModel,
            success: function (result) {
                $('#imgLoading').hide();
                $('#grid-data').html(result);
                $('#grid-data').show();
                if (!_report_ws_search.MainLoading) {
                    _report_ws_search.MainLoading = true
                    _report_ws.Loading()
                   
                }
            },
        });
    },
    Loading: function () {
        _report_ws.Select2WithFixedOptionAndNoSearch($('.vat-value'))
        _report_ws.ClientSuggesstion($("#filter-client"))
        $(document).click(function (event) {
            if ($(event.target).closest('.multiple-select').length == 0) {
                $('.multiple-select').find(".select-btn-service-type").removeClass('open');

            }
        });
       
        $("body").on('click', ".reset-client-input", function (ev, picker) {
            $("#filter-client").val(null).trigger('change')
            $('.reset-client-input').hide()

        })
        $("#filter-client").on("select2:select", function (e) {
            $('.reset-client-input').show()

        });
    },
    Select2WithFixedOptionAndSearch: function (element) {
        var placeholder = element.attr('placeholder')
        element.select2({
            placeholder: placeholder
        });
    },
    Select2WithFixedOptionAndNoSearch: function (element) {
        element.select2({
            minimumResultsForSearch: Infinity
        });
    },
    SingleDateTimePicker: function (element) {

        var today = new Date();
        var yyyy = today.getFullYear();
        var yyyy_max = yyyy + 10;
        var current_date = element.val();
        var min_range = '01/01/2020 00:00';
        var max_range = '31/12/' + yyyy_max + ' 23:59';
        var mm = today.getMonth() + 1; // Months start at 0!
        var dd = today.getDate();
        var hh = today.getHours();
        var minutes = today.getMinutes()
        if (current_date == undefined || current_date == null || current_date.trim() == '') {
            current_date = dd + '/' + mm + '/' + yyyy + ' ' + hh + ':' + minutes
        }

        element.daterangepicker({
            singleDatePicker: true,
            autoApply: true,
            showDropdowns: true,
            drops: 'down',
            minDate: min_range,
            maxDate: max_range,
            locale: {
                format: 'DD/MM/YYYY'
            }
        }, function (start, end, label) {


        });
        element.data('daterangepicker').setStartDate(current_date);
    },
    ClientSuggesstion: function (element) {
        element.select2({
            theme: 'bootstrap4',
            placeholder: "Thông tin khách hàng",
            maximumSelectionLength: 1,
            ajax: {
                url: "/Contract/ClientSuggestion",
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
                                text: item.clientname + ' - ' + item.email + ' - ' + item.phone,
                                id: item.id,
                            }
                        })
                    };
                },
                cache: true
            }
        });

    },
    Export: function (date) {
        _report_ws.GetFilter()
        _global_function.AddLoading()
        $('#operator-export-btn').prop('disabled', true);
        $('#operator-export').removeClass('fa-file-excel-o');
        $('#operator-export').addClass('fa-spinner fa-pulse');
        var date_used = _global_function.GetDateFromVNDateTimeSlash(date)
        var date_end = new Date(date_used.getFullYear(), date_used.getMonth(), date_used.getDate(), 23, 59, 59)
        var search_model_detail = _report_ws_search;
        search_model_detail.searchModel.FromDate = date_used.toLocaleDateString("en-US")
        search_model_detail.searchModel.ToDate = date_end.toLocaleDateString("en-US")
        $.ajax({
            url: "/ReportWS/ExportExcel",
            type: "post",
            data: search_model_detail,
            success: function (result) {
                _global_function.RemoveLoading()
                $('#operator-export').removeClass('fa-spinner fa-pulse');
                $('#operator-export').addClass('fa-file-excel-o');
                $('#operator-export-btn').prop('disabled', false);
                if (result.status == 0) {
                    _msgalert.success(result.msg);
                    window.location.href = result.path;
                } else {
                    _msgalert.error(result.msg);
                }

            },
        });
    },
    ExportTotal: function () {
        _report_ws.GetFilter()
        _global_function.AddLoading()
        $('#operator-export-btn').prop('disabled', true);
        $('#operator-export').removeClass('fa-file-excel-o');
        $('#operator-export').addClass('fa-spinner fa-pulse');

        $.ajax({
            url: "/ReportWS/ExportTotal",
            type: "post",
            data: _report_ws_search.searchModel,
            success: function (result) {
                _global_function.RemoveLoading()
                $('#operator-export').removeClass('fa-spinner fa-pulse');
                $('#operator-export').addClass('fa-file-excel-o');
                $('#operator-export-btn').prop('disabled', false);
                if (result.status == 0) {
                    _msgalert.success(result.msg);
                    window.location.href = result.path;
                } else {
                    _msgalert.error(result.msg);
                }

            },
        });
    },
    Detail: function (element) {
        var date = element.attr('data-date')
        var date_used = _global_function.GetDateFromVNDateTimeSlash(element.attr('data-date'))
        var date_end = new Date(date_used.getFullYear(), date_used.getMonth(), date_used.getDate(), 23, 59, 59)
        var search_model_detail = _report_ws_search;
        search_model_detail.searchModel.FromDate = date_used.toLocaleDateString("en-US")
        search_model_detail.searchModel.ToDate = date_end.toLocaleDateString("en-US")
        let title = `Chi tiết dịch vụ thể thao biển ngày ` + element.attr('data-date')
            + `  <button class="btn btn-default" type="button" onclick="_report_ws.Export('` + element.attr('data-date') +`')" id="operator-export-btn">
                    <i class="fa fa-file-excel-o" id="operator-export" title="Xuất excel">
                    </i>
                </button>`;
        let url = '/ReportWS/Detail';
        let param = search_model_detail
        _magnific.OpenSmallPopup(title, url, param);
    }
}