using System;

namespace Bai6
{
    class Nguoi
    {
        protected string soCMND;
        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }

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

        protected string ngheNghiep;
        public string NgheNghiep
        {
            get { return ngheNghiep; }
            set { ngheNghiep = value; }
        }

        public void Nhap()
        {
            Console.WriteLine("-Nhap so CMND: ");
            SoCMND = Console.ReadLine();
            Console.WriteLine("-Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("-Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap nghe nghiep: ");
            ngheNghiep = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("-So CMND: " + SoCMND);
            Console.WriteLine("-Ho ten: " + HoTen);
            Console.WriteLine("-Tuoi: " + Tuoi);
            Console.WriteLine("-Nam sinh: " + NamSinh);
            Console.WriteLine("-Nghe nghiep: " + NgheNghiep);
        }
    }
}
