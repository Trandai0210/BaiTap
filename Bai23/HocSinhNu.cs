using System;
using System.Collections.Generic;
using System.Text;

namespace Bai23
{
    class HocSinhNu:HocSinh
    {
        protected double diemNuCong;
        public double DiemNuCong
        {
            get { return diemNuCong; }
            set
            {
                if (value <= 10)
                    diemNuCong = value;
            }
        }
        public HocSinhNu()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t+Nhap diem nu cong: ");
            diemNuCong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t+Diem nu cong: " + diemNuCong);
        }
    }
}
