using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("-Nhap so hoi vien n = ");
            n = int.Parse(Console.ReadLine());

            HoiVien[] hoiViens = new HoiVien[n];
            int loai;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("-Nhap thong tin hoi vien " + i);
                Console.WriteLine("-Nhap \"1\" la hoi vien co gia danh\n-Nhap \"2\" la hoi vien co nguoi yeu\n-Nhap \"3\" la hoi vien khong co nguoi yeu");
                loai = int.Parse(Console.ReadLine());
                switch (loai)
                {
                    case 1:
                        {
                            hoiViens[i] = new HoiVienCoGiaDinh();
                            hoiViens[i].Nhap();
                        }break;
                    case 2:
                        {
                            hoiViens[i] = new HoiVienCoNguoiYeu();
                            hoiViens[i].Nhap();
                        }
                        break;
                    case 3:
                        {
                            hoiViens[i] = new HoiVienChuaCoNguoiYeu();
                            hoiViens[i].Nhap();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Nhap sai!!!");
                        }break;
                }
            }

            Console.WriteLine("-Nhung hoi vien co ngay cuoi la: 11/11/2011");
            HoiVienCoGiaDinh test = new HoiVienCoGiaDinh();
            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime("11/11/2011");
            for (int i = 0; i < n; i++)
            {
                if(hoiViens[i].GetType() == typeof(HoiVienCoGiaDinh))
                {
                    test = (HoiVienCoGiaDinh)hoiViens[i];
                    if(test.NgayCuoi == Convert.ToDateTime("11/11/2011"))
                    {
                        Console.WriteLine("Hoi vien " + i);
                        hoiViens[i].Xuat();
                    }
                }
            }

            Console.WriteLine("-Nhung hoi vien da co nguoi yeu: ");
            for(int i = 0; i < n; i++)
            {
                if (hoiViens[i].GetType() == typeof(HoiVienCoNguoiYeu))
                {
                    Console.WriteLine("\t-Hoi vien " + i);
                    hoiViens[i].Xuat();
                }
                    
            }
        }
    }
}
