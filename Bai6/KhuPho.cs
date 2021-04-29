using System;

namespace Bai6
{
    class KhuPho
    {
        public KhuPho()
        {

        }
        public void Nhap(HoDan[] hoDans, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin ho dan {0}: ", i + 1);
                hoDans[i] = new HoDan();
                hoDans[i].Nhap();
            }
        }
        public void Xuat(HoDan[] hoDans, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin ho dan {0}: ", i + 1);
                hoDans[i].Xuat();
            }
        }
        public void TimKiem(HoDan[] hoDans, int n)
        {
            int x;
            Console.WriteLine("Nhap \'1\' neu muon tim kiem theo ho ten , \'2\' neu muon tim kiem theo so nha");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                string tuKhoa;
                Console.WriteLine("Nhap ho ten nguoi can tim: ");
                tuKhoa = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < hoDans[i].SoThanhVien; i++)
                    {
                        if (hoDans[i].Nguois[j].HoTen == tuKhoa)
                        {
                            Console.WriteLine("-Thong tin ho dan: ");
                            hoDans[i].Xuat();
                            break;
                        }
                    }
                }

            }
            if (x == 2)
            {
                string tuKhoa;
                Console.WriteLine("Nhap so nha can tim: ");
                tuKhoa = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (hoDans[i].SoNha == tuKhoa)
                    {
                        Console.WriteLine("-Thong tin ho dan: ");
                        hoDans[i].Xuat();
                    }
                }
            }
        }
    }
}
