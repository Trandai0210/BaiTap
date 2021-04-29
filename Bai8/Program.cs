using System;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            HSHocSinh[] hSHocSinhs = new HSHocSinh[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh {0}: " + i + 1);
                hSHocSinhs[i] = new HSHocSinh();
                hSHocSinhs[i].Nhap();
            }
            Console.WriteLine("Nhung hoc sinh nu sinh nam 1985");
            int solan = 0;
            for (int i = 0; i < n; i++)
            {
                if (hSHocSinhs[i].Nguoi.NamSinh == 1985 && hSHocSinhs[i].Nguoi.GioiTinh == 0)
                {
                    solan++;
                    hSHocSinhs[i].Xuat();
                }
            }
            if (solan == 0)
                Console.WriteLine("-Khong co ai het !!!");

            string quequantimkiem;
            Console.WriteLine("Nhap que quan muon tim: ");
            int solantimthay = 0;
            quequantimkiem = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (hSHocSinhs[i].Nguoi.QueQuan == quequantimkiem)
                {
                    solantimthay++;
                    hSHocSinhs[i].Xuat();
                }
            }
            if (solantimthay == 0)
                Console.WriteLine("-Khong co ai het!!!");
        }
    }
}
