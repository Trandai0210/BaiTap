using System;

namespace Bai4
{
    class TapChi : TaiLieu
    {
        private int soPhatHanh;
        public int SoPhatHanh
        {
            get { return soPhatHanh; }
            set { soPhatHanh = value; }
        }

        private int thangPhatHanh;
        public int ThangPhatHanh
        {
            get { return thangPhatHanh; }
            set
            {
                if (value >= 1 && value <= 12)
                    thangPhatHanh = value;
            }
        }

        public TapChi()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("-Nhap so phat hanh: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap thang phat hanh: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-So phat hanh: " + SoPhatHanh);
            Console.WriteLine("-Thang phat hanh: " + ThangPhatHanh);
        }
    }
}
