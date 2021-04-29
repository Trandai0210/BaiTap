using System;

namespace Bai6
{
    class HoDan
    {
        protected int soThanhVien;
        public int SoThanhVien
        {
            get { return soThanhVien; }
            set { soThanhVien = value; }
        }

        protected string soNha;
        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }
        protected Nguoi[] nguois;
        public Nguoi[] Nguois
        {
            get { return nguois; }
            set { nguois = value; }
        }
        public HoDan()
        {

        }
        public void Nhap()
        {
            Console.WriteLine("-Nhap so thanh vien: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap so nha: ");
            SoNha = Console.ReadLine();
            nguois = new Nguoi[SoThanhVien];
            for (int i = 0; i < soThanhVien; i++)
            {
                Console.WriteLine("-Nhap thong tin Thanh vien thu {0}", i + 1);
                nguois[i] = new Nguoi();
                nguois[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("-So thanh vien: " + SoThanhVien);
            Console.WriteLine("-So nha: " + SoNha);
            Console.WriteLine("-Nhung thanh vien trong gia dinh: ");
            for (int i = 0; i < soThanhVien; i++)
            {
                Console.WriteLine("Thanh vien {0}: ", i + 1);
                nguois[i].Xuat();
            }
        }
    }
}
