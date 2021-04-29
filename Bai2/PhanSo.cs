using System;

namespace Bai2
{
    class PhanSo
    {
        protected double tuSo;
        public double TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        protected double mauSo;
        public double MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }

        public PhanSo()
        {

        }

        public PhanSo(double tuSo, double mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap tu so: ");
            tuSo = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap mau so: ");
            mauSo = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Phan so: " + tuSo + "/" + mauSo);
        }

        public bool KiemTra()
        {
            if (mauSo == 1)
            {
                return true;
            }
            for (int i = 2; i <= mauSo; i++)
            {
                if (tuSo % i == 0 && mauSo % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void ToiGian()
        {
            for (int i = (int)mauSo; i > 1; i--)
            {

                if (tuSo % i == 0 && mauSo % i == 0)
                {
                    tuSo = tuSo / i;
                    mauSo = mauSo / i;
                }
            }
        }

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tong = new PhanSo();
            tong.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            tong.mauSo = ps1.mauSo * ps2.mauSo;
            return tong;
        }

        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo hieu = new PhanSo();
            hieu.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            hieu.mauSo = ps1.mauSo * ps2.mauSo;
            return hieu;
        }

        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tich = new PhanSo();
            tich.tuSo = ps1.tuSo * ps2.mauSo;
            tich.mauSo = ps2.tuSo * ps1.mauSo;
            return tich;
        }

        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tich = new PhanSo();
            tich.tuSo = ps1.tuSo * ps2.tuSo;
            tich.mauSo = ps1.mauSo * ps2.mauSo;
            return tich;
        }
    }
}
