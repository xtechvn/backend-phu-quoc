//-- Hotel Policy:
var _price_policy_detail = {
    Cancel: function () {
        $('body').removeClass('stop-scrolling');

        $.magnificPopup.close();

    },
    LoadPolicyRule: function (campaign_id) {
        $.ajax({
            url: "/PricePolicy/PolicyRule",
            type: "post",
            data: { campaign_id: campaign_id },
            success: function (result) {

                $('#box_list_price_policy').html(result);
            }
        });
    },
    LoadPolicyRuleWarningToChooseOption: function () {
        $('#box_list_price_policy').html('<p class="non_provider_selected" style="color:red;">Vui lòng chọn mục "Nhà cung cấp" để được hiển thị chính sách giá</p>');
    },
    ProviderDetail: {
        id: null,
        name: undefined
    },
    DecodeProviderName: function (name) {
        var textArea = document.createElement('textarea');
        textArea.innerHTML = name;
        textArea.id = "providerconverttext";
        var provider_name = textArea.value;
        $('#provider_input').val(provider_name).change();
        $('#providerconverttext').remove();
        _price_policy_detail.ProviderDetail.name = provider_name;
        _price_policy_detail.ProviderDetail.id = $('#provider_input').attr('data-providerid');
    },
    Summit: function () {
        //-- Validation:
        if ($('.non_provider_selected').length > 0) {
            _msgalert.error('Vui lòng lựa chọn nhà cung cấp');
            return;
        }
        var campaign_id = $('#campaign_code').attr('data-campaign-id');
        var campaign_code = $('#campaign_code').val();
        if (campaign_code == undefined || campaign_code.trim() == "") {
            _msgalert.error('Mã chiến dịch không được để trống.');
            return;
        }

        //-- regex campaign code
        campaign_code = campaign_code.trim()
        var regex = new RegExp('^[a-zA-Z0-9\-\_\+]*$')
        if (!regex.test(campaign_code)) {
            _msgalert.error('Mã chiến dịch chỉ chứa kí tự chữ, số, -, _');
            return
        }
        var client_type_id = $('#client_type_id :selected').val();
        if (parseInt(client_type_id) < 1) {
            _msgalert.error('Vui lòng chọn loại khách hàng');
            return;
        }
        var provider_id = $('#provider_input').attr('data-providerid');
        if ($('#provider_input').val() == undefined || $('#provider_input').val().trim() == '' || provider_id == undefined || provider_id.trim() == '') {
            _msgalert.error('Vui lòng lựa chọn đúng nhà cung cấp');
            return;
        }

        //---- Date: 
        var campaign_ToDate = $('#campaign_to_date').data('daterangepicker').startDate._d;
        var campaign_fromDate = $('#campaign_from_date').data('daterangepicker').startDate._d;
        if (campaign_ToDate < campaign_fromDate) {
            _msgalert.error('Thời gian bắt đầu chiến dịch không được lớn hơn thời gian kết thúc chiến dịch.');
            return;
        }
        //------ Fromdate
        var date_range_status = {
            BelowOrAbove: false,
            ElementError: null
        };
        $('.price_detail_input_fromdate').each(function () {
            var element = $(this);
            var element_fromdate = element.data('daterangepicker').startDate._d;
            if (element_fromdate < campaign_fromDate) {

                date_range_status.BelowOrAbove = true;
                date_range_status.ElementError = element;
                return false;
            }
        });
        if (date_range_status.BelowOrAbove == true) {
            _msgalert.error(' Ngày bắt đầu hiệu lực chiến dịch phải nhỏ hơn hoặc bằng ngày bắt đầu hiệu lực của tất cả chính sách giá');
            _price_policy_detail.CollapseAll();
            _price_policy_detail.ExpandToShowElement(date_range_status.ElementError);
            return;
        }
        //------ ToDate
        date_range_status = {
            BelowOrAbove: false,
            ElementError: null
        };
        $('.price_detail_input_todate').each(function () {

            var element = $(this);
            var element_todate = element.data('daterangepicker').startDate._d;
            if (element_todate > campaign_ToDate) {
                date_range_status.BelowOrAbove = true;
                date_range_status.ElementError = element;
                return false;
            }
        });
        if (date_range_status.BelowOrAbove == true) {
            _msgalert.error(' Ngày kết thúc hiệu lực chiến dịch phải lớn hơn hoặc bằng ngày kết thúc hiệu lực của tất cả chính sách giá');
            _price_policy_detail.CollapseAll();
            _price_policy_detail.ExpandToShowElement(date_range_status.ElementError);
            return;
        }

        //-- Summit Data:
        var contract_type = $('input[name="contract_type"]:checked').val();
        var campaign_description = $('#campaign_description').val();


        var campaign_status = $('input[name="campaign_status"]:checked').val();
        var contract_type = $('input[name="contract_type"]:checked').val();

        var list_price_policy = [];
        var campaign_detail = {
            CampaignCode: campaign_code,
            Id: campaign_id,
            ClientTypeId: client_type_id,
            Description: campaign_description,
            Status: campaign_status,
            ContractType: contract_type,
            FromDate: _price_policy_detail.GetDayText($('#campaign_from_date').data('daterangepicker').startDate._d, true),
            ToDate: _price_policy_detail.GetDayText($('#campaign_to_date').data('daterangepicker').startDate._d, true)
        }

        if ($('.level_4_block').length < 1) {
            _msgalert.error('Vui lòng lựa chọn đúng nhà cung cấp');
            return;
        }
        var is_failed = false;
        var msg_local = '';
        $('.level_4_block').each(function (i, obj) {
            var element = $(this);

            var product_service = {
                Id: element.find('.level_4_title').find('.room_name').attr('data-productserviceid'),
                ContractNo: element.closest('li').find('.level_1_title').find('.contract_no').attr('data-value'),
                PackageId: element.closest('.level_2_content').find('.level_2_title').find('.package_name').attr('data-value'),
                PackageName: element.closest('.level_2_content').find('.level_2_title').find('.package_name').text(),
                RoomID: element.find('.level_4_title').find('.room_name').attr('data-roomid'),
                ProductServiceID: element.find('.level_4_title').find('.room_name').attr('data-productserviceid'),
                AllotmentsId: element.find('.level_4_title').find('.room_name').attr('data-allotmentid'),
                GroupProviderType: element.find('.level_4_title').find('.room_name').attr('data-group-provider'),
                ProviderId: provider_id
            }
            var price_policy = [];

            element.find('.level_4').each(function (i, obj) {
                var element_policy = $(this);
                var from_date = element_policy.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
                var to_date = element_policy.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
                if (from_date > to_date) {
                    var err_room_name = element.closest('.level_4_block').find('.level_4_title').find('.room_name').text();
                    msg_local = ('Chính sách thứ [' + (price_policy.length + 1) + '] tại phòng ' + err_room_name + ': ngày bắt đầu không được lớn hơn ngày kết thúc');
                    is_failed = true;
                    return false;
                }
                if (!$.isNumeric(element_policy.find('.price_detail_input_profit').val().replaceAll(',', '')) || parseFloat(element_policy.find('.price_detail_input_profit').val().replaceAll(',', '')) < 0) {
                    var err_room_name = element.closest('.level_4_block').find('.level_4_title').find('.room_name').text();
                    msg_local = ('Chính sách thứ [' + (price_policy.length + 1) + '] tại phòng ' + err_room_name + ': Lợi nhuận không được nhỏ hơn [0]');
                    is_failed = true;
                    return false;
                }

                //-- Check Daterange:
                var price_detail_from_date = element_policy.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
                var price_detail_to_date = element_policy.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
                var is_in_date = false;
                element_policy.closest('.level_4_content').find('.level_4').each(function () {
                    var block_element = $(this);
                    if (element_policy.is(block_element)) return;
                    var block_from_date = block_element.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
                    var block_to_date = block_element.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
                    if ((block_from_date <= price_detail_from_date && price_detail_from_date <= block_to_date)
                        || (block_from_date <= price_detail_to_date && price_detail_to_date <= block_to_date)
                        || (price_detail_from_date <= block_from_date && block_from_date <= price_detail_to_date)
                        || (price_detail_from_date <= block_to_date && block_to_date <= price_detail_to_date)) {
                        is_in_date = true;
                        

                        return false;
                    }
                });
                if (is_in_date) {
                    msg_local =('Khoảng thời gian của chính sách giá không được nằm trong khoảng thời gian của chính sách giá khác trong cùng 01 phòng thuộc 01 gói.');
                    is_failed = true;
                    return false;
                }

                var unit_id_text = element_policy.find('.price_detail_unit_active').attr('data-unitid');
                if (unit_id_text == undefined) unit_id_text = '0';
                var policy = {
                    Id: element_policy.attr('data-value'),
                    ProductServiceId: element_policy.find('.level_4_title').find('.room_name').attr('data-productserviceid'),
                    GroupProviderType: element_policy.find('.level_4_title').find('.room_name').attr('data-group-provider'),
                    ServiceType: $('.campaign_detail_value').attr('data-servicetype'),
                    Profit: element_policy.find('.price_detail_input_profit').val().replace(',', ''),
                    UnitID: unit_id_text,
                    FromDate: _price_policy_detail.GetDayText(element_policy.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d, true),
                    ToDate: _price_policy_detail.GetDayText(element_policy.find('.price_detail_input_todate').data('daterangepicker').startDate._d, true),
                    Price: element_policy.find('.detail_price').attr('data-value'),
                    AmountLast: element_policy.find('.price_detail_total_amount').attr('data-value')
                }

                price_policy.push(policy);

            });
            if (is_failed) {
                return false;
            }
            var product_room_service = {
                ProductService: product_service,
                PriceDetail: price_policy
            };
            list_price_policy.push(product_room_service);
        });
        if (is_failed) {
            _msgalert.error(msg_local);
            return;
        }
        var model = {
            CampaignDetail: campaign_detail,
            ListPricePolicy: list_price_policy
        }
        var no_policy_exists = true;
        $.each(model.ListPricePolicy, function (index, value) {
            if (value.PriceDetail != undefined && value.PriceDetail.length > 0) {
                no_policy_exists = false;
                return false;
            }
        });
        if (!no_policy_exists) {
            let title = 'Xác nhận lưu';
            let description = 'Mọi thông tin về chính sách giá hiện tại sẽ được lưu, bạn có chắc chắn không?';
            _msgconfirm.openDialog(title, description, function () {
                $('.img_loading_summit').css("display", "");
                $.ajax({
                    url: "/PricePolicy/SummitHotelCampaignData",
                    type: "post",
                    data: { data: JSON.stringify(model) },
                    success: function (result) {
                        if (result.status == 0) {
                            _msgalert.success(result.message);
                            $.magnificPopup.close();
                            _pricepolicymanagement.AdvanceSearch();
                        } else {
                            _msgalert.error(result.message);
                        }
                        $('body').removeClass('stop-scrolling');

                    }
                });

            });
        }
        else {
            _msgalert.error('Vui lòng nhập ít nhất 01 chính sách giá cho ít nhất 01 loại phòng bất kỳ');
            
            return;
        }

    },
    CollapseAll: function () {
        $('.lvl_collapse').each(function (index, obj) {
            var element = $(this);
            var level = element.attr('data-level');
            switch (level) {
                case '1': {
                    element.closest('li').find('.level_2_content').hide();
                    element.removeClass('fa-minus');
                    element.addClass('fa-plus');

                } break;
                case '2': {
                    element.closest('.level_2_content').find('.level_3_content').hide();
                    element.removeClass('fa-minus');
                    element.addClass('fa-plus');

                } break;
                case '4': {
                    element.closest('.level_4_block').find('.level_4_content').hide();
                    element.removeClass('fa-minus');
                    element.addClass('fa-plus');
                } break;
                case '5': {
                    element.closest('li').find('.level_2_content').each(function () {
                        var element = $(this);
                        element.hide();
                    });
                    element.closest('li').find('.level_3_content').each(function () {
                        var element = $(this);
                        element.hide();
                    });
                    element.closest('li').find('.level_4_content').each(function () {
                        var element = $(this);
                        element.hide();
                    });
                    element.closest('li').find('.lvl_collapse').addClass('fa-plus');
                    element.closest('li').find('.lvl_collapse').removeClass('fa-minus');
                } break;
            }
        });

    },
    ExpandAll: function () {
        $('.lvl_collapse').each(function (index, obj) {
            var element = $(this);
            var level = element.attr('data-level');
            switch (level) {
                case '1': {
                    element.closest('li').find('.level_2_content').show();
                    element.removeClass('fa-plus');
                    element.addClass('fa-minus');

                } break;
                case '2': {
                    element.closest('.level_2_content').find('.level_3_content').show();
                    element.removeClass('fa-plus');
                    element.addClass('fa-minus');
                } break;
                case '4': {
                    element.closest('.level_4_block').find('.level_4_content').show();
                    element.removeClass('fa-plus');
                    element.addClass('fa-minus');
                } break;
                case '5': {
                    element.closest('li').find('.level_2_content').each(function () {
                        var element_lvl1 = $(this);
                        element_lvl1.show();
                        element_lvl1.find('.level_3_content').each(function () {
                            var element_lv2 = $(this);
                            element_lv2.show();
                            element_lv2.find('.level_4_block').find('.level_4_content').each(function () {
                                var element_lv3 = $(this);
                                element_lv3.show();
                            });
                        });

                    });
                    element.closest('li').find('.lvl_collapse').removeClass('fa-plus');
                    element.closest('li').find('.lvl_collapse').addClass('fa-minus');
                } break;
            }
        });

    },

    FormatMoney: function (number, currency) {
        if (number == undefined) {
            return 0;
        }
        else if (!$.isNumeric(number)) {
            return number;
        }
        var formatter = new Intl.NumberFormat('en-US');
        switch (currency) {
            case 'VND': {
                number = number.toFixed(0);
                return formatter.format(number);
            }
            case 'USD': {
                number = number.toFixed(2);
                return formatter.format(number);
            }
            case 'percent': {
                return number.toFixed(2);
            }
            default: {
                return number.toFixed(2);
            }
        }
    },
    GetPolicyRuleByProvider: function (campaign_id, provider_id, contract_type, group_provider_type) {
        $('.provider_input_suggestion').hide();
        $('#box_list_price_policy').html('<img src="/images/icons/loading.gif" style=" width: 100px; height: 100px;" id="imgLoading" />');
        $('.reset_provider_input').show();

        var model = { campaign_id: parseInt(campaign_id), provider_id: provider_id, contract_type: contract_type };
        $.ajax({
            url: "/PricePolicy/GetPolicyRuleByProvider",
            type: "post",
            data: model,
            success: function (result) {
                $('.campaign_detail_value').attr('data-contract-type', contract_type);
                $('#box_list_price_policy').html(result);
                $('.collapse_all').addClass('active');
                $('.expand_all').removeClass('active');
                $('.provider_input').removeAttr('data-mode');
            }
        });
    },
    FromDate: null,
    ToDate: null,
    DateContractMin: null,
    DateContractMax: null,
    PolicyRuleInit: function (group_provider_type, from_date, to_date, provider_name) {
        $('.add_new_policy_rule').hide();
        _price_policy_detail.DecodeProviderName(provider_name);

        $('.price_detail_readonly_profit').each(function (i, obj) {
            var element = $(this);
            var unit_id = element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid');
            if (unit_id != undefined) {
                switch (parseInt(unit_id)) {
                    case 1: {
                        element.html(_price_policy_detail.FormatMoney(parseFloat(element.attr('data-profit')), 'percent') + ' ' + element.attr('data-unitid'));

                    } break;
                    case 2: {
                        element.html(_price_policy_detail.FormatMoney(parseFloat(element.attr('data-profit')), 'VND') + ' ' + element.attr('data-unitid'));

                    } break;
                    default: {
                        element.html(_price_policy_detail.FormatMoney(parseFloat(element.attr('data-profit')), 'others') + ' ' + element.attr('data-unitid'));

                    } break;

                }
            }
        });
        $('.price_detail_input_profit').each(function (i, obj) {
            var element = $(this);
            var unit_id = element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid');
            if (unit_id != undefined) {
                switch (parseInt(unit_id)) {
                    case 1: {
                        element.val(_price_policy_detail.FormatMoney(parseFloat(element.val()), 'percent')).change();

                    } break;
                    case 2: {
                        element.val(_price_policy_detail.FormatMoney(parseFloat(element.val()), 'VND')).change();

                    } break;
                    default: {
                        element.val(_price_policy_detail.FormatMoney(parseFloat(element.val()), 'others')).change();

                    } break;

                }
            }
        });
        if (group_provider_type == '2') {
            $("input[name=contract_type][value=1]").attr('disabled', true);
            $("input[name=contract_type][value=1]").removeAttr('checked');
            $("input[name=contract_type][value=2]").prop('checked', 'checked');
            _price_policy_detail.DateContractMin = '01/01/2022 00:00';
            _price_policy_detail.DateContractMax = '31/12/2052 23:59';
            _price_policy_detail.ChangeCampaignDateRange(_price_policy_detail.DateContractMin, _price_policy_detail.DateContractMax);
            $('.price_detail_input_allotment_price').remove();
        }
        else {
            $("input[name=contract_type][value=1]").removeAttr('disabled');

            if ($('input[name="contract_type"]:checked').val() == '2') {
                _price_policy_detail.DateContractMin = '01/01/2022 00:00';
                _price_policy_detail.DateContractMax = '31/12/2052 23:59';
                _price_policy_detail.ChangeCampaignDateRange(_price_policy_detail.DateContractMin, _price_policy_detail.DateContractMax);
                $('.price_detail_input_allotment_price').remove();
            }
            else {

            }
        }
        $("#campaign_from_date").data('daterangepicker').setStartDate(from_date);
        $("#campaign_to_date").data('daterangepicker').setStartDate(to_date);
        _price_policy_detail.FromDate = from_date;
        _price_policy_detail.ToDate = to_date;

        _price_policy_detail.CampaignDateApplyToAllPolicy(_price_policy_detail.FromDate, _price_policy_detail.ToDate, true, false, false);
        _price_policy_detail.CollapseAll();
        //-- Add contract_range label:
        $('.contract_date_range').each(function () {
            var element = $(this);
            _price_policy_detail.AddOrUpdateContractLabel(element);
        });
        //-- Format Money:
        $('.detail_price').each(function () {
            var element = $(this);
            element.text(_price_policy_detail.FormatMoney(parseFloat(element.attr('data-value')), 'VND') + ' VND');
        });
        $('.price_detail_total_amount').each(function () {
            var element = $(this);
            element.text(_price_policy_detail.FormatMoney(parseFloat(element.attr('data-value')), 'VND') + ' VND');
        });
    },
    AddOrUpdateContractLabel: function (element) {

        var html = '(Hiệu lực hợp đồng từ {start_date} đến {end_date} )';
        var min_contract_date = $('.campaign_from_date').data('daterangepicker').startDate._d;
        if (element.closest('li').find('.price_detail_input_fromdate').length > 0) {
            min_contract_date = element.closest('li').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
            element.closest('li').find('.price_detail_input_fromdate').each(function () {
                var price_detail_element = $(this);
                if (price_detail_element.data('daterangepicker').startDate._d < min_contract_date) {
                    min_contract_date = price_detail_element.data('daterangepicker').startDate._d;
                }
            });
        }
        var max_contract_date = $('.campaign_to_date').data('daterangepicker').startDate._d;
        if (element.closest('li').find('.price_detail_input_todate').length > 0) {
            var max_contract_date = element.closest('li').find('.price_detail_input_todate').data('daterangepicker').startDate._d;
            element.closest('li').find('.price_detail_input_todate').each(function () {
                var price_detail_element = $(this);
                var date = price_detail_element.data('daterangepicker').startDate._d;

                if (date > max_contract_date) {
                    max_contract_date = price_detail_element.data('daterangepicker').startDate._d;
                }
            });
        }

        var text_from = _price_policy_detail.GetDayText(min_contract_date);
        var text_to = _price_policy_detail.GetDayText(max_contract_date);
        element.html(html.replaceAll('{start_date}', text_from).replaceAll('{end_date}', text_to)).change();
        element.attr('fromdate', min_contract_date);
        element.attr('todate', min_contract_date);
    },
    ExpandToShowElement: function (element) {
        var lvl_4 = element.closest('.level_4_block').find('.lvl_collapse');
        if (lvl_4.hasClass('fa-plus')) {
            lvl_4.click();
        }
        var lvl_3 = lvl_4.closest('.level_2_content').find('.level_2_title').find('.lvl_collapse');
        if (lvl_3.hasClass('fa-plus')) {
            lvl_3.click();

        }
        var lvl_1 = lvl_3.closest('li').find('.level_1_title').find('.lvl_collapse');
        if (lvl_1.hasClass('fa-plus')) {
            lvl_1.trigger('click');
        }
    },
    UpdateReadOnlyDateField: function (price_detail_element = undefined) {
        if (price_detail_element == undefined) {
            $('.price_detail_input_fromdate').each(function () {
                var element = $(this);
                var from_date_d = element.data('daterangepicker').startDate._d
                var text = ("0" + from_date_d.getDate()).slice(-2) + '/' + ("0" + (from_date_d.getMonth() + 1)).slice(-2) + '/' + from_date_d.getFullYear() + ' ' + ("0" + from_date_d.getHours()).slice(-2) + ':' + ("0" + from_date_d.getMinutes()).slice(-2);

                var element_readonly = element.closest('.tag-input-date').find('.price_detail_readonly_fromdate');
                element_readonly.html(text).change();
            });
            $('.price_detail_input_todate').each(function () {
                var element = $(this);
                var to_date_d = element.data('daterangepicker').startDate._d;
                var text = ("0" + to_date_d.getDate()).slice(-2) + '/' + ("0" + (to_date_d.getMonth() + 1)).slice(-2) + '/' + to_date_d.getFullYear() + ' ' + ("0" + to_date_d.getHours()).slice(-2) + ':' + ("0" + to_date_d.getMinutes()).slice(-2);
                var element_readonly = element.closest('.tag-input-date').find('.price_detail_readonly_todate');
                element_readonly.html(text).change();
            });
        }
        else {
            var price_detail_input_fromdate = price_detail_element.closest('.level_4').find('.price_detail_input_fromdate');
            var price_detail_input_todate = price_detail_element.closest('.level_4').find('.price_detail_input_todate');

            var to_date_d = price_detail_input_fromdate.data('daterangepicker').startDate._d;
            var text = ("0" + to_date_d.getDate()).slice(-2) + '/' + ("0" + (to_date_d.getMonth() + 1)).slice(-2) + '/' + to_date_d.getFullYear() + ' ' + ("0" + to_date_d.getHours()).slice(-2) + ':' + ("0" + to_date_d.getMinutes()).slice(-2);

            var element_readonly = price_detail_input_fromdate.closest('.tag-input-date').find('.price_detail_readonly_fromdate');
            element_readonly.html(text).change();

            to_date_d = price_detail_input_todate.data('daterangepicker').startDate._d;
            text = ("0" + to_date_d.getDate()).slice(-2) + '/' + ("0" + (to_date_d.getMonth() + 1)).slice(-2) + '/' + to_date_d.getFullYear() + ' ' + ("0" + to_date_d.getHours()).slice(-2) + ':' + ("0" + to_date_d.getMinutes()).slice(-2);
            element_readonly = price_detail_input_todate.closest('.tag-input-date').find('.price_detail_readonly_todate');
            element_readonly.html(text).change();

        }
    },
    RestoreLastSavedInput: function (price_detail_element = undefined) {

        if (price_detail_element != undefined) {
            if (price_detail_element.closest('.level_4').find('.price_detail_input_allotment_price').length > 0) {
                price_detail_element.closest('.level_4').find('.price_detail_input_allotment_price').val(price_detail_element.attr('data-allotmentprice-value'));
            }

            if (price_detail_element.attr('data-profit-value') != undefined) {
                price_detail_element.closest('.level_4').find('.price_detail_input_profit').val(price_detail_element.attr('data-profit-value'));

                price_detail_element.closest('.level_4').find('.price_detail_event_changeprice_unit').each(function (i, obj) {
                    var ele = $(this);
                    ele.removeClass('active');
                    ele.removeClass('price_detail_unit_active');
                    if (ele.attr('data-unitid') == price_detail_element.attr('data-profit-unitid')) {
                        ele.addClass('active');
                        ele.addClass('price_detail_unit_active');
                    }

                });
                //-- calucate amount_last:
                var unit_id = parseInt(price_detail_element.attr('data-profit-unitid'));
                var profit = price_detail_element.closest('.level_4').find('.price_detail_input_profit').val().replaceAll(',', '');
                var price = price_detail_element.closest('.level_4').find('.detail_price').attr('data-value');
                switch (parseInt(unit_id)) {
                    case 1: {
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) * (100 + parseFloat(profit)) / 100, 'VND') + ' VND');
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', (parseFloat(price) * (100 + parseFloat(profit))));

                    } break;
                    case 2: {
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) + parseFloat(profit), 'VND') + ' VND');
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price) + parseFloat(profit));
                    } break;
                    default: {
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price), 'VND') + ' VND');
                        price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price));
                    } break;

                }
            }
            if (price_detail_element.attr('data-from-date') != undefined) {
                price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').data('daterangepicker').setStartDate(price_detail_element.attr('data-from-date'));
            }
            if (price_detail_element.attr('data-to-date') != undefined) {
                price_detail_element.closest('.level_4').find('.price_detail_input_todate').data('daterangepicker').setStartDate(price_detail_element.attr('data-to-date'));
            }
        }

    },
    CampaignDateApplyToAllPolicy: function (FromDate, ToDate, price_detail_date = true, price_detail_date_new = true, price_detail_date_add_new = true) {

        if (price_detail_date) {
            $('input[name="price_detail_date"]').daterangepicker({
                singleDatePicker: true,
                showDropdowns: true,
                drops: 'up',
                timePicker: true,
                timePicker24Hour: true,
                minDate: FromDate,
                maxDate: ToDate,
                locale: {
                    format: 'DD/MM/YYYY HH:mm'
                }
            }, function (start, end, label) {


            });
        }
        if (price_detail_date_new) {
            $('input[name="price_detail_date_new"]').daterangepicker({
                singleDatePicker: true,
                showDropdowns: true,
                drops: 'up',

                timePicker: true,
                timePicker24Hour: true,
                minDate: FromDate,
                maxDate: ToDate,
                locale: {
                    format: 'DD/MM/YYYY HH:mm'
                }
            }, function (start, end, label) {


            });
        }
        if (price_detail_date_add_new) {
            $('input[name="price_detail_date_add_new"]').daterangepicker({
                singleDatePicker: true,
                showDropdowns: true,
                drops: 'up',

                timePicker: true,
                timePicker24Hour: true,
                minDate: FromDate,
                maxDate: ToDate,
                locale: {
                    format: 'DD/MM/YYYY HH:mm'
                }
            }, function (start, end, label) {


            });
        }
    },
    ChangeCampaignDateRange: function (FromDate, ToDate) {
        $('input[name="campaign_date_range"]').daterangepicker({
            singleDatePicker: true,
            showDropdowns: true,
            drops: 'down',
            timePicker: true,
            timePicker24Hour: true,
            minDate: FromDate,
            maxDate: ToDate,
            locale: {
                format: 'DD/MM/YYYY HH:mm'
            }
        }, function (start, end, label) {


        });
    },
    GetDayText: function (date, donetdate = false) {
        var text = ("0" + date.getDate()).slice(-2) + '/' + ("0" + (date.getMonth() + 1)).slice(-2) + '/' + date.getFullYear() + ' ' + ("0" + date.getHours()).slice(-2) + ':' + ("0" + date.getMinutes()).slice(-2);
        if (donetdate) {
            text = ("0" + (date.getMonth() + 1)).slice(-2) + '/' + ("0" + date.getDate()).slice(-2) + '/' + date.getFullYear() + ' ' + ("0" + date.getHours()).slice(-2) + ':' + ("0" + date.getMinutes()).slice(-2);
        }
        return text;
    },
    MessagesConstant: {
        ProfitLowerThan0: 'Lợi nhuận phải là số lớn hơn hoặc bằng 0'
    }
}
$(".white-popup").on('scroll', function () {
    if ($('input[name="campaign_date_range"]') != undefined) {
        $('input[name="campaign_date_range"]').each(function (i, obj) {
            $(this).data('daterangepicker').hide();
        });
    }

    if ($('input[name="price_detail_date"]') != undefined) {
        $('input[name="price_detail_date"]').each(function (i, obj) {
            $(this).data('daterangepicker').hide();
        });
    }
    if ($('input[name="price_detail_date_new"]') != undefined) {
        $('input[name="price_detail_date_new"]').each(function (i, obj) {
            $(this).data('daterangepicker').hide();
        });
    }
    if ($('input[name="price_detail_date_add_new"]') != undefined) {
        $('input[name="price_detail_date_add_new"]').each(function (i, obj) {
            $(this).data('daterangepicker').hide();
        });
    }
});
//---- Dynamic Bind.
$('body').on('keyup', '.provider_input', delay_callback(function (e) {
    if ($('.provider_input').val().trim() != '') {
        $('.reset_provider_input').show();
    }
    else {
        $('.reset_provider_input').hide();
    }
    $.ajax({
        url: "/PricePolicy/GetHotelSuggestion",
        type: "post",
        data: { keyword: $('.provider_input').val() },
        success: function (data) {
            $('.provider_input_suggestion').html(data);
            $('.provider_input_suggestion').show();

        }
    });
}, 500));
$('body').on('click', '.provider_input', function (event) {
    $('.provider_input').keyup();
});
$('body').on('click', '.reset_provider_input', function (event) {
    $('.provider_input').val('');
    $('.provider_input').keyup();
    $('.reset_provider_input').hide();
});
$('body').on('click', '.open_provider_suggestion', function (event) {
    var element = $(this);
    if ($('.provider_input_suggestion').is(":hidden")) {
        element.closest('.provider_input_block').find('.provider_input').attr('current-text', element.closest('.provider_input_block').find('.provider_input').val());
        element.closest('.provider_input_block').find('.provider_input').val('').change();
        $('.provider_input').click();
        $('.provider_input_suggestion').show();
    } else {
        $('.provider_input_suggestion').hide();
    }

});

