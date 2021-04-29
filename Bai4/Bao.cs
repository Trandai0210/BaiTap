using System;

namespace Bai4
{
    class Bao : TaiLieu
    {
        private DateTime ngayPhatHanh;
        public DateTime NgayPhatHanh
        {
            get { return ngayPhatHanh; }
            set { ngayPhatHanh = value; }
        }
    }
}
