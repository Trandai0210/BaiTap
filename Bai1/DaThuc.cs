using System;

namespace Bai1
{
    class DaThuc
    {
        private int bac;
        public int Bac
        {
            get { return bac; }
            set { bac = value; }
        }

        public int[] arrheso = new int[10];
        public int[] Arrheso
        {
            get { return arrheso; }
            set { arrheso = value; }
        }

        public DaThuc()
        {

        }
        public DaThuc(int bac)
        {
            this.bac = bac;
            arrheso = new int[bac + 1];
        }

        public DaThuc(DaThuc a)
        {
            this.bac = a.bac;
            for (int i = 0; i < bac + 1; i++)
            {
                this.arrheso[i] = a.arrheso[i];
            }
        }

        public void Nhap()
        {
            Console.Write("\nNhap bac cua da thuc: ");
            this.bac = int.Parse(Console.ReadLine());
            arrheso = new int[bac + 1];
            for (int i = 0; i < bac + 1; i++)
            {
                Console.Write("Nhap arrheso[{0}]: ", i);

                arrheso[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            int x = bac;
            for (int i = 0; i < bac; i++)
            {
                Console.Write("{0}X^{1} + ", Arrheso[i], x);
                x--;
            }
            Console.Write("{0}\n", arrheso[bac]);
        }



        public static DaThuc operator +(DaThuc a, DaThuc b)
        {
            int max = Math.Max(a.bac, b.bac);
            DaThuc tong = new DaThuc(max);
            int dodaiarrhesoa = a.arrheso.Length;
            int dodaiarrhesob = b.arrheso.Length;
            int j = 0;
            if (dodaiarrhesoa > dodaiarrhesob)
            {
                for (int i = 0; i < tong.arrheso.Length; i++)
                {
                    if (dodaiarrhesoa > dodaiarrhesob)
                    {
                        tong.arrheso[i] = a.arrheso[i];
                        dodaiarrhesoa--;
                    }
                    else
                    {
                        tong.arrheso[i] = a.arrheso[i] + b.arrheso[j];
                        j++;

                    }
                }
            }
            if (dodaiarrhesoa < dodaiarrhesob)
            {
                for (int i = 0; i < tong.arrheso.Length; i++)
                {
                    if (dodaiarrhesoa < dodaiarrhesob)
                    {
                        tong.arrheso[i] = b.arrheso[i];
                        dodaiarrhesob--;
                    }
                    else
                    {
                        tong.arrheso[i] = a.arrheso[j] + b.arrheso[i];
                        j++;
                    }
                }
            }
            if (dodaiarrhesoa == dodaiarrhesob)
            {
                for (int i = 0; i < tong.arrheso.Length; i++)
                {
                    tong.arrheso[i] = a.arrheso[i] + b.arrheso[i];
                }
            }
            return tong;
        }

        public static DaThuc operator -(DaThuc a, DaThuc b)
        {
            int max = Math.Max(a.bac, b.bac);
            DaThuc hieu = new DaThuc(max);
            int dodaiarrhesoa = a.arrheso.Length;
            int dodaiarrhesob = b.arrheso.Length;
            int j = 0;
            if (dodaiarrhesoa > dodaiarrhesob)
            {
                for (int i = 0; i < hieu.arrheso.Length; i++)
                {
                    if (dodaiarrhesoa > dodaiarrhesob)
                    {
                        hieu.arrheso[i] = a.arrheso[i];
                        dodaiarrhesoa--;
                    }
                    else
                    {
                        hieu.arrheso[i] = a.arrheso[i] - b.arrheso[j];
                        j++;
                    }
                }
            }
            if (dodaiarrhesoa < dodaiarrhesob)
            {
                for (int i = 0; i < hieu.arrheso.Length; i++)
                {
                    if (dodaiarrhesoa < dodaiarrhesob)
                    {
                        hieu.arrheso[i] = b.arrheso[j];
                        dodaiarrhesob--;
                    }
                    else
                    {
                        hieu.arrheso[i] = a.arrheso[j] - b.arrheso[i];
                        j++;
                    }
                }
            }
            if (dodaiarrhesoa == dodaiarrhesob)
            {
                for (int i = 0; i < hieu.arrheso.Length; i++)
                {
                    hieu.arrheso[i] = a.arrheso[i] - b.arrheso[i];
                }
            }
            return hieu;
        }
    }
}
