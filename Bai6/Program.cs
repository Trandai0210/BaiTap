using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            HoDan[] hoDans = new HoDan[n];

            KhuPho khuPho = new KhuPho();
            khuPho.Nhap(hoDans, n);
            khuPho.Xuat(hoDans, n);
            khuPho.TimKiem(hoDans, n);

        }
    }
}
