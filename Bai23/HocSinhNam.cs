using System;
using System.Collections.Generic;
using System.Text;

namespace Bai23
{
    class HocSinhNam:HocSinh
    {
        protected double diemKyThuat;
        public double DiemKyThuat
        {
            get { return diemKyThuat; }
            set
            {
                if (value <= 10)
                    diemKyThuat = value;
            }
        }

        public HocSinhNam()
        {
            
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t+Nhap diem ky thuat: ");
            diemKyThuat = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t+Diem ky thuat: " + diemKyThuat);
        }
    }
}
