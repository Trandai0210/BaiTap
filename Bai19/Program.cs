using System;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("-Nhap n: ");
            n = int.Parse(Console.ReadLine());

            HinhTron[] hinhTrons = new HinhTron[n];
            for(int i = 0; i < hinhTrons.Length; i++)
            {
                Console.WriteLine("Nhap hinh tron {0}:",i);
                hinhTrons[i] = new HinhTron();
                hinhTrons[i].Nhap();
            }


            int[] solangiao = new int[n];
            for(int i = 0; i < n; i++)
            {
                for(int j =hinhTrons.Length-1; j >=0; j--)
                {
                    if (hinhTrons[i].O.KhoangCach(hinhTrons[j].O) <= hinhTrons[i].Radius + hinhTrons[j].Radius)
                        solangiao[i]++;
                }
            }
            int vtmax = 0;
            for(int i = 1; i < n; i++)
            {
                if(solangiao[i] > solangiao[vtmax])
                {
                    vtmax = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Hinh tron giao voi nhieu hinh tron khac nhat:");
            Console.WriteLine("Hinh tron " + vtmax);
            hinhTrons[vtmax].Xuat();
        }
    }
}
