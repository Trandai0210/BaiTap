using System;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            CBGV[] cBGVs = new CBGV[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin CBGV {0}: ", i + 1);
                cBGVs[i] = new CBGV();
                cBGVs[i].Nhap();
            }

            string timkiemquequan;
            Console.WriteLine("Nhap que quan muon tim kiem: ");
            timkiemquequan = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (cBGVs[i].Nguoi.QueQuan == timkiemquequan)
                {
                    cBGVs[i].Nguoi.Xuat();
                }
            }

            Console.WriteLine("-Nhung CBGV co luong thuc linh lon hon 5.000.000");
            int solanxuathien = 0;
            for (int i = 0; i < n; i++)
            {
                if (cBGVs[i].LuongThucLinh > 5000000)
                {
                    solanxuathien++;
                    cBGVs[i].Xuat();
                }
            }
        }
    }
}