//---- Expand All click
$('body').on('click', '.expand_all', function (event) {
    var element = $(this);
    if (!element.hasClass('active')) {
        _price_policy_detail.ExpandAll();
        element.addClass('active');
        $('.collapse_all').removeClass('active');
    }
});
//---- CollapseAll Click
$('body').on('click', '.collapse_all', function (event) {
    var element = $(this);
    if (!element.hasClass('active')) {
        _price_policy_detail.CollapseAll();
        element.addClass('active');
        $('.expand_all').removeClass('active');
    }
});
$('body').on('click', '.select_provider_by_option', function (event) {

    var campaign_id = $('#campaign_code').attr('data-campaign-id');
    var provider_id = $(this).attr('data-hotelid');
    var group_provider_type = $(this).attr('data_provider_type_id');
    var contract_type = $('input[name="contract_type"]:checked').val() == undefined ? 0 : parseInt($('input[name="contract_type"]:checked').val());

    if ((group_provider_type == 1 && contract_type == 0) || (group_provider_type == 1 && contract_type == 2)) {
        $('input[name=contract_type][value=1]').attr('checked', 'checked');
    }
    else if ((group_provider_type == 2 && contract_type == 0) || (group_provider_type == 2 && contract_type == 1)) {

    }
    contract_type = $('input[name="contract_type"]:checked').val() == undefined ? 0 : parseInt($('input[name="contract_type"]:checked').val());

    if ($('.provider_input').attr('data-mode') != undefined) {
        _price_policy_detail.GetPolicyRuleByProvider(campaign_id, provider_id, contract_type, group_provider_type);
        $('#campaign_description').val('').change();
    }
    else {
        let title = 'Xác nhận đổi nhà cung cấp';
        let description = 'Mọi thông tin về chính sách giá hiện tại sẽ được xóa, bạn có chắc chắn không?';
        _msgconfirm.openDialog(title, description, function () {
            _price_policy_detail.GetPolicyRuleByProvider(campaign_id, provider_id, contract_type, group_provider_type);
            $('#campaign_description').val('').change();
        });
    }


});
$(document).on('click', function (e) {
    if ($(e.target).closest(".provider_input_block").length === 0) {
        $(".provider_input_suggestion").hide();
        if ($(".provider_input").attr('data-providerid') != _price_policy_detail.ProviderDetail.id || $(".provider_input").val() != _price_policy_detail.ProviderDetail.name) {
            if ($(".provider_input").attr('data-providerid') != _price_policy_detail.ProviderDetail.id) {
                $(".provider_input").attr('data-providerid', _price_policy_detail.ProviderDetail.id);
            }
            $(".provider_input").val(_price_policy_detail.ProviderDetail.name).change();
        }
    }
});

