using System;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n tam giac: ");
            n = int.Parse(Console.ReadLine());
            TamGiac[] tamGiacs = new TamGiac[n];

            for(int i = 0; i < tamGiacs.Length; i++)
            {
                Console.WriteLine("Nhap tam giac {0}", i);
                tamGiacs[i] = new TamGiac();
                tamGiacs[i].Nhap();
            }


            double tongChuVi = 0;
            double tongDienTich = 0;
            double AB = 0;
            double BC = 0;
            double AC = 0;
            for(int i = 0; i < tamGiacs.Length; i++)
            {
                AB = tamGiacs[i].DiemA.KhoangCach(tamGiacs[i].DiemB);
                AC = tamGiacs[i].DiemA.KhoangCach(tamGiacs[i].DiemC);
                BC = tamGiacs[i].DiemB.KhoangCach(tamGiacs[i].DiemC);
                if (AB * AB < AC * AC + BC * BC && AC * AC < AB * AB + BC * BC && BC < AB * AB + AC * AC)
                {
                    tongChuVi += tamGiacs[i].ChuVi();
                    tongDienTich += tamGiacs[i].DienTich();
                }
                else
                {
                    Console.WriteLine("tam giac " + i +"khong phai tam giac!!!");
                }
            }

            Console.WriteLine("-Tong chu vi: " + tongChuVi);
            Console.WriteLine("-Tong dien tich: " + tongDienTich);
        }
    }
}
