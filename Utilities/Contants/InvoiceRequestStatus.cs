using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Contants
{
   public class InvoiceRequestStatus
    {
        public static int Luu_nhap = 0; //Lưu nháp
        public static int Tu_choi = 1; //Từ chối
        public static int Cho_TBP_duyet = 2;//Chờ TBP duyệt
        public static int Da_duyet = 4; //Đã duyệt
        public static int Hoan_thanh = 5; //Hoàn thành
        public static int Cho_KT_duyet = 6; //Chờ kế toán duyệt

    }
}
