using System;
using System.Collections.Generic;
using System.Text;

namespace Bai22
{
    class HoiVienCoGiaDinh:HoiVien
    {
        protected string hoTenVo;
        public string HoTenVo
        {
            get { return hoTenVo; }
            set { hoTenVo = value; }
        }

        protected DateTime ngayCuoi = new DateTime();
        public DateTime NgayCuoi
        {
            get { return ngayCuoi; }
            set { ngayCuoi = value; }
        }

        public HoiVienCoGiaDinh()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t+ Nhap ho ten vo: ");
            hoTenVo = Console.ReadLine();
            Console.Write("\t+ Nhap ngay cuoi: ");
            NgayCuoi = DateTime.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t+ Ho ten vo: " + hoTenVo);
            Console.WriteLine("\t+ Ngay cuoi: " + NgayCuoi);
        }
    }
}