$('body').on('click', 'input:radio[name="contract_type"]', function (event) {
    var campaign_id = $('#campaign_code').attr('data-campaign-id');
    var provider_id = $('.provider_input').attr('data-providerid');
    var contract_type = $('input[name="contract_type"]:checked').val() == undefined ? 0 : parseInt($('input[name="contract_type"]:checked').val());
    if ($('.provider_input').attr('data-mode') != undefined) {
        _price_policy_detail.GetPolicyRuleByProvider(campaign_id, provider_id, contract_type);
    }
    else {
        let title = 'Xác nhận đổi loại hợp đồng';
        let description = 'Mọi thông tin về chính sách giá hiện tại sẽ được xóa, bạn có chắc chắn không?';
        Swal.fire({
            title: title,
            text: description,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#ED5C6A',
            cancelButtonColor: '#A6A4A4',
            confirmButtonText: '<i class="fa fa-check"></i> Đồng ý',
            cancelButtonText: '<i class="fa fa-minus-circle"></i> Bỏ qua'
        }).then((result) => {
            if (result.value) {

                _price_policy_detail.GetPolicyRuleByProvider(campaign_id, provider_id, contract_type);
            }
            else {
                var current_contract_type = $('.campaign_detail_value').attr('data-contract-type');
                $('input[name=contract_type][value=' + current_contract_type + ']').prop('checked', 'checked');
            }
        })
    }
});


