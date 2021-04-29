using System;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            ThiSinh[] thiSinhs = new ThiSinh[n];

            //Nhập n thí sinh
            for(int i = 0; i < n; i++)
            {
                thiSinhs[i] = new ThiSinh();
                thiSinhs[i].Nhap();
            }
            Console.WriteLine("\n\n\t Danh sach cac thi sinh co tong diem lon hon 15");
            Console.WriteLine("Ho ten\t\t\tQue quan\t\t\tSo bao danh\t\t\tDiem Toan\t\t\tDiem Ly\t\t\tDiem Hoa");
            for(int i = 0; i < n; i++)
            {
                if(thiSinhs[i].DiemThi.DToan + thiSinhs[i].DiemThi.DLy+ thiSinhs[i].DiemThi.DHoa > 15)
                    thiSinhs[i].Xuat();
            }


            ThiSinh temp = new ThiSinh();
            ThiSinh max = new ThiSinh();
            for(int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(thiSinhs[i].DiemThi.DToan + thiSinhs[i].DiemThi.DLy + thiSinhs[i].DiemThi.DHoa < thiSinhs[j].DiemThi.DToan + thiSinhs[j].DiemThi.DLy + thiSinhs[j].DiemThi.DHoa)
                    {
                        temp = thiSinhs[i];
                        thiSinhs[i] = thiSinhs[j];
                        thiSinhs[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\n\t Thong tin cac thi sinh: ");
            Console.WriteLine("Ho ten\t\t\tQue quan\t\t\tSo bao danh\t\t\tDiem Toan\t\t\tDiem Ly\t\t\tDiem Hoa");
            for (int i = 0; i < n; i++)
            {
                thiSinhs[i].Xuat();
            }
        }
    }
}
