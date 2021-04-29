using System;
using System.Collections.Generic;
using System.Text;

namespace Bai18
{
    class TamGiac
    {
        protected Diem diemA;
        public Diem DiemA
        {
            get { return diemA; }
            set { diemA = value; }
        }
        protected Diem diemB;
        public Diem DiemB
        {
            get { return diemB; }
            set { diemB = value; }
        }
        protected Diem diemC;
        public Diem DiemC
        {
            get { return diemC; }
            set { diemC = value; }
        }

        public TamGiac()
        {

        }

        public TamGiac(Diem d1, Diem d2, Diem d3)
        {
            diemA = d1;
            diemB = d2;
            diemC = d3;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap diem 1: ");
            diemA = new Diem();
            diemA.Nhap();
            Console.WriteLine("-Nhap diem 2: ");
            diemB = new Diem();
            diemB.Nhap();
            Console.WriteLine("-Nhap diem 3: ");
            diemC = new Diem();
            diemC.Nhap();
        }
        public double ChuVi()
        {
            double sum = 0;
            sum += diemA.KhoangCach(DiemC) + diemA.KhoangCach(DiemB) + diemB.KhoangCach(DiemC);
            return sum;
        }

        public double DienTich()
        {
            double p = this.ChuVi() / 2;
            double AB = diemA.KhoangCach(DiemB);
            double AC = diemA.KhoangCach(DiemC);
            double BC = diemB.KhoangCach(DiemC);
            double s = 0;
            if (AB*AB < AC*AC + BC*BC && AC*AC < AB*AB + BC*BC && BC < AB*AB + AC * AC)
            {
                s = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            }
            
            return s;
        }
    }
}
