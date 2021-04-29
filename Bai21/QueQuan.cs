using System;
using System.Collections.Generic;
using System.Text;

namespace Bai21
{
    class QueQuan
    {
        protected string xa;
        public string Xa
        {
            get { return xa; }
            set { xa = value; }
        }

        protected string huyen;
        public string Huyen
        {
            get { return huyen; }
            set { huyen = value; }
        }

        protected string tinh;
        public string Tinh
        {
            get { return tinh; }
            set { tinh = value; }
        }

        public QueQuan()
        {

        }

        public void Nhap()
        {
            Console.Write("-Nhap xa: ");
            xa = Console.ReadLine();
            Console.Write("-Nhap huyen: ");
            huyen = Console.ReadLine();
            Console.Write("-Nhap tinh: ");
            tinh = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.Write(xa+ ", " + huyen +", " + tinh);
        }
    }
}
