using System;

namespace Bai5
{
    abstract class ThiSinh
    {
        protected string soBaoDanh;
        public string SoBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }

        protected string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        protected string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        protected double diemUuTien;
        public double DiemUuTien
        {
            get { return diemUuTien; }
            set
            {
                if (value >= 0)
                    diemUuTien = value;
            }
        }
        protected double diem1;
        public double Diem1
        {
            get { return diem1; }
            set { diem1 = value; }
        }
        protected double diem2;
        public double Diem2
        {
            get { return diem2; }
            set { diem2 = value; }
        }
        protected double diem3;
        public double Diem3
        {
            get { return diem3; }
            set { diem3 = value; }
        }

        public ThiSinh()
        {

        }
        public void Nhap()
        {
            Console.WriteLine("-Nhap so bao danh: ");
            SoBaoDanh = Console.ReadLine();
            Console.WriteLine("-Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("-Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("-Nhap diem uu tien: ");
            DiemUuTien = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap diem mon 1: ");
            Diem1 = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap diem mon 2: ");
            Diem2 = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap diem mon 3: ");
            Diem3 = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("-So bao danh: " + SoBaoDanh);
            Console.WriteLine("-Ho ten: " + HoTen);
            Console.WriteLine("-Dia chi: " + DiaChi);
            Console.WriteLine("-Diem uu tien: " + DiemUuTien);
            Console.WriteLine("-Diem mon 1: " + Diem1);
            Console.WriteLine("-Diem mon 2: " + Diem2);
            Console.WriteLine("-Diem mon 3: " + Diem3);
        }

        public abstract bool TrungTuyen();
    }
}
