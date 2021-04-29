
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class CaNhan
    {
        protected string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        protected Boolean gioiTinh;
        public Boolean GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        protected int tuoi;
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }

        public CaNhan()
        {

        }
        public virtual void Nhap()
        {
            Console.Write("-Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("-Nhap gioi tinh: (Nam la true nu la false)");
            gioiTinh = Boolean.Parse(Console.ReadLine());
            Console.Write("-Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
        }
        public virtual void In()
        {
            Console.WriteLine("\t-Ho ten: " + HoTen);
            if(gioiTinh == true)
                Console.WriteLine("\t-Gioi tinh: Nam");
            else
                Console.WriteLine("\t-Gioi tinh: Nu");
            Console.WriteLine("\t-Tuoi: " + tuoi);
            
        }
    }
}
