using System;
using System.Collections.Generic;
using System.Text;

namespace Bai23
{
    class HocSinh
    {
        protected string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        protected double diemToan;
        public double DiemToan
        {
            get { return diemToan; }
            set
            {
                if (value <= 10)
                    value = diemToan;
            }
        }
        protected double diemLy;
        public double DiemLy
        {
            get { return diemLy; }
            set
            {
                if (value <= 10)
                    value = diemLy;
            }
        }
        protected double diemHoa;
        public double DiemHoa
        {
            get { return diemHoa; }
            set
            {
                if (value <= 10)
                    value = diemHoa;
            }
        }
        public HocSinh()
        {

        }

        public virtual void Nhap()
        {
            Console.Write("\t+Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("\t+Nhap diem Toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.Write("\t+Nhap diem LY: ");
            diemLy = double.Parse(Console.ReadLine());
            Console.Write("\t+Nhap diem Hoa: ");
            diemHoa = double.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\t+Ho ten: " + hoTen);
            Console.WriteLine("\t+Diem toan: " + diemToan);
            Console.WriteLine("\t+Diem ly: " + diemLy);
            Console.WriteLine("\t+Diem hoa: " + DiemHoa);
        }
    }
}
