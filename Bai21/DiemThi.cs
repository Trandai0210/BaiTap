using System;
using System.Collections.Generic;
using System.Text;

namespace Bai21
{
    class DiemThi
    {
        protected double dToan;
        public double DToan
        {
            get { return dToan; }
            set { dToan = value; }
        }

        protected double dLy;
        public double DLy
        {
            get { return dLy; }
            set { dLy = value; }
        }

        protected double dHoa;
        public double DHoa
        {
            get { return dHoa; }
            set { dHoa = value; }
        }

        public DiemThi()
        {

        }
        public void Nhap()
        {
            Console.Write("-Nhap diem toan: ");
            dToan = double.Parse(Console.ReadLine());
            Console.Write("-Nhap diem ly: ");
            dLy = double.Parse(Console.ReadLine());
            Console.Write("-Nhap diem hoa: ");
            dHoa = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write(dToan + "\t\t\t\t" + dLy + "\t\t\t" + dHoa+"\n");
        }
    }
}
