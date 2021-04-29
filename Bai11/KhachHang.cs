using System;

namespace Bai11
{
    class KhachHang
    {
        protected string hoTenCH;
        public string HoTenCH
        {
            get { return hoTenCH; }
            set { hoTenCH = value; }
        }

        protected string soNha;
        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }

        protected string maSoCT;
        public string MaSoCT
        {
            get { return maSoCT; }
            set { maSoCT = value; }
        }

        public KhachHang()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap ho ten chu ho: ");
            HoTenCH = Console.ReadLine();
            Console.WriteLine("-Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.WriteLine("-Nhap ma so cong to: ");
            maSoCT = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("-Ho ten: " + HoTenCH);
            Console.WriteLine("-So nha: " + SoNha);
            Console.WriteLine("-Ma so cong to: " + MaSoCT);
        }
    }
}
