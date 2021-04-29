using System;

namespace Bai7
{
    class KhachSan
    {
        protected int soNgayTro;
        public int SoNgayTro
        {
            get { return soNgayTro; }
            set { soNgayTro = value; }
        }

        protected int loaiPhong;
        public int LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }

        protected double giaPhong;
        public double GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }

        protected Nguoi nguois;
        public Nguoi Nguois
        {
            get { return nguois; }
            set { nguois = value; }
        }

        public KhachSan()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap so ngay tro: ");
            SoNgayTro = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap loai phong: ");
            LoaiPhong = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap gia phong: ");
            GiaPhong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin nguoi trong phong: ");
            nguois = new Nguoi();
            nguois.Nhap();
        }

        public void Xuat()
        {
            Console.WriteLine("-Ngay tro: " + SoNgayTro);
            Console.WriteLine("-Loai phong: " + loaiPhong);
            Console.WriteLine("-Gia Phong: " + GiaPhong);
            Console.WriteLine("-Thong tin khach tro: ");
            nguois.Xuat();
        }

        public double TienPhong()
        {
            return SoNgayTro * GiaPhong;
        }
    }
}
