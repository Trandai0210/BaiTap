using System;

namespace Bai13
{
    class SoPhuc
    {
        protected double phanThuc;
        public double PhanThuc
        {
            get { return phanThuc; }
            set { phanThuc = value; }
        }

        protected double phanAo;
        public double PhanAo
        {
            get { return phanAo; }
            set { phanAo = value; }
        }

        public SoPhuc()
        {

        }

        public SoPhuc(double a, double b)
        {
            PhanThuc = a;
            PhanAo = b;
        }
        public void Nhap()
        {
            Console.WriteLine("-Nhap phan thuc: ");
            phanThuc = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap phan ao: ");
            PhanAo = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            if (phanAo < 0)
                Console.WriteLine("So phuc: " + phanThuc + " - " + phanAo + "i");
            else
            {
                if (phanAo > 0)
                    Console.WriteLine("So phuc: " + phanThuc + " + " + phanAo + "i");
                else
                    Console.WriteLine("So phuc: " + phanThuc);
            }
        }

        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.phanThuc = a.phanThuc + b.phanThuc;
            kq.phanAo = a.phanAo + b.phanAo;
            return kq;
        }

        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.phanThuc = a.phanThuc - b.phanThuc;
            kq.phanAo = a.phanAo - b.phanAo;
            return kq;
        }

        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.phanThuc = a.phanThuc * b.phanThuc - a.phanAo * b.phanAo;
            kq.phanAo = a.phanThuc * b.phanThuc + a.phanAo * b.phanAo;
            return kq;
        }

        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            SoPhuc w = new SoPhuc();
            w.phanThuc = a.phanThuc * a.phanThuc - a.phanAo * a.phanAo;
            w.phanAo = 2 * a.phanThuc * a.phanAo;
            kq = w * b;
            return kq;
        }
    }
}
