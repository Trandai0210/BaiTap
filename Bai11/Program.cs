using System;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());

            BienLai[] bienLais = new BienLai[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin bien lai {0}: ", i + 1);
                bienLais[i] = new BienLai();
                bienLais[i].Nhap();
            }

            Console.WriteLine("Cac bien lai da nhap: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Bien lai {0}: ", i + 1);
                bienLais[i].Xuat();
            }
        }
    }
}
