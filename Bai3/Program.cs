using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            QLCB qLCB = new QLCB();
            int n;
            Console.WriteLine("Nhap so can bo: ");
            n = int.Parse(Console.ReadLine());
            CanBo[] canBos = new CanBo[n];
            qLCB.Nhap(canBos, n);
            Console.Clear();
            qLCB.TimKiem(canBos, n);
            qLCB.Xuat(canBos, n);

        }
    }
}
