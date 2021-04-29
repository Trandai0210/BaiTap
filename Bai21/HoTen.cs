using System;
using System.Collections.Generic;
using System.Text;

namespace Bai21
{
    class HoTen
    {
        protected string ho;
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }

        protected string tenDem;
        public string TenDem
        {
            get { return tenDem; }
            set { tenDem = value; }
        }

        protected string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public HoTen()
        {

        }

        public void Nhap()
        {
            Console.Write("-Nhap ho: ");
            ho = Console.ReadLine();
            Console.Write("-Nhap ten dem: ");
            tenDem = Console.ReadLine();
            Console.Write("-Nhap ten: ");
            ten = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.Write(ho + " " + tenDem+" "+ten);
        }
    }
}