$('body').on('mouseenter', '.level_4', function (event) {
    if (!$(this).find('.price_detail_input_button').hasClass('no_display')) {
        $(this).closest('.level_4').find('.price_detail_readonly_button').addClass('no_display')

    }
    else {
        $(this).closest('.level_4').find('.price_detail_readonly_button').removeClass('no_display')

        $(this).find('.price_detail_readonly_button').show();
    }

});
$('body').on('mouseleave', '.level_4', function (event) {
    if (!$(this).find('.price_detail_input_button').hasClass('no_display')) {
        $(this).closest('.level_4').find('.price_detail_readonly_button').addClass('no_display')

    }
    else {
        $(this).closest('.level_4').find('.price_detail_readonly_button').addClass('no_display')
        $(this).find('.price_detail_readonly_button').hide();
    }

});

$('body').on('mouseenter', '.level_4_title', function (event) {
    $(this).find('.add_new_policy_rule').show();


});
$('body').on('mouseleave', '.level_4_title', function (event) {
    $(this).find('.add_new_policy_rule').hide();

});
$('body').on('mouseenter', '.level_2_title', function (event) {
    $(this).find('.add_new_policy_rule').show();


});
$('body').on('mouseleave', '.level_2_title', function (event) {
    $(this).find('.add_new_policy_rule').hide();

});
$('body').on('mouseenter', '.level_1_title', function (event) {
    $(this).find('.add_new_policy_rule').show();


});
$('body').on('mouseleave', '.level_1_title', function (event) {
    $(this).find('.add_new_policy_rule').hide();

});
$('body').on('click', '.lvl_collapse', function (event) {
    var level = $(this).attr('data-level');
    switch (level) {
        case '1': {
            if ($(this).hasClass('fa-minus')) {
                $(this).closest('li').find('.level_2_content').hide();
                $(this).removeClass('fa-minus');
                $(this).addClass('fa-plus');
            }
            else {
                $(this).closest('li').find('.level_2_content').show();
                $(this).removeClass('fa-plus');
                $(this).addClass('fa-minus');
            }

        } break;
        case '2': {
            if ($(this).hasClass('fa-minus')) {
                $(this).closest('.level_2_content').find('.level_3_content').hide();
                $(this).removeClass('fa-minus');
                $(this).addClass('fa-plus');
                $(this).closest('.level_2_content').find('.level_4_title').find('.lvl_collapse').each(function (i, obj) {
                    var element = $(this);
                    if (element.hasClass('fa-minus')) element.trigger('click');
                });
            }
            else {
                $(this).closest('.level_2_content').find('.level_3_content').show();
                $(this).removeClass('fa-plus');
                $(this).addClass('fa-minus');
                $(this).closest('.level_2_content').find('.level_4_title').find('.lvl_collapse').each(function (i, obj) {
                    var element = $(this);
                    if (element.hasClass('fa-plus')) element.trigger('click');
                });
            }
        } break;
        case '4': {
            if ($(this).hasClass('fa-minus')) {
                $(this).closest('.level_4_block').find('.level_4_content').hide();
                $(this).removeClass('fa-minus');
                $(this).addClass('fa-plus');
            }
            else {
                $(this).closest('.level_4_block').find('.level_4_content').show();
                $(this).removeClass('fa-plus');
                $(this).addClass('fa-minus');
            }
        } break;
        case '5': {

            if ($(this).hasClass('fa-minus')) {
                $(this).closest('li').find('.level_2_content').hide();
                $(this).closest('li').find('.level_2_title').find('em').addClass('fa-plus');
                $(this).closest('li').find('.level_3_content').hide();
                $(this).removeClass('fa-minus');
                $(this).addClass('fa-plus');
                $(this).closest('li').find('.level_4_title').find('.lvl_collapse').each(function (i, obj) {
                    var element = $(this);
                    if (element.hasClass('fa-plus')) element.trigger('click');
                });
            }
            else {
                $(this).closest('li').find('.level_2_content').show();
                $(this).closest('li').find('.level_2_title').find('em').addClass('fa-minus');
                $(this).closest('li').find('.level_3_content').show();
                $(this).removeClass('fa-plus');
                $(this).addClass('fa-minus');
                $(this).closest('li').find('.level_4_title').find('.lvl_collapse').each(function (i, obj) {
                    var element = $(this);
                    if (element.hasClass('fa-plus')) element.trigger('click');
                });
            }
        } break;
    }

});
$('body').on('click', '.enable_edit_price_detail', function (event) {
    $(this).closest('.level_4').find('.price_detail_input_button').removeClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly_button').addClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly').addClass('no_display')
    $(this).closest('.level_4').find('.price_detail_input').removeClass('no_display')
});

