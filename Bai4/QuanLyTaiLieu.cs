using System;

namespace Bai4
{
    class QuanLyTaiLieu
    {
        public QuanLyTaiLieu()
        {

        }

        public void Nhap(TaiLieu[] taiLieus, int n)
        {
            int x;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap tai lieu {0}: ", i + 1);
                Console.WriteLine("-Nhap 1 neu la sach \n-Nhap 2 neu la tap chi \n-Nhap 3 neu la bao");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    taiLieus[i] = new Sach();
                    taiLieus[i].Nhap();
                }
                else
                {
                    if (x == 2)
                    {
                        taiLieus[i] = new TapChi();
                        taiLieus[i].Nhap();
                    }
                    else
                    {
                        taiLieus[i] = new Bao();
                        taiLieus[i].Nhap();
                    }
                }
            }

        }

        public void Xuat(TaiLieu[] taiLieus, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tai lieu {0}", i + 1);
                taiLieus[i].Xuat();
            }
        }

        public void TimKiemTheoLoai(TaiLieu[] taiLieus, int n)
        {
            int j;
            Console.WriteLine(" - Nhap 1 neu la sach \n - Nhap 2 neu la tap chi \n - Nhap 3 neu la bao");
            j = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (j == 1 && taiLieus[i].GetType() == typeof(Sach))
                {
                    taiLieus[i].Xuat();
                }
                else
                {
                    if (j == 2 && taiLieus[i].GetType() == typeof(TapChi))
                    {
                        taiLieus[i].Xuat();
                    }
                    else
                    {
                        if (j == 3 && taiLieus[i].GetType() == typeof(TaiLieu))
                        {
                            taiLieus[i].Xuat();
                        }
                    }
                }
            }
        }
    }
}
