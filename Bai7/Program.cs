using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("-Nhap n: ");
            n = int.Parse(Console.ReadLine());

            //Nhap
            KhachSan[] khachTros = new KhachSan[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Thong tin khach tro {0}: ", i + 1);
                khachTros[i] = new KhachSan();
                khachTros[i].Nhap();
            }


            //Xuat
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin khach tro {0}: ", i + 1);
                khachTros[i].Xuat();
            }

            //Tim kiem theo ho ten
            string hotentimkiem;
            Console.WriteLine("Nhap ho ten khach tro muon tim kiem: ");
            hotentimkiem = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (khachTros[i].Nguois.HoTen == hotentimkiem)
                {
                    Console.WriteLine("Thong tin khach tro: ");
                    khachTros[i].Xuat();
                }
            }

            //Tinh tien tra phong
            string hotenkhachtro;
            Console.WriteLine("Nhap ho ten khach tro muon tra phong: ");
            hotenkhachtro = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (khachTros[i].Nguois.HoTen == hotenkhachtro)
                    Console.WriteLine("-Tien phong phai thanh toan: " + khachTros[i].TienPhong());
            }
        }
    }
}
