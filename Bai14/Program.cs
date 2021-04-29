using System;
namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ma tran A: ");
            Matran matran1 = new Matran();
            matran1.Nhap();
            matran1.Xuat();

            Console.WriteLine("Nhap ma tran B: ");
            Matran matran2 = new Matran();
            matran2.Nhap();
            matran2.Xuat();

            Matran matran3 = new Matran();
            int x;
            Console.WriteLine("\nNhap 1 tinh A + B\nNhap 2 tinh A - B\nNhap 3 tinh A * B");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
                matran3 = matran1 + matran2;
            else
            {
                if (x == 2)
                    matran3 = matran1 - matran2;
                else
                    matran3 = matran1 * matran2;
            }
            matran3.Xuat();
        }
    }
}
