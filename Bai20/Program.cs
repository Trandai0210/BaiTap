using System;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n ca nhan thuoc lop co quan: ");
            n = int.Parse(Console.ReadLine());

            CoQuan[] coQuans = new CoQuan[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("-Ca nhan " + i + ":");
                coQuans[i] = new CoQuan();
                coQuans[i].Nhap();
            }


            Console.WriteLine("-Nhung ca nhan co don vi la \"Phong tai chinh\":");
            for(int i = 0; i < n; i++)
            {
                if (coQuans[i].DonViCongTac == "Phong tai chinh")
                    coQuans[i].In();
            }

            string hoten;
            Console.Write("Nhap ho ten muon tim kiem: ");
            hoten = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (coQuans[i].HoTen == hoten)
                    coQuans[i].In();
            }
        }
    }
}