$('body').on('click', '.cancel_edit_price_detail', function (event) {
    $(this).closest('.level_4').find('.price_detail_input_button').addClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly_button').removeClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly').removeClass('no_display')
    $(this).closest('.level_4').find('.price_detail_input').addClass('no_display')

    _price_policy_detail.UpdateReadOnlyDateField($(this));
    _price_policy_detail.RestoreLastSavedInput($(this));
});
$('body').on('click', '.price_detail_event_changeprice_unit', function (event) {
    var element = $(this);
    if (!element.hasClass('active')) {
        element.closest('.price_detail_input_price_unit').find('.price_detail_event_changeprice_unit').removeClass('active');
        element.closest('.price_detail_input_price_unit').find('.price_detail_event_changeprice_unit').removeClass('price_detail_unit_active');
        element.addClass('active');
        element.addClass('price_detail_unit_active');
        if (element.attr('data-unitid') == '2') {
            $(this).closest('.price_detail_input').find('.price_detail_input_profit').val('0');
        }
        else if (element.attr('data-unitid') == '1') {
            element.closest('.price_detail_input').find('.price_detail_input_profit').val('0');
        }
    }


});
$('body').on('click', '.delete_price_detail', function () {
    var element = $(this);
    let title = 'Thông báo xác nhận';
    let description = "Thông tin về chính sách giá này sẽ bị xóa. Bạn có chắc chắn không?";
    _msgconfirm.openDialog(title, description, function () {
        var id = element.closest('.level_4').attr('data-value');
        if (id != undefined && parseInt(id) > 0) {
            $.ajax({
                url: '/PricePolicy/RemovePriceDetail',
                type: "post",
                data: { id: id },
                success: function (result) {
                    if (result.status == 0) {
                        element.closest('.level_4').remove();
                        _msgalert.success(result.message);
                    } else {
                        _msgalert.error(result.message);
                    }
                    //-- Update Contract Label
                    var label_contract = element.closest('li').find('.contract_date_range');
                    _price_policy_detail.AddOrUpdateContractLabel(label_contract);
                }
            });
        } else {
            element.closest('.level_4').remove();
            _msgalert.success("Xóa chính sách giá thành công.");
        }
    });

});
// dynamic bind: nhấn nút cập nhật chính sách giá
$('body').on('click', '.update_price_detail', function () {
    //-- Get Element
    var price_detail_element = $(this);
    //--Get data
    var campaign_id = $('#campaign_code').attr('data-campaign-id');
    var contract_no = price_detail_element.closest('li').find('.contract_no').attr('data-value');
    var package_id = price_detail_element.closest('.level_2_content').find('.level_2_title').find('.package_name').attr('data-value');
    var price_detail_id = price_detail_element.closest('.level_4').attr('data-value');
    var price = 0;
    var amount_last = 0;
    var profit = price_detail_element.closest('.level_4').find('.price_detail_input_profit').val() == undefined ? '-1' : price_detail_element.closest('.level_4').find('.price_detail_input_profit').val().replaceAll(',', '');
    var show_success = true;
    if (profit.trim() == '') {
        price_detail_element.closest('.level_4').find('.price_detail_input_profit').val('0').change();
        profit = '0';
        _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);
        show_success = false;
    } 

    if (profit == undefined ||  !$.isNumeric(profit.replaceAll(',', ''))|| parseFloat(profit.replaceAll(',', '')) < 0) {
        //_msgalert.error('Lợi nhuận phải là số lớn hơn hoặc bằng 0');
        _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);
        return;
    }
    if (price_detail_element.closest('.level_4').find('.price_detail_input_allotment_price').length > 0) {
        price = price_detail_element.closest('.level_4').find('.price_detail_input_allotment_price').val() == undefined ? '0' : price_detail_element.closest('.level_4').find('.price_detail_input_allotment_price').val().replaceAll(',', '');
        if (price == undefined || !$.isNumeric(price.replaceAll(',', '')) || parseFloat(price.replaceAll(',', '')) < 0) {
            _msgalert.error('Giá Allotment không được nhỏ hơn 0');
            return;
        }
    }
    price = price_detail_element.closest('.level_4').find('.detail_price').attr('data-value');
    if (parseFloat(price) == undefined || parseFloat(price) <= 0) price = '0';
    var unit_id = price_detail_element.closest('.level_4').find('.price_detail_input_price_unit').find('.price_detail_unit_active').attr('data-unitid');
    if (price_detail_element.closest('.add_new_block').find('.price_detail_input_profit').attr('data-mode-new') != undefined) {
        unit_id = price_detail_element.closest('.add_new_block').find('.tag-input-price').find('.price_detail_unit_active').attr('data-unitid');
    }

    switch (parseInt(unit_id)) {
        case 1: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) * (100 + parseFloat(profit)) / 100, 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', (parseFloat(price) * (100 + parseFloat(profit))));

        } break;
        case 2: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) + parseFloat(profit), 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price) + parseFloat(profit));
        } break;
        default: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price), 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price));
        } break;

    }
    amount_last = price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value');

    if (price == undefined || parseFloat(price.replaceAll(',', '')) == undefined || parseFloat(price.replaceAll(',', '')) < 0) {
       // _msgalert.error('Lợi nhuận phải là số lớn hơn hoặc bằng 0');
        _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);
        return;
    }
    //---- Date: 
    var campaign_ToDate = $('#campaign_to_date').data('daterangepicker').startDate._d
    var campaign_fromDate = $('#campaign_from_date').data('daterangepicker').startDate._d
    if (campaign_ToDate < campaign_fromDate) {
        _msgalert.error('Không thể lưu chính sách giá khi thời gian chiến dịch đang sai');
        return;
    }

    //------ Fromdate
    var element = price_detail_element.closest('.level_4').find('.price_detail_input_fromdate');
    var element_fromdate = element.data('daterangepicker').startDate._d;
    if (element_fromdate < campaign_fromDate) {
        _msgalert.error('Ngày bắt đầu hiệu lực chính sách giá không được nhỏ hơn ngày bắt đầu hiệu lực chiến dịch');
        _price_policy_detail.ExpandToShowElement(element);
        return;
    }
    //------ ToDate
    var element = price_detail_element.closest('.level_4').find('.price_detail_input_todate');
    var element_todate = element.data('daterangepicker').startDate._d;
    if (element_todate > campaign_ToDate) {
        _msgalert.error(' Ngày kết thúc hiệu lực chính sách giá không được lớn ngày kết thúc hiệu lực chiến dịch');
        _price_policy_detail.ExpandToShowElement(element);
        return;
    }
    //-- Check Daterange:
    var price_detail_from_date = price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
    var price_detail_to_date = price_detail_element.closest('.level_4').find('.price_detail_input_todate').data('daterangepicker').startDate._d;

    if (price_detail_to_date != undefined && price_detail_from_date > price_detail_to_date) {
        _msgalert.error('Thời gian bắt đầu chính sách giá không được lớn hơn thời gian kết thúc chính sách giá.');
        return;
    }

    var is_in_date = false
    price_detail_element.closest('.level_4_block').find('.level_4').each(function () {
        var block_element = $(this);
        var block_from_date = block_element.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
        var block_to_date = block_element.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
        if (price_detail_element.closest('.level_4').is(block_element)) return;
        
        if ((block_from_date <= price_detail_from_date && price_detail_from_date <= block_to_date)
            || (block_from_date <= price_detail_to_date && price_detail_to_date <= block_to_date)
            || (price_detail_from_date <= block_from_date && block_from_date <= price_detail_to_date)
            || (price_detail_from_date <= block_to_date && block_to_date <= price_detail_to_date)) {
            is_in_date = true;
            

            return false;
        }
    });
    if (is_in_date) {
        _msgalert.error('Khoảng thời gian của chính sách giá không được nằm trong khoảng thời gian của chính sách giá khác trong cùng 01 phòng thuộc 01 gói.');
        return;
    }

    var unit_id = price_detail_element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid') == undefined ? '0' : price_detail_element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid');
    var from_date = _price_policy_detail.GetDayText(price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d, true);
    var to_date = _price_policy_detail.GetDayText(price_detail_element.closest('.level_4').find('.price_detail_input_todate').data('daterangepicker').startDate._d, true);
    var provider_id = $('#provider_input').attr('data-providerid');
    var service_type = $('.campaign_detail_value').attr('data-servicetype');
    var room_id = price_detail_element.closest('.level_4_block').find('.level_4_title').find('.room_name').attr('data-roomid');
    var group_provider_id = price_detail_element.closest('.level_4_block').find('.level_4_title').find('.room_name').attr('data-group-provider');
    var allotment_id = price_detail_element.closest('.level_4_block').find('.level_4_title').find('.room_name').attr('data-allotmentid');
    var product_service_id = price_detail_element.closest('.level_4_block').find('.level_4_title').find('.room_name').attr('data-productserviceid');

    if (price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d > price_detail_element.closest('.level_4').find('.price_detail_input_todate').data('daterangepicker').startDate._d) {
        _msgalert.error('Thời gian bắt đầu chính sách giá không được lớn hơn thời gian kết thúc chính sách giá.');
        return;
    }


    //-- Summit:
    var item = {
        CampaignID: campaign_id,
        ContractNo: contract_no,
        PackageId: package_id,
        PriceDetailID: price_detail_id,
        Price: price,
        AmountLast: amount_last,
        Profit: profit,
        UnitId: unit_id,
        FromDate: from_date,
        ToDate: to_date,
        ProviderID: provider_id,
        ServiceType: service_type,
        RoomID: room_id,
        GroupProviderType: group_provider_id,
        AllotmentsId: allotment_id,
        ProductServiceID: product_service_id
    };

    $.ajax({
        url: '/PricePolicy/UpdatePricePolicyDetail',
        type: "post",
        data: { data: JSON.stringify(item) },
        success: function (result) {
            if (result.status == 0) {
                if (show_success)  _msgalert.success(result.msg);
            } else {
                _msgalert.error(result.msg);
            }
            price_detail_element.closest('.level_4').find('.price_detail_readonly_profit').attr('data-profit', profit);
            price_detail_element.closest('.level_4').find('.price_detail_readonly_profit').attr('data-unitid', unit_id == '2' ? "VND" : "%");
            price_detail_element.closest('.level_4').find('.price_detail_readonly_profit').html(price_detail_element.closest('.level_4').find('.price_detail_input_profit').val() + ' ' + (unit_id == '2' ? "VND" : "%"));
            price_detail_element.closest('.level_4').attr('data-value', result.price_id);
            _price_policy_detail.UpdateReadOnlyDateField(price_detail_element);

        }
    });
    //--Update price and amount_last
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-profit-value', profit);
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-profit-unitid', unit_id);

    //-- Change To only-read mode:
    $(this).closest('.level_4').find('.price_detail_input_button').addClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly_button').removeClass('no_display')
    $(this).closest('.level_4').find('.price_detail_readonly').removeClass('no_display')
    $(this).closest('.level_4').find('.price_detail_input').addClass('no_display')

});
// dynamic bind: nhập lợi nhuận
$('body').on('focusout', '.price_detail_input_profit', function () {

    var price_detail_element = $(this);
    var unit_id = price_detail_element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid');
    if (price_detail_element.attr('data-mode-new') != undefined) {
        unit_id = price_detail_element.closest('.tag-input-price').find('.price_detail_unit_active').attr('data-unitid');
    }
    var profit = $(this).val().replace(',', '');
    var is_hover_update = price_detail_element.closest('.level_4').find('.update_price_detail').is(':hover');
    if (!$.isNumeric(profit) || parseFloat(profit) < 0) {
        //_msgalert.error('Lợi nhuận phải là số lớn hơn hoặc bằng 0');
        if (!is_hover_update) _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);
        return;
    }

    if ($.isNumeric(unit_id)) {
        switch (parseInt(unit_id)) {
            case 1: {
                price_detail_element.val(_price_policy_detail.FormatMoney(parseFloat(profit), 'percent'));
            } break;
            case 2: {
                price_detail_element.val(_price_policy_detail.FormatMoney(parseFloat(profit), 'VND'));
            } break;
        }
    }
    //-- calucate amount_last:
    var price = price_detail_element.closest('.level_4').find('.detail_price').attr('data-value');
    if (parseFloat(price) == undefined || parseFloat(price) <= 0) price = '0';

    switch (parseInt(unit_id)) {
        case 1: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) * (100 + parseFloat(profit)) / 100, 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', (parseFloat(price) * (100 + parseFloat(profit))));

        } break;
        case 2: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) + parseFloat(profit), 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price) + parseFloat(profit));
        } break;
        default: {
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price), 'VND') + ' VND');
            price_detail_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price));
        } break;

    }

});
$('body').on('click', '.price_detail_input_profit', function () {
    var price_detail_element = $(this);
    var profit = $(this).val().replaceAll(',', '');
    price_detail_element.val(profit);
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-profit-value', price_detail_element.val().replaceAll(',', ''));
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-profit-unitid', price_detail_element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid'));

});
$('body').on('click', '.price_detail_input_allotment_price', function () {
    var allotment_price_element = $(this);
    var profit = $(this).val().replaceAll(',', '');
    allotment_price_element.val(profit);
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-allotmentprice-value', allotment_price_element.val().replaceAll(',', ''));
});

