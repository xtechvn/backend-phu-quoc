
$('#import-file-ws').change(function () {
    water_sport_excel.UploadFileExcel();
});
var water_sport_excel = {
    ImportWSExcel: function () {
        let title = 'Danh sách khách lưu trú tại khách sạn';
        let url = '/WaterSport/ImportWSExcel';
        let param = {};
        _magnific.OpenSmallPopup(title, url, param);
    },
    UploadFileExcel: function () {
        let url = '/WaterSport/ImportWSExcelListing';
        let file = document.getElementById("import-file-ws").files[0];

        var file_type = file['type'];
        console.log(file_type)
        if (file_type !== "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" && file_type !=="application/vnd.ms-excel") {
            $('#import-ws-error').removeClass('mfp-hide');
            $('#grid_ws').html('');
            return;
        }
        $('#import-ws-error').hide()

        let formData = new FormData();
        formData.append("file", file)
        _global_function.AddLoading()
        debugger
        $.ajax({
            url: url,
            type: "POST",
            data: formData,
            processData: false,
            contentType: false,
            success: function (result) {
                _global_function.RemoveLoading()

                if (result != null) {
                    $('#grid_ws').html(result);
                    $('#confirm-ws-import').show()
                } else {
                    $('#import-ws-error').removeClass('mfp-hide');
                }
            }, error: function (error) {
                console.log(error);
                $('#import-ws-error').removeClass('mfp-hide');
            }
        });
    },
    ConfirmImport: function () {
        let url = '/WaterSport/ImportWSExcelUpload';
        let data = [];
        var HotelId = $('#HotelId_ws').select2().val();
        if (HotelId == undefined) {
            $('#HotelId_ws-error').removeClass('mfp-hide')
            water_sport_excel.HotelSuggestion();
            return false;
        } else {
            $('#HotelId_ws-error').addClass('mfp-hide')
        }
        $('#import-ws-error').hide()
        $('#confirm-ws-import').hide()
        $('#grid_ws tbody tr').each(function () {
            let seft = $(this);
            data.push({
                ClientId: HotelId[0],
                roomno: seft.find('.roomno').text(),
                username: seft.find('.username').text(),
                national: seft.find('.national_code').attr('data-id'),
                startDate: seft.find('.startDate').text(),
                endDate: seft.find('.endDate').text(),
            });

        });
        var jsonData = JSON.stringify(data)
        debugger
        _global_function.AddLoading()
        $.ajax({
            url: url,
            type: "POST",
            data: { jsonData },
            success: function (result) {
                _global_function.RemoveLoading()
                if (result.status == 0) {
                    _msgalert.success(result.msg);
                    $.magnificPopup.close();
                    window.location.reload()

                } else {
                    _msgalert.error(result.msg);
                    $('#confirm-ws-import').show()
                }
            }
        });
    },
    HotelSuggestion: function () {
        $("#HotelId_ws").select2({
            theme: 'bootstrap4',
            placeholder: "Tên khách hàng",
            maximumSelectionLength: 1,
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
}