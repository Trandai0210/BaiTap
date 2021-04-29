using System;

namespace Bai8
{
    class Nguoi
    {
        protected string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        protected int tuoi;
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }

        protected int namSinh;
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        protected string queQuan;
        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        protected int gioiTinh;
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public Nguoi()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("-Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap nam sinh:");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.WriteLine("-Nhap gioi tinh: ");
            GioiTinh = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("-Ho ten: " + HoTen);
            Console.WriteLine("-Tuoi: " + Tuoi);
            Console.WriteLine("-Nam sinh: " + NamSinh);
            Console.WriteLine("-Que quan: " + QueQuan);
            Console.WriteLine("-Gioi Tinh: " + GioiTinh);
        }
    }
}
