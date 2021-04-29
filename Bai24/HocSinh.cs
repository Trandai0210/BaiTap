using System;
using System.Collections.Generic;
using System.Text;

namespace Bai24
{
    class HocSinh
    {
        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private int namSinh;
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        private double tongDiem;
        public double TongDiem
        {
            get { return tongDiem; }
            set { tongDiem = value; }
        }

        public HocSinh()
        {

        }

        public void Nhap()
        {
            Console.Write("\tNhap ho ten: ");
            hoTen = Console.ReadLine();
            hoTen = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(HoTen.ToLower());
            Console.Write("\tNhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("\tTong diem: ");
            tongDiem = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("\t+Ho ten: " + hoTen);
            Console.WriteLine("\t+Nam sinh: " + namSinh);
            Console.WriteLine("\t+Tong diem: " + tongDiem);
        }
    }
}
