using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Utilities.Contants
{
    public static class NotifyLabelName
    {
        public static string getModuleName(int module_type)
        {
            switch (module_type)
            {
                case (Int16)ModuleType.DON_HANG:
                    return "đơn hàng";
                case (Int16)ModuleType.PHIEU_YEU_CAU_CHI:
                    return "phiếu yêu cầu chi";
                case (Int16)ModuleType.HOP_DONG:
                    return "hợp đồng";
                default:
                    return "n/a";
            }
        }
        public static string getActionName(int action_type)
        {
            switch (action_type)
            {
                case (Int16)ActionType.TAO_MOI:
                    return "tạo mới";
                case (Int16)ActionType.DUYET:
                    return "kiểm duyệt";
                case (Int16)ActionType.GUI_DUYET:
                    return "gửi duyệt";
                case (Int16)ActionType.TU_CHOI:
                    return "từ chối";
                case (Int16)ActionType.HUY:
                    return "hủy";
                case (Int16)ActionType.TRA_CODE:
                    return "trả code";
                case (Int16)ActionType.QUYET_TOAN:
                    return "quyết toán";
                case (Int16)ActionType.NHAN_TRIEN_KHAI:
                    return "nhận triển khai";
                default:
                    return "n/a";
            }
        }
    }
    public enum ModuleType
    {
        PHIEU_YEU_CAU_CHI = 0,
        DON_HANG = 1,
        HOP_DONG = 2,
        KHACH_HANG = 3,
        PHIEU_THU = 4,
        DICH_VU = 5,
    }
    public enum ActionType
    {
        TAO_MOI = 0,
        DUYET = 1,
        TU_CHOI = 2,
        HUY = 3,
        TRA_CODE = 4,
        QUYET_TOAN = 5,
        NHAN_TRIEN_KHAI = 6,
        GUI_DUYET = 7,
        HOAN_THANH = 8,
        TAO_YEU_CAU_CHI = 9,
        TAO_MOI_PHIEU_THU = 10,
        DUYET_DICH_VU = 11,
        DA_DUYET = 12,
        TU_CHOI_HOP_DONG = 13,
        DUYET_YEU_CAU_CHI = 14,
        BO_DUYET_YEU_CAU_CHI = 15,
        TU_CHOI_DUYET_YEU_CAU_CHI = 16,

    }

}