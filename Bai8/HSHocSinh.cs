using System;

namespace Bai8
{
    class HSHocSinh
    {
        protected string lop;
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }

        protected string khoaHoc;
        public string KhoaHoc
        {
            get { return khoaHoc; }
            set { khoaHoc = value; }
        }

        protected int kyHoc;
        public int KyHoc
        {
            get { return kyHoc; }
            set { kyHoc = value; }
        }

        protected Nguoi nguoi;
        public Nguoi Nguoi
        {
            get { return nguoi; }
            set { nguoi = value; }
        }

        public HSHocSinh()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap Lop: ");
            Lop = Console.ReadLine();
            Console.WriteLine("-Nhap khoa hoc: ");
            KhoaHoc = Console.ReadLine();
            Console.WriteLine("-Nhap ky hoc: ");
            KyHoc = int.Parse(Console.ReadLine());
            nguoi = new Nguoi();
            nguoi.Nhap();
        }

        public void Xuat()
        {
            Console.WriteLine("-Lop: " + Lop);
            Console.WriteLine("-Khoa hoc: " + KhoaHoc);
            Console.WriteLine("-Ky hoc: " + KyHoc);
            nguoi.Xuat();
        }
    }
}
