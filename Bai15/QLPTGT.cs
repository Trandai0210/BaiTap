using System;
using System.Collections.Generic;
using System.Text;

namespace Bai15
{
    class QLPTGT
    {
        public void DangKy(PTGT[] pTGTs,int n)
        {
            for(int i = 0; i < n; i++)
            {
                int x;
                Console.WriteLine("\nXe tai nhap 1\nXe may nhap 2\nXe o to nhap 3");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    pTGTs[i] = new XeTai();
                    pTGTs[i].Nhap();
                }
                else
                {
                    if (x == 2)
                    {
                        pTGTs[i] = new XeMay();
                        pTGTs[i].Nhap();
                    }
                    else
                    {
                        pTGTs[i] = new OTo();
                        pTGTs[i].Nhap();
                    }
                }
            }
        }
        public void TimKiemTheoMau(PTGT[] pTGTs, int n)
        {
            string x;
            Console.WriteLine("Nhap mau muon tim: ");
            x = Console.ReadLine();
            Console.WriteLine("Nhung phuong tien co mau: " + x);
            for(int i = 0; i < n; i++)
            {
                if (pTGTs[i].Mau == x)
                    pTGTs[i].Xuat();
            }
        }
    }
}
