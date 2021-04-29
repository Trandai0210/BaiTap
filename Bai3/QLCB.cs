using System;

namespace Bai3
{
    class QLCB
    {
        public QLCB()
        {

        }
        public void Nhap(CanBo[] canBos, int n)
        {
            string x;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap can bo {0}", i);
                Console.WriteLine("-Nhap 1 neu la cong nhan: ");
                Console.WriteLine("-Nhap 2 neu la ky su: ");
                Console.WriteLine("-Nhap 3 neu la nhan vien: ");
                x = Console.ReadLine();
                if (x == "1")
                {
                    canBos[i] = new CongNhan();
                    canBos[i].Nhap();
                }
                else
                {
                    if (x == "2")
                    {
                        canBos[i] = new KySu();
                        canBos[i].Nhap();
                    }
                    if (x == "3")
                    {
                        canBos[i] = new NhanVien();
                        canBos[i].Nhap();
                    }
                }
            }
        }
        public void TimKiem(CanBo[] canBos, int n)
        {
            string hoten;
            Console.WriteLine("Nhap ho ten can bo muon tim kiem: ");
            hoten = Console.ReadLine();
            int slxh = 0;
            for (int i = 0; i < n; i++)
            {
                if (canBos[i].HoTen == hoten)
                {
                    Console.WriteLine("\nThong tin can bo muon tim: ");
                    canBos[i].Xuat();
                    slxh++;
                }
            }
            if (slxh == 0)
            {
                Console.WriteLine("\nKhong co ai ten la : " + hoten);
            }
        }

        public void Xuat(CanBo[] canBos, int n)
        {
            Console.WriteLine("\nDanh sach cac can bo: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\nThong tin nhan vien {0}: ", i);
                canBos[i].Xuat();
            }
        }
    }
}
