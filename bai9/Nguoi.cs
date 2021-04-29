using System;

namespace Bai9
{
    class Nguoi
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

        protected string queQuan;
        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        protected string soCMND;
        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }

        public Nguoi()
        {

        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("-Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.WriteLine("-Nhap so CMND: ");
            SoCMND = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("-Ho ten: " + HoTen);
            Console.WriteLine("-Nam sinh: " + NamSinh);
            Console.WriteLine("-Que quan: " + QueQuan);
            Console.WriteLine("-So CMND: " + SoCMND);

        }
    }
}
