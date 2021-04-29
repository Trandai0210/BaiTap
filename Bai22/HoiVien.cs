using System;
using System.Collections.Generic;
using System.Text;

namespace Bai22
{
    class HoiVien
    {
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

        public HoiVien()
        {

        }

        public virtual void Nhap()
        {
            Console.Write("\t+ Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\t+ Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }


        public virtual void Xuat()
        {
            Console.WriteLine("\t+ Ho ten: " + HoTen);
            Console.WriteLine("\t+ Dia chi: " + DiaChi);
        }

    }
}
