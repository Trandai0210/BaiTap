using System;
using System.Collections.Generic;
using System.Text;

namespace Bai17
{
    class TamGiac:DaGiac
    {


        public TamGiac()
        {

        }
        public override double ChuVi()
        {
            double sum = 0;
            for(int i = 0; i < soCanh; i++)
            {
                sum += kichThuoc[i];
            }
            return sum;
        }
        public double DienTich()

        {
            double p = this.ChuVi() / 2;
            double s = Math.Sqrt(p * (p - kichThuoc[0]) * (p - kichThuoc[1]) * (p - kichThuoc[2]));
            return s;
        }
    }
}
