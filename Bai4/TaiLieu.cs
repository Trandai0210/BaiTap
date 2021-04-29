using System;

namespace Bai4
{
    class TaiLieu
    {
        protected string maTL;
        public string MaTL
        {
            get { return maTL; }
            set { maTL = value; }
        }

        protected string tenNXB;
        protected string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }

        protected int soBanPhatHanh;
        public int SoBanPhanHanh
        {
            get { return soBanPhatHanh; }
            set { soBanPhatHanh = value; }
        }

        public TaiLieu()
        {

        }

        public virtual void Nhap()
        {
            Console.WriteLine("-Nhap ma tai lieu: ");
            MaTL = Console.ReadLine();
            Console.WriteLine("-Nhap ten nha xuat ban: ");
            TenNXB = Console.ReadLine();
            Console.WriteLine("-Nhap so ban phat hanh:");
            SoBanPhanHanh = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("-Ma tai lieu: " + MaTL);
            Console.WriteLine("-Ten nha xuat ban: " + TenNXB);
            Console.WriteLine("-So ban phat hanh: " + SoBanPhanHanh);
        }
    }
}
