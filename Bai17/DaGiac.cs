using System;
using System.Collections.Generic;
using System.Text;

namespace Bai17
{
    abstract class DaGiac
    {
        protected int soCanh;
        public int SoCanh
        {
            get { return soCanh; }
            set { soCanh = value; }
        }

        protected int[] kichThuoc;
        public int[] KichThuoc
        {
            get { return kichThuoc; }
            set { kichThuoc = value; }
        }

        public DaGiac()
        {

        }

        public virtual void Nhap()
        {
            Console.WriteLine("nhap so canh: ");
            soCanh = int.Parse(Console.ReadLine());
            kichThuoc = new int[soCanh];
            for(int i = 0; i < soCanh; i++)
            {
                Console.WriteLine("canh {0}",i);
                kichThuoc[i] = new int();
                kichThuoc[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for(int i = 0; i < kichThuoc.Length; i++)
            {
                Console.WriteLine("canh {0}: " + kichThuoc[i],i );
            }
        }
        public abstract double ChuVi();
    }
}
