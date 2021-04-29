using System;
using System.Collections.Generic;
using System.Text;

namespace Bai15
{
    class PTGT
    {
        protected string hangSX;
        public string HangSX
        {
            get { return hangSX; }
            set { hangSX = value; }
        }

        protected int namSX;
        public int NamSX
        {
            get { return namSX; }
            set { namSX = value; }
        }

        protected double giaBan;
        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        protected string mau;
        public string Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public PTGT()
        {

        }
        public virtual void Nhap()
        {
            Console.Write("-Hang san xuat: ");
            hangSX = Console.ReadLine();
            Console.Write("-Nam san xuat: ");
            namSX = int.Parse(Console.ReadLine());
            Console.Write("-Gia ban: ");
            giaBan = double.Parse(Console.ReadLine());
            Console.Write("-Mau: ");
            mau = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("-Hang san xuat: " + hangSX);
            Console.WriteLine("-Nam san xuat: " + namSX);
            Console.WriteLine("-Gia Ban: " + giaBan);
            Console.WriteLine("-Mau: " + mau);
        }
    }
}
