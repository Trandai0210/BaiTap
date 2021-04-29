using System;

namespace Bai4
{
    class Sach : TaiLieu
    {
        protected string tenTacGia;
        public string TenTacGia
        {
            get { return tenTacGia; }
            set { tenTacGia = value; }
        }

        protected int soTrang;
        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }

        public Sach()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("-Nhap ten tac gia: ");
            TenTacGia = Console.ReadLine();
            Console.WriteLine("-Nhap so trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Ten tac gia: " + TenTacGia);
            Console.WriteLine("-So trang: " + SoTrang);
        }
    }
}
