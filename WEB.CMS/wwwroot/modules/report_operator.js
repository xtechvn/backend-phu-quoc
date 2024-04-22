var report_operator_search_object = {
    searchModel: {
        FromDate:null,
        ToDate:null,
        StartDateFrom:null,
        StartDateTo:null,
        EndDateFrom:null,
        EndDateTo:null,
        OrderStatus:null,
        InvoiceStatus:null,
        ExportDateFrom:null,
        ExportDateTo:null,
        SalerId: null,
        SalerPermission: null,
        DepartmentId:null
    }
}
var _report_operator_loading = {
    MainLoading: false,

}

var _report_operator = {
    Initialization: function () {
        $("body").off('click', ".list-expand", null);

        if (!_report_operator_loading.MainLoading) {
            _report_operator.Select2WithFixedOptionAndNoSearch($('#operator-order-finish-status'))
            _report_operator.Select2WithFixedOptionAndNoSearch($('#operator-invoice-finish-status'))
            _report_operator.Select2WithFixedOptionAndNoSearch($('#operator-invoice-finish-status'))
            _report_operator.Select2WithFixedOptionAndNoSearch($('#operator-invoice-finish-status'))
            _report_operator.Select2WithFixedOptionAndNoSearch($('#operator-branch-code'))
            _report_operator.Select2WithFixedOptionAndSearch($('#operator-departmentid'))


            var today = new Date();
            var yyyy = today.getFullYear();
            var mm = today.getMonth() + 1; // Months start at 0!
            var dd = today.getDate();
            if (dd < 10) dd = '0' + dd;
            if (mm < 10) mm = '0' + mm;
            var min_range = '01/01/2020';
            var max_range = dd + '/' + mm + '/' + yyyy;
            var max_range_available = '31/12/2028';

            $('.date-operator').each(function (index, item) {
                var element = $(item)
                element.daterangepicker({
                    autoApply: true,
                    autoUpdateInput: false,
                    showDropdowns: true,
                    drops: 'down',
                    minDate: min_range,
                    maxDate: max_range,
                    locale: {
                        format: 'DD/MM/YYYY'
                    }
                });
                element.data('daterangepicker').setStartDate(min_range);
                element.data('daterangepicker').setEndDate(max_range);
            })
          
            $('#operator-from-date').each(function (index, item) {
                var element = $(item)
                element.daterangepicker({
                    autoApply: true,
                    autoUpdateInput: false,
                    showDropdowns: true,
                    drops: 'down',
                    minDate: min_range,
                    maxDate: max_range_available,
                    locale: {
                        format: 'DD/MM/YYYY'
                    }
                });
                element.data('daterangepicker').setStartDate(min_range);
                element.data('daterangepicker').setEndDate(max_range_available);
            })
            $('#operator-to-date').each(function (index, item) {
                var element = $(item)
                element.daterangepicker({
                    autoApply: true,
                    autoUpdateInput: false,
                    showDropdowns: true,
                    drops: 'down',
                    minDate: min_range,
                    maxDate: max_range_available,
                    locale: {
                        format: 'DD/MM/YYYY'
                    }
                });
                element.data('daterangepicker').setStartDate(min_range);
                element.data('daterangepicker').setEndDate(max_range_available);
            })
            $('#operator-invoice-finish-status').each(function (index, item) {
                var element = $(item)
                element.daterangepicker({
                    autoApply: true,
                    autoUpdateInput: false,
                    showDropdowns: true,
                    drops: 'down',
                    minDate: min_range,
                    maxDate: max_range_available,
                    locale: {
                        format: 'DD/MM/YYYY'
                    }
                });
                element.data('daterangepicker').setStartDate(min_range);
                element.data('daterangepicker').setEndDate(max_range_available);
            })
            $("body").on('apply.daterangepicker', ".date-operator", function (ev, picker) {
                var element = $(this)
                element.val(_global_function.GetDayText(element.data('daterangepicker').startDate._d).split(' ')[0] + ' - ' + _global_function.GetDayText(element.data('daterangepicker').endDate._d).split(' ')[0])

            });

            $("#operator-saler").select2({
                theme: 'bootstrap4',
                placeholder: "Phụ trách chính",
                hintText: "Nhập từ khóa tìm kiếm",
                searchingText: "Đang tìm kiếm...",
                ajax: {
                    url: "/Order/UserSuggestion",
                    type: "post",
                    dataType: 'json',
                    delay: 250,
                    data: function (params) {
                        var query = {
                            txt_search: params.term,
                        }

                        // Query parameters will be ?search=[term]&type=public
                        return query;
                    },
                    processResults: function (response) {
                        return {
                            results: $.map(response.data, function (item) {
                                return {
                                    text: item.fullname + ' - ' + item.email,
                                    id: item.id,
                                }
                            })
                        };
                    },
                    cache: true
                }
            });
            $("body").on('click', ".list-expand", function (ev, picker) { 
                var element = $(this)
                var tr = element.closest('tr')
                var parent_department_value = tr.attr('data-parent-departmentid')
                if (element.find('i').hasClass('fa-plus')) {
                    $('.table-report').find('.expand-item').each(function (index, item) {
                        var tr_item = $(this);
                        if (tr_item.attr('data-parent-departmentid') == parent_department_value) {
                            tr_item.show()
                        }
                    })
                    element.find('i').removeClass('fa-plus')
                    element.find('i').addClass('fa-minus')
                }
                else {
                    $('.table-report').find('.expand-item').each(function (index, item) {
                        var tr_item = $(this);
                        if (tr_item.attr('data-parent-departmentid') == parent_department_value) {
                            tr_item.hide()
                        }
                    })
                    element.find('i').addClass('fa-plus')
                    element.find('i').removeClass('fa-minus')


                   
                }
            })
            $("body").on('click', ".reset_operator_saler", function (ev, picker) {
                $('#operator-saler').val(null).trigger('change')
                $('.reset_operator_saler').hide()

            })
            $('#operator-saler').on("select2:select", function (e) {
                $('.reset_operator_saler').show()
            });
        }
        _report_operator.ShowFilterOperator()
        _report_operator.SearchData()
    },
    ShowFilterGeneral: function () {
        $('#filter-sale').show()
        $('#filter-operator').hide()
        $('#DepartmentType').closest('.form-group').show()
    },
    ShowFilterOperator: function () {
        $('#filter-sale').hide()
        $('#filter-operator').show()
        $('#filter-operator').css('display', 'contents')
        $('#DepartmentType').closest('.form-group').hide()

    },
    Export: function () {
        _report_operator.GetFilter()
        _global_function.AddLoading()
        $('#operator-export-btn').prop('disabled', true);
        $('#operator-export').removeClass('fa-file-excel-o');
        $('#operator-export').addClass('fa-spinner fa-pulse');

        report_operator_search_object.record = $('#grid-data').find('#selectPaggingOptions').find(':selected').val()
        $.ajax({
            url: "/ReportDepartment/ExportOperatorExcel",
            type: "post",
            data: report_operator_search_object,
            success: function (result) {
                _global_function.RemoveLoading()
                $('#operator-export').removeClass('fa-spinner fa-pulse');
                $('#operator-export').addClass('fa-file-excel-o');
                $('#operator-export-btn').prop('disabled', false);
                if (result.status==0) {
                    _msgalert.success(result.msg);
                    window.location.href = result.path;
                } else {
                    _msgalert.error(result.msg);
                }
               
            },
        });
    },
    GetFilter: function () {

        report_operator_search_object.searchModel = {
            FromDate: _global_function.GetDayText($('#operator-create-date').data('daterangepicker').startDate._d, true),
            ToDate: _global_function.GetDayText($('#operator-create-date').data('daterangepicker').endDate._d, true),
            StartDateFrom: _global_function.GetDayText($('#operator-from-date').data('daterangepicker').startDate._d, true),
            StartDateTo: _global_function.GetDayText($('#operator-from-date').data('daterangepicker').endDate._d, true),
            EndDateFrom: _global_function.GetDayText($('#operator-to-date').data('daterangepicker').startDate._d, true),
            EndDateTo: _global_function.GetDayText($('#operator-to-date').data('daterangepicker').endDate._d, true),
            OrderStatus: $('#operator-order-finish-status').find(':selected').val(),
            InvoiceStatus: $('#operator-invoice-finish-status').find(':selected').val(),
            ExportDateFrom: _global_function.GetDayText($('#operator-export-date').data('daterangepicker').startDate._d, true),
            ExportDateTo: _global_function.GetDayText($('#operator-export-date').data('daterangepicker').endDate._d, true),
            SalerId: $('#operator-saler').find(':selected').val(),
            DepartmentId: $('#operator-departmentid').find(':selected').val(),
            SalerPermission: null,
            Branch: $('#operator-branch-code').find(':selected').val()
        }
    },
    SearchData: function () {
        _report_operator.GetFilter()
        _report_operator.Search()
    },
    Search: function () {
        $('#imgLoading').show();
        $('#grid-data').hide();

        $.ajax({
            url: "/ReportDepartment/SearchOperatorReport",
            type: "post",
            data: report_operator_search_object,
            success: function (result) {
                $('#imgLoading').hide();
                $('#grid-data').html(result);
                $('#grid-data').show();

            },
        });
    },
   
    Select2WithFixedOptionAndNoSearch: function (element) {
        element.select2({
            minimumResultsForSearch: Infinity
        });
    },
    Select2WithFixedOptionAndSearch: function (element) {
        element.select2({

        });
    },
}
