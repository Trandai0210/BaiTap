using System;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phuc A: ");
            SoPhuc A = new SoPhuc();
            A.Nhap();
            Console.WriteLine("Nhap so phuc B: ");
            SoPhuc B = new SoPhuc();
            B.Nhap();

            SoPhuc C = new SoPhuc();
            int x;
            Console.WriteLine("-nhap 1 neu muon tinh A + B: \n-nhap 2 neu muon tinh A - B: " +
                "\n-nhap 3 neu muon tinh A * B: \n-nhap 4 neu muon tinh A / B: \n");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
                C = A + B;
            if (x == 2)
                C = A - B;
            if (x == 3)
                C = A * B;
            if (x == 4)
                C = A / B;
            if (x >= 5)
            {
                Console.WriteLine("Nhap sai!!!");
                Environment.Exit(0);
            }

            C.Xuat();
        }
    }
}
