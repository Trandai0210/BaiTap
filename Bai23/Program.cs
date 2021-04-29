using System;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("-Nhap n: ");
            n = int.Parse(Console.ReadLine());
            HocSinh[] hocSinhs = new HocSinh[n];

            for(int i = 0; i < n; i++)
            {
                int gioitinh;
                Console.WriteLine("-Nhap thong tin hoc sinh " + i);
                Console.WriteLine("Nhap 1 la Nam || Nhap 2 la Nu");
                gioitinh = int.Parse(Console.ReadLine());
                switch (gioitinh)
                {
                    case 1:
                        {
                            hocSinhs[i] = new HocSinhNam();
                            hocSinhs[i].Nhap();
                        }break;
                    case 2:
                        {
                            hocSinhs[i] = new HocSinhNu();
                            hocSinhs[i].Nhap();
                        }break;
                    default:
                        {
                            Console.WriteLine("-Nhap sai!!!");
                        }break;
                }
            }


            Console.WriteLine("\n\n-Nhung hoc sinh nam co diem ki thuat >= 8: ");
            HocSinhNam test = new HocSinhNam();
            for (int i = 0; i < n; i++)
            {
                if(hocSinhs[i].GetType() == typeof(HocSinhNam))
                {
                    test = (HocSinhNam)hocSinhs[i];
                    if (test.DiemKyThuat >= 8)
                        hocSinhs[i].Xuat();
                }
            }

            Console.WriteLine("\n\n-Danh sach hoc sinh");
            Console.WriteLine("\n-Hoc sinh nam: ");
            for(int i = 0; i < n; i++)
            {
                if (hocSinhs[i].GetType() == typeof(HocSinhNam))
                {
                    hocSinhs[i].Xuat();
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\n-Hoc sinh nu: ");
            for (int i = 0; i < n; i++)
            {
                if (hocSinhs[i].GetType() == typeof(HocSinhNu))
                {

                    hocSinhs[i].Xuat();
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
