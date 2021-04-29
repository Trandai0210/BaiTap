using System;

namespace Bai3
{
    class CanBo
    {
        protected string hoTen;
        protected int namSinh;
        protected int gioiTinh;
        protected string diaChi;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public CanBo()
        {

        }
        public virtual void Nhap()
        {
            Console.WriteLine("-Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("-Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap gioi tinh ( \'1\' la Nam , \'0\' la Nu) : ");
            gioiTinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("-Ho ten: " + hoTen);
            Console.WriteLine("-Nam sinh: " + namSinh);
            Console.WriteLine("-Gioi Tinh: " + gioiTinh);
            Console.WriteLine("-Dia Chi: " + diaChi);
        }
    }
}