$('body').on('click', '.price_detail_input_fromdate', function () {
    var from_date_d = $(this).data('daterangepicker').startDate._d;
    var from_date = ("0" + from_date_d.getDate()).slice(-2) + '/' + ("0" + (from_date_d.getMonth() + 1)).slice(-2) + '/' + from_date_d.getFullYear() + ' ' + ("0" + from_date_d.getHours()).slice(-2) + ':' + ("0" + from_date_d.getMinutes()).slice(-2);
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-from-date', from_date);
});
$('body').on('click', '.price_detail_input_todate', function () {
    var to_date_d = $(this).data('daterangepicker').startDate._d;
    var to_date = ("0" + to_date_d.getDate()).slice(-2) + '/' + ("0" + (to_date_d.getMonth() + 1)).slice(-2) + '/' + to_date_d.getFullYear() + ' ' + ("0" + to_date_d.getHours()).slice(-2) + ':' + ("0" + to_date_d.getMinutes()).slice(-2);
    $(this).closest('.level_4').find('.cancel_edit_price_detail').attr('data-to-date', to_date);
});

$('body').on('focusout', '.price_detail_input_allotment_price', function () {

    var allotment_price_element = $(this);
    var price = allotment_price_element.val().replace(',', '');

    if (!$.isNumeric(price) || parseFloat(price) < 0) {
        _msgalert.error('Giá Allotment phải lớn hơn hoặc bằng 0');
        allotment_price_element.val('0').change();
        return;
    }
    allotment_price_element.val(_price_policy_detail.FormatMoney(parseFloat(price), 'VND'));
    allotment_price_element.closest('.level_4').find('.detail_price').attr('data-value', parseFloat(price))
    allotment_price_element.closest('.level_4').find('.detail_price').html(_price_policy_detail.FormatMoney(parseFloat(price), 'VND') + ' VND');
    //-- calucate amount_last:
    var profit = allotment_price_element.closest('.level_4').find('.price_detail_readonly_profit').attr('data-profit');
    var unit_id = allotment_price_element.closest('.level_4').find('.price_detail_unit_active').attr('data-unitid');
    switch (parseInt(unit_id)) {
        case 1: {
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) * (100 + parseFloat(profit)) / 100, 'VND') + ' VND');
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', (parseFloat(price) * (100 + parseFloat(profit))));

        } break;
        case 2: {
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price) + parseFloat(profit), 'VND') + ' VND');
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price) + parseFloat(profit));
        } break;
        default: {
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').html(_price_policy_detail.FormatMoney(parseFloat(price), 'VND') + ' VND');
            allotment_price_element.closest('.level_4').find('.price_detail_total_amount').attr('data-value', parseFloat(price));
        } break;
    }

});
// dynamic bind: thêm box tạo mới để thêm chính sách giá:
$('body').on('click', '.add_new_policy_rule', function () {
    var lvl = $(this).attr('data-newlevel');
    var element_to_append = undefined;
    switch (lvl) {

        case '2': {
            element_to_append = $(this).closest('.level_1_title');
            var item = {
                level: lvl
            }
            $.ajax({
                url: '/PricePolicy/NewPolicyRule',
                type: "post",
                data: item,
                success: function (result) {
                    $(result).insertAfter(element_to_append);
                }
            });
        } break;

        case '3': {
            element_to_append = $(this).closest('.level_2_title');
            var item = {
                level: lvl
            }
            $.ajax({
                url: '/PricePolicy/NewPolicyRule',
                type: "post",
                data: item,
                success: function (result) {
                    $(result).insertAfter(element_to_append);
                }
            });
        } break;
        case '4': {

            element_to_append = $(this).closest('.level_4_block').find('.level_4_title');
            var item = {
                level: lvl
            }
            $.ajax({
                url: '/PricePolicy/NewPolicyRule',
                type: "post",
                data: item,
                success: function (result) {
                    $(result).insertAfter(element_to_append);
                }
            });
        } break;
        case '5': {

            element_to_append = $(this).closest('.level_1_title');
            var item = {
                level: lvl
            }
            $.ajax({
                url: '/PricePolicy/NewPolicyRule',
                type: "post",
                data: item,
                success: function (result) {
                    $(result).insertAfter(element_to_append);
                }
            });
        } break;
        default: {
            return;
        }
    }


});
// dynamic bind: hủy thêm mới chính sách giá:
$('body').on('click', '.cancel_edit_price_detail_add_new', function () {
    $(this).closest('.add_new_block').remove();

});

