using System;
using System.Collections.Generic;
using System.Text;

namespace Bai19
{
    class Diem
    {
        protected double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        protected double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Diem()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap hoanh do x: ");
            this.x = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap tung do y: ");
            this.y = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("({0},{1})\n",x,y);
        }

        public double KhoangCach(Diem A)
        {
            return Math.Sqrt((this.x - A.x) * (this.x - A.x) + (this.y - A.y) * (this.y - A.y));
        }
    }
}
