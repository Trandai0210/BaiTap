using System;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap phan so A: ");
            PhanSo phanSoA = new PhanSo();
            phanSoA.Nhap();
            Console.WriteLine("Nhap phan so B: ");
            PhanSo phanSoB = new PhanSo();
            phanSoB.Nhap();
            PhanSo kq = new PhanSo();

            int x;
            Console.WriteLine("Nhap 1 tinh A + B \nNhap 2 tinh A - B\nNhap 3 tinh A * B\nNhap 4 tinh A / B");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        kq = phanSoA + phanSoB;
                        kq.RutGon();
                        kq.Xuat();
                    }break;
                case 2:
                    {
                        kq = phanSoA - phanSoB;
                        kq.RutGon();
                        kq.Xuat();
                    }
                    break;
                case 3:
                    {
                        kq = phanSoA * phanSoB;
                        kq.RutGon();
                        kq.Xuat();
                    }
                    break;
                case 4:
                    {
                        kq = phanSoA / phanSoB;
                        kq.RutGon();
                        kq.Xuat();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nhap sai!!!");
                    }break;
            }
        }
    }
}
