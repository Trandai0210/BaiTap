using System;
using System.Collections.Generic;
using System.Text;

namespace Bai16
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
        public PhanSo(int tu,int mau)
        {
            tuSo = tu;
            mauSo = mau;
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
            Console.WriteLine("-Phan so: " + tuSo+"/"+ mauSo);
        }


        public void RutGon()
        {
            for(int i = (int)mauSo; i > 1; i--)
            {
                if(tuSo % i == 0 && mauSo % i == 0)
                {
                    tuSo = tuSo / i;
                    mauSo = mauSo / i;
                }
            }
        }
        public static PhanSo operator +(PhanSo ps1,PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            kq.mauSo = ps1.mauSo * ps2.mauSo;
            return kq;
        }

        public static PhanSo operator -(PhanSo ps1,PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            kq.mauSo = ps1.mauSo * ps2.mauSo;
            return kq;
        }

        public static PhanSo operator *(PhanSo ps1,PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = ps1.tuSo * ps2.tuSo;
            kq.mauSo = ps1.mauSo * ps2.mauSo;
            return kq;
        }

        public static PhanSo operator /(PhanSo ps1,PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = ps1.tuSo * ps2.mauSo;
            kq.mauSo = ps1.mauSo * ps2.tuSo;
            return kq;
        }
    }
}
