using System;

namespace Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tamGiac = new TamGiac();
            tamGiac.Nhap();
            if (tamGiac.SoCanh == 3)
            {
                double a = tamGiac.KichThuoc[0];
                double b = tamGiac.KichThuoc[1];
                double c = tamGiac.KichThuoc[2];
                if (a * a < b * b + c * c && b * b < a * a + c * c && c * c < a * a + b * b)
                {
                    tamGiac.Xuat();
                    Console.WriteLine("Chu vi: " + tamGiac.ChuVi());
                    Console.WriteLine("-Dien tich: " + tamGiac.DienTich());
                }
                else
                    Console.WriteLine("-khong phai tam giac!!! ");
            }
            else
                Console.WriteLine("-khong phai tam giac!!! ");
            
        }
    }
}
