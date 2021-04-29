using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so tai lieu: ");
            n = int.Parse(Console.ReadLine());

            TaiLieu[] taiLieus = new TaiLieu[n];
            QuanLyTaiLieu quanLyTaiLieu = new QuanLyTaiLieu();
            quanLyTaiLieu.Nhap(taiLieus, n);
            quanLyTaiLieu.TimKiemTheoLoai(taiLieus, n);
            Environment.Exit(0);
        }
    }
}
