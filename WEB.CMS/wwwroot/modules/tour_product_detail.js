var _tour_product_detail = {
    Init: function () {
        this.validImageTypes = ['image/gif', 'image/jpeg', 'image/png'];
        this.validImageSize = 5 * 1024 * 1024;
        this.noImageSrc = "/images/icons/noimage.png";
    },

    GetFormData: function ($form) {
        var unindexed_array = $form.serializeArray();
        var indexed_array = {};

        $.map(unindexed_array, function (n, i) {
            indexed_array[n['name']] = n['value'];
        });

        return indexed_array;
    },

    OnSave: function (status = 0) {
        let Form = $('#form_tour_product');

        if (status == 7) {
            Form.validate({
                rules: {
                    TourName: "required",
                },
                messages: {
                    TourName: "Vui lòng nhập thông tin",
                }
            });
        } else {
            Form.validate({
                rules: {
                    TourName: "required",
                    Days: "required",
                    SupplierId: "required",
                    TourType: "required",
                    OrganizingType: "required",
                    Price: "required",
                    Star: "required",
                    StartPoint: "required",
                    DateDeparture:"required"
                },
                messages: {
                    TourName: "Vui lòng nhập thông tin",
                    Days: "Vui lòng chọn số ngày",
                    SupplierId: "Vui lòng chọn nhà cung cấp",
                    TourType: "Vui lòng chọn loại tour",
                    OrganizingType: "Vui lòng chọn hình thức tour",
                    Price: "Vui lòng nhập giá gốc",
                    Star: "Vui lòng chọn hạng sao",
                    StartPoint: "Vui lòng chọn điểm đi",
                    DateDeparture: "Vui lòng nhập lịch khởi hành",
                }
            });
        }

        if (!Form.valid()) {
            _msgalert.error("Vui lòng nhập chính xác thông tin tour");
            return;
        }

        let formData = this.GetFormData(Form);

        let avatar = $('#avatar_image').attr('src');
        formData.Avatar = (avatar != null && avatar != "") ? avatar : "";

        if ((formData.Avatar == null || formData.Avatar == "") && status == 0) {
            _msgalert.error("Vui lòng chọn và tải ảnh đại diện");
            return;
        }

        let other_image = [];
        $('#grid_image_preview .img_other').each(function () {
            let image_item = $(this);
            other_image.push(image_item.attr('src'));
        });
        formData.OtherImages = other_image;

        if (other_image.length <= 0 && status == 0) {
            _msgalert.error("Vui lòng chọn và tải ảnh mô tả chi tiết ở tab ảnh để đăng bài");
            return;
        }

        let transport_type = [];
        $('.ckb_transport_type:checked').each(function () {
            let seft = $(this);
            transport_type.push(seft.val());
        });
        if (transport_type.length <= 0 && status == 0) {
            _msgalert.error("Vui lòng check chọn ít nhất một loại phương tiện di chuyển ");
            return;
        }
        formData.Transportation = transport_type.join(',');

        let schedule = []
        let schedule_element = $('#block_insert_day_description .form-group');
        let valid_day_description = true;
        if (schedule_element.length > 0) {
            let day = 1;
            schedule_element.each(function () {
                let item_schedule = $(this);
                let title = item_schedule.find('.day_title').val();
                let description = tinyMCE.get(`day_${day}_description`).getContent();

                if (!title || title == null || title == "") {
                    valid_day_description = false;
                }

                schedule.push({
                    day_num: day,
                    day_title: title,
                    day_description: description
                });

                day++;
            });
        }

        if (valid_day_description) {
            formData.Schedule = JSON.stringify(schedule);
        } else {
            if (status == 0) {
                _msgalert.error("Vui lòng nhập đẩy đủ thông tin lịch trình các ngày");
                return;
            }
        }

        let endPoints = $('#EndPoints').val();
        if ((!endPoints || endPoints == null) && status == 0) {
            _msgalert.error("Vui lòng chọn điểm đến");
            return;
        }

        formData.EndPoints = endPoints;
        formData.Description = tinyMCE.get(`Description`).getContent();
        formData.Include = tinyMCE.get(`Include`).getContent();
        formData.Exclude = tinyMCE.get(`Exclude`).getContent();
        formData.Refund = tinyMCE.get(`Refund`).getContent();
        formData.Surcharge = tinyMCE.get(`Surcharge`).getContent();
        formData.Note = tinyMCE.get(`Note`).getContent();
        formData.OldPrice = isNaN(formData.OldPrice) ? ConvertMoneyToNumber(formData.OldPrice) : null;
        formData.Price = isNaN(formData.Price) ? ConvertMoneyToNumber(formData.Price) : 0;
        formData.Status = status;

        if (formData.Price <= 0 && status == 0) {
            _msgalert.error("Giá gốc Tour phải lớn hơn 0");
            return;
        }

        let url = '/TourProduct/UpsertTourProduct';

        console.log(formData);
        _ajax_caller.postJson(url, formData, function (result) {
            if (result.isSuccess) {
                _msgalert.success(result.message);
                window.location.href = "/TourProduct";
            } else {
                _msgalert.error(result.message);
            }
        });
    },

    OnChangeAvartar: function () {
        const preview = document.querySelector('.img-preview');
        const file = document.querySelector('input[name=ImgAvatar]').files[0];
        const fileType = file['type'];

        if (!this.validImageTypes.includes(fileType)) {
            _msgalert.error("File tải lên không đúng định dạng ảnh(gif, jpeg, png)");
            return false;
        }

        if (this.validImageSize < file.size) {
            _msgalert.error("Ảnh tải lên phải có dung lượng bé hơn hoặc bằng 5MB.");
            return false;
        }

        const reader = new FileReader();
        reader.addEventListener("load", function () {
            preview.src = reader.result;
            $('#avatar_image').removeClass('mfp-hide');
            $('#ava_upload').addClass('mfp-hide');
        }, false);
        if (file) {
            reader.readAsDataURL(file);
        }
    },

    OnChangeDateCount: function (num) {
        let grid_appending = $('#block_insert_day_description');
        let html = '';
        if (num > 0) {
            for (let i = 1; i <= num; i++) {
                let ele_id = `day_${i}_description`;
                html += `
                <div class="form-group col-12">
                    <label class="lbl">Ngày ${i} <sup class="red">*</sup></label>
                    <div class="wrap_input mb10">
                        <input class="form-control day_title" placeholder="Tiêu đề" />
                    </div>
                    <div class="wrap_input">
                        <textarea class="form-control day_description" id="${ele_id}" style="resize:none;"></textarea>
                    </div>
                </div>`;
            }
        }

        grid_appending.html(html);

        if ($('.day_description').length > 0) {
            tinymce.remove(`.day_description`);
            _common.tinyMce(`.day_description`, 300);
        }

    },

    OnAddImage: function () {
        const files = document.querySelector('input[name=ImageData]').files;
        let grid_image_preview = $('#grid_image_preview');

        for (let file of files) {

            if (!this.validImageTypes.includes(file['type'])) {
                _msgalert.error("File tải lên không đúng định dạng ảnh (gif, jpeg, png,...)");
                break;
            }

            if (this.validImageSize < file.size) {
                _msgalert.error("Ảnh tải lên vượt quá dung lượng cho phép (5MB).");
                break;
            }

            const reader = new FileReader();
            reader.addEventListener("load", function () {

                let is_exist = grid_image_preview.find(`.image_preview[data-name="${file.name}"]`).length > 0 ? true : false;
                if (!is_exist) {
                    let html = `<div class="col-md-2 col-6 mb10 image_preview" data-name="${file.name}">
                     <div class="choose-ava">
                     <img class="img_other" src="${reader.result}">
                     <button type="button" class="delete" onclick="this.closest('.image_preview').remove();">×</button>
                     </div>
                     </div>`;
                    grid_image_preview.append(html);
                }

            }, false);

            if (file) {
                reader.readAsDataURL(file);
            }
        }
    },
}

