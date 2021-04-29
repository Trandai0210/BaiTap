using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 2 da thuc: ");
            Console.WriteLine("Da thuc 1: ");
            DaThuc daThuc1 = new DaThuc(3);
            daThuc1.Nhap();
            daThuc1.Xuat();
            Console.WriteLine("Da thuc 2: ");
            DaThuc daThuc2 = new DaThuc(3);
            daThuc2.Nhap();
            daThuc2.Xuat();
            string x;
            DaThuc daThuc3 = new DaThuc();
            Console.WriteLine("Nhap 1 neu muon cong 2 da thuc: ");
            Console.WriteLine("Nhap 2 neu muon tru 2 da thuc: ");
            x = Console.ReadLine();
            if (x == "1")
            {
                daThuc3 = daThuc1 + daThuc2;
                daThuc3.Xuat();
            }
            else
            {
                daThuc3 = daThuc1 - daThuc2;
                daThuc3.Xuat();
            }
        }
    }

}