// dynamic bind: confirm thêm mới chính sách giá:
$('body').on('click', '.update_price_detail_add_new', function () {

    var lvl = $(this).attr('data-lvl');
    var element_target = $(this);

    var profit = element_target.closest('.add_new_block').find('.price_detail_input_profit').val().replaceAll(',', '');
    if (profit.trim() == '') {
        price_detail_element.closest('.add_new_block').find('.price_detail_input_profit').val('0').change();
        profit = '0';
        _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);
        return;
    }
    if (profit == undefined || !$.isNumeric(profit.replaceAll(',', '')) || parseFloat(profit.replaceAll(',', '')) < 0) {
      //  _msgalert.error('Lợi nhuận phải là số lớn hơn hoặc bằng 0');
        _msgalert.error(_price_policy_detail.MessagesConstant.ProfitLowerThan0);

        return;
    }
    var unitid = element_target.closest('.add_new_block').find('.price_detail_unit_active').attr('data-unitid');
    var from_date = element_target.closest('.add_new_block').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
    var to_date = element_target.closest('.add_new_block').find('.price_detail_input_todate').data('daterangepicker').startDate._d;
    if (from_date > to_date) {
        _msgalert.error('Thời gian bắt đầu chính sách giá không được lớn hơn thời gian kết thúc chính sách giá.');
        return;
    }

    var from_date_text = _price_policy_detail.GetDayText(from_date);
    var to_date_text = _price_policy_detail.GetDayText(to_date);
    //-- Append:
    var template_html = '<div class="mb10 level_4" data-value="-1"> <nw class="price_detail_input no_display">Chi phí gốc: </nw> {base_price} <nw class="price_detail_input no_display"> - </nw> CPDV: <nw class="readonly price_detail_readonly price_detail_readonly_profit" data-profit="{profit}" data-unitid="{unit_id}">{profit_show}</nw> <div class="tag-input-price price_detail_input no_display"> <input type="text" class="form-control price_detail_input price_detail_input_profit no_display" value="{profit}"> <div class="tag  price_detail_input_price_unit "> <a class="{vnd_active} price_detail_event_changeprice_unit price_detail_unit_vnd" data-unitid="2" href="javascript:;">VND</a> <a class="{percent_active} price_detail_event_changeprice_unit price_detail_unit_percent" data-unitid="1" href="javascript:;">%</a> </div> </div> <nw class="price_detail_input no_display">- Giá bán cuối cùng: </nw> <nw class="readonly price_detail_input price_detail_total_amount no_display" data-value="{amount_last}">{amount_last_show} VND</nw> Hiệu lực giá: <div class="tag-input-date"> <nw class="readonly price_detail_readonly price_detail_readonly_fromdate">{from_date} </nw> <input class="form-control date datefilter price_detail_input price_detail_input_fromdate no_display" type="text" name="price_detail_date_new" value="{from_date}"> </div> - <div class="tag-input-date"> <nw class="readonly price_detail_readonly price_detail_readonly_todate">{to_date}</nw> <input class="form-control date datefilter price_detail_input price_detail_input_todate no_display" type="text" name="price_detail_date_new" value="{to_date}"> </div> <span class="controler show  ml-2 price_detail_input_button no_display"> <a href="javascript:;" class="btn-default update_price_detail">Cập nhật</a> <a href="javascript:;" class="ml-1 blue cancel_edit_price_detail" data-profit-value="{profit}" data-profit-unitid="{unitid_active}">Hủy</a> </span> <span class="controler price_detail_block price_detail_readonly_button" style=" display:none;"> <a href="javascript:;" class="fa fa-pencil ml-2 green enable_edit_price_detail"></a> <a href="javascript:;" class="fa fa-trash ml-1 red delete_price_detail"></a> </span> </div>';
    var template_contract = '<nw class="readonly price_detail_input no_display detail_price" data-value="{price}">{price_show} VND</nw>';
    var template_allotment = template_contract;


    switch (lvl) {
        case '1': {

            return;
        }

        case '2': {
            element_target.closest('li').find('.level_4_content').each(function () {
                let element = $(this);
                let price = element.attr('data-price');
                let price_number = parseFloat(price);
                let amount_last = 0;
                if (price_number > 0) {
                    if (unitid == '1') {
                        amount_last = price_number + (price_number * parseFloat(profit / 100));
                    } else if (unitid == '2') {
                        amount_last = price_number + parseFloat(profit);
                    }
                }

                var profit_show = '0';
                var html_append = template_html.replaceAll('{from_date}', from_date_text).replaceAll('{to_date}', to_date_text).replaceAll('{unitid_active}', unitid);
                var contract_type = $('input[name="contract_type"]:checked').val();
                if (contract_type == '1') {
                    html_append = html_append.replaceAll('{base_price}', template_allotment);
                }
                else if (contract_type == '2') {
                    html_append = html_append.replaceAll('{base_price}', template_contract);
                }
                if (unitid == '1') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'percent');
                    profit_show += " %";
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', 'active price_detail_unit_active');

                }
                else if (unitid == '2') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'VND');
                    profit_show += " VND";
                    html_append = html_append.replaceAll('{vnd_active}', 'active price_detail_unit_active').replaceAll('{percent_active}', '');
                }
                else {
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', '');
                }
                html_append = html_append.replaceAll('{price}', price).replaceAll('{price_show}', _price_policy_detail.FormatMoney(price_number, 'VND'));
                html_append = html_append.replaceAll('{profit}', profit).replaceAll('{profit_show}', profit_show);
                html_append = html_append.replaceAll('{amount_last}', amount_last).replaceAll('{amount_last_show}', _price_policy_detail.FormatMoney(parseFloat(amount_last), 'VND'));
                element.prepend(html_append);
            });

        } break;
        case '3': {
            element_target.closest('.level_2_content').find('.level_4_content').each(function () {
                let element = $(this);
                let price = element.attr('data-price');
                let price_number = parseFloat(price);
                let amount_last = 0;
                if (price_number > 0) {
                    if (unitid == '1') {
                        amount_last = price_number + (price_number * parseFloat(profit / 100));
                    } else if (unitid == '2') {
                        amount_last = price_number + parseFloat(profit);
                    }
                }

                var profit_show = '0';
                var html_append = template_html.replaceAll('{from_date}', from_date_text).replaceAll('{to_date}', to_date_text).replaceAll('{unitid_active}', unitid);
                var contract_type = $('input[name="contract_type"]:checked').val();
                if (contract_type == '1') {
                    html_append = html_append.replaceAll('{base_price}', template_allotment);
                }
                else if (contract_type == '2') {
                    html_append = html_append.replaceAll('{base_price}', template_contract);
                }
                if (unitid == '1') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'percent');
                    profit_show += " %";
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', 'active price_detail_unit_active');

                }
                else if (unitid == '2') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'VND');
                    profit_show += " VND";
                    html_append = html_append.replaceAll('{vnd_active}', 'active price_detail_unit_active').replaceAll('{percent_active}', '');
                }
                else {
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', '');
                }
                html_append = html_append.replaceAll('{price}', price).replaceAll('{price_show}', _price_policy_detail.FormatMoney(price_number, 'VND'));
                html_append = html_append.replaceAll('{profit}', profit).replaceAll('{profit_show}', profit_show);
                html_append = html_append.replaceAll('{amount_last}', amount_last).replaceAll('{amount_last_show}', _price_policy_detail.FormatMoney(parseFloat(amount_last), 'VND'));
                element.prepend(html_append);
            });

        } break;
        case '4': {
            //-- Check Daterange:
            var price_detail_from_date = element_target.closest('.add_new_block').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
            var price_detail_to_date = element_target.closest('.add_new_block').find('.price_detail_input_todate').data('daterangepicker').startDate._d;

            if (price_detail_to_date != undefined && price_detail_from_date > price_detail_to_date) {
                _msgalert.error('Thời gian bắt đầu chính sách giá không được lớn hơn thời gian kết thúc chính sách giá.');
                return;
            }

            var is_in_date = false
            element_target.closest('.level_4_block').find('.level_4').each(function () {
                
                var block_element = $(this);
                var block_from_date = block_element.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
                var block_to_date = block_element.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
                if (element_target.is(block_element)) return;
                if ((block_from_date <= price_detail_from_date && price_detail_from_date <= block_to_date)
                    || (block_from_date <= price_detail_to_date && price_detail_to_date <= block_to_date)
                    || (price_detail_from_date <= block_from_date && block_from_date <= price_detail_to_date)
                    || (price_detail_from_date <= block_to_date && block_to_date <= price_detail_to_date)) {
                    is_in_date = true;
                    
                    return false;
                }
            });
            if (is_in_date) {
                _msgalert.error('Khoảng thời gian của chính sách giá không được nằm trong khoảng thời gian của chính sách giá khác trong cùng 01 phòng thuộc 01 gói.');
                return;
            }

            element_target.closest('.level_4_block').find('.level_4_content').each(function () {
                let element = $(this);
                let price = element.attr('data-price');
                let price_number = parseFloat(price);
                let amount_last = 0;
                if (price_number > 0) {
                    if (unitid == '1') {
                        amount_last = price_number + (price_number * parseFloat(profit / 100));
                    } else if (unitid == '2') {
                        amount_last = price_number + parseFloat(profit);
                    }
                }

                var profit_show = '0';
                var html_append = template_html.replaceAll('{from_date}', from_date_text).replaceAll('{to_date}', to_date_text).replaceAll('{unitid_active}', unitid);
                var contract_type = $('input[name="contract_type"]:checked').val();
                if (contract_type == '1') {
                    html_append = html_append.replaceAll('{base_price}', template_allotment);
                }
                else if (contract_type == '2') {
                    html_append = html_append.replaceAll('{base_price}', template_contract);
                }
                if (unitid == '1') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'percent');
                    profit_show += " %";
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', 'active price_detail_unit_active');

                }
                else if (unitid == '2') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'VND');
                    profit_show += " VND";
                    html_append = html_append.replaceAll('{vnd_active}', 'active price_detail_unit_active').replaceAll('{percent_active}', '');
                }
                else {
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', '');
                }
                html_append = html_append.replaceAll('{price}', price).replaceAll('{price_show}', _price_policy_detail.FormatMoney(price_number, 'VND'));
                html_append = html_append.replaceAll('{profit}', profit).replaceAll('{profit_show}', profit_show);
                html_append = html_append.replaceAll('{amount_last}', amount_last).replaceAll('{amount_last_show}', _price_policy_detail.FormatMoney(parseFloat(amount_last), 'VND'));
                element.prepend(html_append);
            });


        } break;
        case '5': {
            element_target.closest('li').find('.level_4_content').each(function () {
                let element = $(this);
                let price = element.attr('data-price');
                let price_number = parseFloat(price);
                let amount_last = 0;
                if (price_number > 0) {
                    if (unitid == '1') {
                        amount_last = price_number + (price_number * parseFloat(profit / 100));
                    } else if (unitid == '2') {
                        amount_last = price_number + parseFloat(profit);
                    }
                }

                var profit_show = '0';
                var html_append = template_html.replaceAll('{from_date}', from_date_text).replaceAll('{to_date}', to_date_text).replaceAll('{unitid_active}', unitid);
                var contract_type = $('input[name="contract_type"]:checked').val();
                if (contract_type == '1') {
                    html_append = html_append.replaceAll('{base_price}', template_allotment);
                }
                else if (contract_type == '2') {
                    html_append = html_append.replaceAll('{base_price}', template_contract);
                }
                if (unitid == '1') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'percent');
                    profit_show += " %";
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', 'active price_detail_unit_active');

                }
                else if (unitid == '2') {
                    profit_show = _price_policy_detail.FormatMoney(parseFloat(profit), 'VND');
                    profit_show += " VND";
                    html_append = html_append.replaceAll('{vnd_active}', 'active price_detail_unit_active').replaceAll('{percent_active}', '');
                }
                else {
                    html_append = html_append.replaceAll('{vnd_active}', '').replaceAll('{percent_active}', '');
                }
                html_append = html_append.replaceAll('{price}', price).replaceAll('{price_show}', _price_policy_detail.FormatMoney(price_number, 'VND'));
                html_append = html_append.replaceAll('{profit}', profit).replaceAll('{profit_show}', profit_show);
                html_append = html_append.replaceAll('{amount_last}', amount_last).replaceAll('{amount_last_show}', _price_policy_detail.FormatMoney(parseFloat(amount_last), 'VND'));
                element.prepend(html_append);
            });



        } break;
        default: {
            return;
        }
    }
    $('.expand_all').removeClass('active');
    $('.expand_all').addClass('active');
    $('.collapse_all').removeClass('active');
    _price_policy_detail.CampaignDateApplyToAllPolicy(_price_policy_detail.FromDate, _price_policy_detail.ToDate, false, true, false);
    element_target.closest('.add_new_block').remove();
    //-- Update Contract Label
    $('.contract_date_range').each(function () {
        var element = $(this);
        _price_policy_detail.AddOrUpdateContractLabel(element);
    });
});