$('body').on('change', '#form_tour_product #Days', function () {
    let seft = $(this);
    let value = seft.val() != "" ? seft.val() : 0;
    _tour_product_detail.OnChangeDateCount(value);
});

$('#tab-thongtin #TourType').change(function () {
    let type = $(this).val();
    let endpoint_element = $('#tab-thongtin #EndPoints');

    let url = '/TourProduct/GetEnpointListByType';
    _ajax_caller.get(url, { type: type }, function (result) {

        if (result && result.length > 0) {
            let html_result = "";
            result.map((item) => {
                html_result += `<option value="${item.id}">${item.name}</option>`
            });

            endpoint_element.html(html_result);
            endpoint_element.select2();
        }
    });
});

$(document).ready(function () {
    $('input').attr('autocomplete', 'off');
    _tour_product_detail.Init();

    $('.select2_modal').select2();

    if ($('.day_description').length > 0) {
        _common.tinyMce(`.day_description`, 300);
    }

    _common.tinyMce(`#Description`, 300);
    _common.tinyMce(`#Description`, 300);
    _common.tinyMce(`#Include`, 300);
    _common.tinyMce(`#Exclude`, 300);
    _common.tinyMce(`#Refund`, 300);
    _common.tinyMce(`#Surcharge`, 300);
    _common.tinyMce(`#Note`, 300);

    $("#SupplierId").select2({
        //theme: 'bootstrap4',
        placeholder: "Nhà cung cấp",
        ajax: {
            url: "/Supplier/Suggest",
            type: "get",
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
