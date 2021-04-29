using System;
using System.Collections.Generic;
using System.Text;

namespace Bai19
{
    class HinhTron
    {
        protected Diem o;
        public Diem O
        {
            get { return o; }
            set { o = value; }
        }

        protected double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public HinhTron()
        {

        }

        public HinhTron(Diem d, double bk)
        {
            O = d;
            radius = bk;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap diem: ");
            o = new Diem();
            o.Nhap();
            Console.WriteLine("Nhap ban kinh: ");
            radius = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("-Diem: ");
            o.Xuat();
            Console.WriteLine("-Ban kinh: " + radius);
        }

        public double ChuVi()
        {
            return 2 * Math.PI * radius;
        }

        public double DienTich()
        {
            return Math.PI * radius * radius;
        }
    }
}
