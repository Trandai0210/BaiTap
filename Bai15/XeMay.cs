using System;
using System.Collections.Generic;
using System.Text;

namespace Bai15
{
    class XeMay:PTGT
    {
        protected double congSuat;
        public double CongSuat
        {
            get { return congSuat; }
            set { congSuat = value; }
        }

        public XeMay()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("-Cong suat");
            congSuat = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Cong suat: " + congSuat);
        }
    }
}
