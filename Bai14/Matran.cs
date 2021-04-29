using System;

namespace Bai14
{
    class Matran
    {
        protected int soDong;
        public int SoDong
        {
            get { return soDong; }
            set { soDong = value; }
        }

        protected int soCot;
        public int SoCot
        {
            get { return soCot; }
            set { soCot = value; }
        }
        public int[,] a = new int[5, 5];
        public Matran()
        {

        }
        public Matran(int n, int m)
        {
            this.soCot = n;
            this.soDong = m;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so dong: ");
            soDong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            SoCot = int.Parse(Console.ReadLine());
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    a[i, j] = new int();
                    Console.Write("Nhap a[{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        public static Matran operator +(Matran a, Matran b)
        {
            Matran kq = new Matran(a.soDong, a.soCot);
            for (int i = 0; i < kq.soDong; i++)
            {
                for (int j = 0; j < kq.SoCot; j++)
                {
                    kq.a[i, j] = a.a[i, j] + b.a[i, j];
                }
            }
            return kq;
        }

        public static Matran operator -(Matran a, Matran b)
        {
            Matran kq = new Matran(a.soDong, a.soCot);
            for (int i = 0; i < kq.soDong; i++)
            {
                for (int j = 0; j < kq.SoCot; j++)
                {
                    kq.a[i, j] = a.a[i, j] - b.a[i, j];
                }
            }
            return kq;
        }
        public static Matran operator *(Matran a, Matran b)
        {
            Matran kq = new Matran(a.soDong, b.soCot);
            for (int i = 0; i < kq.soDong; i++)
            {
                for (int j = 0; j < kq.SoCot; j++)
                {
                    int sum = 0;
                    for (int r = 0; r < a.soCot; r++)
                        sum = sum + (a.a[i, r] * b.a[r, j]);
                    kq.a[i, j] = sum;
                }
            }
            return kq;
        }
    }
}