$('body').on('apply.daterangepicker', '.campaign_from_date', function (ev, picker) {

    var campaign_element = $(this);
    var campaign_fromDate = campaign_element.data('daterangepicker').startDate._d;
    var apply_fromdate = _price_policy_detail.GetDayText(campaign_fromDate);

    if (campaign_fromDate > $('#campaign_to_date').data('daterangepicker').startDate._d) {
        _msgalert.error('Thời gian bắt đầu chiến dịch không được lớn hơn thời gian kết thúc chiến dịch.');
        campaign_element.val(_price_policy_detail.FromDate).change();
        return;
    }

    var date_range_status = {
        BelowOrAbove: false,
        ElementError: null
    };
    $('.price_detail_input_fromdate').each(function () {
        var element = $(this);
        var element_fromdate = element.data('daterangepicker').startDate._d;
        if (element_fromdate < campaign_fromDate) {

            date_range_status.BelowOrAbove = true;
            date_range_status.ElementError = element;
            return false;
        }
    });
    if (date_range_status.BelowOrAbove == true) {
        _msgalert.error(' Ngày bắt đầu hiệu lực chiến dịch phải nhỏ hơn hoặc bằng ngày bắt đầu hiệu lực của tất cả chính sách giá');
        _price_policy_detail.ExpandToShowElement(date_range_status.ElementError);
        return;
    }
    else {
        _price_policy_detail.FromDate = apply_fromdate;
        _price_policy_detail.CampaignDateApplyToAllPolicy(_price_policy_detail.FromDate, _price_policy_detail.ToDate);
        //-- Update Contract Label
        $('.contract_date_range').each(function () {
            var element = $(this);
            _price_policy_detail.AddOrUpdateContractLabel(element);
        });
    }

});
$('body').on('apply.daterangepicker', '.campaign_to_date', function (ev, picker) {
    var campaign_element = $(this);

    var campaign_ToDate = campaign_element.data('daterangepicker').startDate._d;
    var apply_todate = _price_policy_detail.GetDayText(campaign_ToDate);

    if (campaign_ToDate < $('#campaign_from_date').data('daterangepicker').startDate._d) {
        _msgalert.error('Thời gian kết thúc chiến dịch không được nhỏ hơn thời gian bắt đầu chiến dịch.');
        campaign_element.val(_price_policy_detail.ToDate).change();
        return;
    }

    var date_range_status = {
        BelowOrAbove: false,
        ElementError: null
    };

    $('.price_detail_input_todate').each(function () {

        var element = $(this);
        var element_todate = element.data('daterangepicker').startDate._d;
        if (element_todate > campaign_ToDate) {
            date_range_status.BelowOrAbove = true;
            date_range_status.ElementError = element;
            return false;
        }
    });
    if (date_range_status.BelowOrAbove == true) {
        _msgalert.error(' Ngày kết thúc hiệu lực chiến dịch phải lớn hơn hoặc bằng ngày kết thúc hiệu lực của tất cả chính sách giá');
        _price_policy_detail.ExpandToShowElement(date_range_status.ElementError);
        return;
    }
    else {
        _price_policy_detail.ToDate = apply_todate;
        _price_policy_detail.CampaignDateApplyToAllPolicy(_price_policy_detail.FromDate, _price_policy_detail.ToDate);
        //-- Update Contract Label
        $('.contract_date_range').each(function () {
            var element = $(this);
            _price_policy_detail.AddOrUpdateContractLabel(element);
        });
    }
});
$('body').on('apply.daterangepicker', '.price_detail_input_fromdate', function (ev, picker) {
    var price_detail_element = $(this);
    var price_detail_from_date = price_detail_element.data('daterangepicker').startDate._d;

    var price_detail_to_date = undefined;
    if (price_detail_element.closest('.level_4').find('.price_detail_input_todate').length > 0) {
        price_detail_to_date = price_detail_element.closest('.level_4').find('.price_detail_input_todate').data('daterangepicker').startDate._d;
    }
    else {
        price_detail_to_date = price_detail_element.closest('.add_new_block').find('.price_detail_input_todate').data('daterangepicker').startDate._d;
    }

    if (price_detail_to_date != undefined && price_detail_from_date > price_detail_to_date) {
        _msgalert.error('Thời gian bắt đầu chính sách giá không được lớn hơn thời gian kết thúc chính sách giá.');
        return;
    }

    var is_in_date = false
    price_detail_element.closest('.level_4_block').find('.level_4').each(function () {
        
        var block_element = $(this);
        if (price_detail_element.closest('.level_4').is(block_element)) return;
        var block_from_date = block_element.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
        var block_to_date = block_element.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
        if (block_from_date < price_detail_from_date && price_detail_from_date < block_to_date) {
            is_in_date = true;
            return false;
        }
        if ((block_from_date <= price_detail_from_date && price_detail_from_date <= block_to_date)
            || (block_from_date <= price_detail_to_date && price_detail_to_date <= block_to_date)
            || (price_detail_from_date <= block_from_date && block_from_date <= price_detail_to_date)
            || (price_detail_from_date <= block_to_date && block_to_date <= price_detail_to_date)) {
            is_in_date = true;
            

            return false;
        }
    });
    if (is_in_date) {
        _msgalert.error('Khoảng thời gian của chính sách giá không được nằm trong khoảng thời gian của chính sách giá khác trong cùng 01 phòng thuộc 01 gói.');
        return;
    }

    //-- Update Contract Label
    var label_contract = price_detail_element.closest('li').find('.contract_date_range');
    _price_policy_detail.AddOrUpdateContractLabel(label_contract);
});
$('body').on('apply.daterangepicker', '.price_detail_input_todate', function (ev, picker) {
    var price_detail_element = $(this);
    var price_detail_to_date = price_detail_element.data('daterangepicker').startDate._d;
    var price_detail_from_date = undefined;
    if (price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').length > 0) {
        price_detail_from_date = price_detail_element.closest('.level_4').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
    }
    else {
        price_detail_from_date = price_detail_element.closest('.add_new_block').find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
    }


    if (price_detail_to_date < price_detail_from_date) {
        _msgalert.error('Thời gian kết thúc chiến dịch không được nhỏ hơn thời gian bắt đầu chiến dịch.');
        return;
    }

    var is_in_date = false;
    price_detail_element.closest('.level_4_block').find('.level_4').each(function () {
        var block_element = $(this);

        if (price_detail_element.closest('.level_4').is(block_element)) return;
        var block_from_date = block_element.find('.price_detail_input_fromdate').data('daterangepicker').startDate._d;
        var block_to_date = block_element.find('.price_detail_input_todate').data('daterangepicker').startDate._d;
        if ((block_from_date <= price_detail_from_date && price_detail_from_date <= block_to_date)
            || (block_from_date <= price_detail_to_date && price_detail_to_date <= block_to_date)
            || (price_detail_from_date <= block_from_date && block_from_date <= price_detail_to_date)
            || (price_detail_from_date <= block_to_date && block_to_date <= price_detail_to_date)) {
            is_in_date = true;
            

            return false;
        }
    });
    if (is_in_date) {
        _msgalert.error('Khoảng thời gian của chính sách giá không được nằm trong khoảng thời gian của chính sách giá khác trong cùng 01 phòng thuộc 01 gói.');
        return;
    }

    //-- Update Contract Label
    var label_contract = price_detail_element.closest('li').find('.contract_date_range');
    _price_policy_detail.AddOrUpdateContractLabel(label_contract);
});
function delay_callback(callback, ms) {
    var timer = 0;
    return function () {
        var context = this, args = arguments;
        clearTimeout(timer);
        timer = setTimeout(function () {
            callback.apply(context, args);
        }, ms || 0);
    };
}
