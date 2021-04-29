using System;

namespace Bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            HocSinh[] hocSinhs = new HocSinh[n];

            for(int i = 0; i < n; i++)
            {
                hocSinhs[i] = new HocSinh();
                hocSinhs[i].Nhap();
            }

            HocSinh temp = new HocSinh();
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(hocSinhs[i].TongDiem < hocSinhs[j].TongDiem)
                    {
                        temp = hocSinhs[i];
                        hocSinhs[i] = hocSinhs[j];
                        hocSinhs[j] = temp;
                    }
                    if(hocSinhs[i].TongDiem == hocSinhs[j].TongDiem && hocSinhs[i].NamSinh > hocSinhs[j].NamSinh)
                    {
                        temp = hocSinhs[i];
                        hocSinhs[i] = hocSinhs[j];
                        hocSinhs[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                hocSinhs[i].Xuat();
        }
    }
}
