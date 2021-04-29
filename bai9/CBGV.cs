using System;

namespace Bai9
{
    class CBGV
    {
        protected double luongCung;
        public double LuongCung
        {
            get { return luongCung; }
            set { luongCung = value; }
        }

        protected double thuong;
        public double Thuong
        {
            get { return thuong; }
            set { thuong = value; }
        }

        protected double phat;
        public double Phat
        {
            get { return phat; }
            set { phat = value; }
        }

        protected double luongThucLinh;
        public double LuongThucLinh
        {
            get { return luongThucLinh; }
            set { luongThucLinh = value; }
        }

        protected Nguoi nguoi;
        public Nguoi Nguoi
        {
            get { return nguoi; }
            set { nguoi = value; }
        }
        public CBGV()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap luong cung: ");
            LuongCung = double.Parse(Console.ReadLine());
            Console.WriteLine("-Thuong: ");
            Thuong = double.Parse(Console.ReadLine());
            Console.WriteLine("-Phat: ");
            Phat = double.Parse(Console.ReadLine());
            LuongThucLinh = LuongCung + Thuong - Phat;
            nguoi = new Nguoi();
            nguoi.Nhap();
        }

        public void Xuat()
        {
            nguoi.Xuat();
            Console.WriteLine("-Luong Thuc Linh: " + LuongThucLinh);
        }
    }
}
