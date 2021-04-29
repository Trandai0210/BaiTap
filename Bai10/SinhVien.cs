using System;

namespace Bai10
{
    class SinhVien
    {
        protected string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        protected int namSinh;
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        protected string lop;
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }

        protected string maSV;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public SinhVien()
        {

        }

        public void Nhap()
        {
            Console.Write("-Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("-Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("-Nhap lop: ");
            Lop = Console.ReadLine();
            Console.Write("-Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.Write("-Ho ten: " + HoTen);
            Console.Write("-Nam sinh: " + NamSinh);
            Console.Write("-Lop: " + Lop);
            Console.Write("-Ma sinh vien: " + MaSV);
        }
    }
}
