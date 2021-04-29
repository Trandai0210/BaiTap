using System;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            TheMuon[] theMuons = new TheMuon[n];
            for (int i = 0; i < n; i++)
            {
                theMuons[i] = new TheMuon();
                theMuons[i].Nhap();
            }

            string timkiemMSV;
            int solanxuathien = 0;
            Console.WriteLine("nhap ma sinh vien muon tim kiem: ");
            timkiemMSV = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (theMuons[i].SinhVien.MaSV == timkiemMSV)
                {
                    Console.WriteLine("Thong tin sinh vien muon tim kiem: ");
                    solanxuathien++;
                    theMuons[i].SinhVien.Xuat();
                }
            }
            if (solanxuathien == 0)
            {
                Console.WriteLine("Khong co sinh vien nao co msv nay!!!");
            }

            Console.WriteLine("-Nhung sinh vien da het han tra sach: ");
            for (int i = 0; i < n; i++)
            {
                if (theMuons[i].HanTra < DateTime.Now)
                {
                    theMuons[i].SinhVien.Xuat();
                }
            }
        }
    }
}
