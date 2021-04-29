using System;

namespace Bai3
{
    class CongNhan : CanBo
    {
        protected string bac;
        public string Bac
        {
            get { return bac; }
            set { bac = value; }
        }

        public CongNhan()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("-Nhap bac: ");
            bac = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Bac: " + bac);
        }
    }
}
