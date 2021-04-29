using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Nhap \'1\' neu muon cong");
            Console.WriteLine("Nhap \'2\' neu muon tru");
            Console.WriteLine("Nhap \'3\' neu muon nhan");
            Console.WriteLine("Nhap \'4\' neu muon chia");
            Console.WriteLine("Nhap \'5\' neu toi gian");
            x = int.Parse(Console.ReadLine());
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();

            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Phan so 1: ");
                        ps1.Nhap();
                        Console.WriteLine("Phan so 2: ");
                        ps2.Nhap();
                        ps3 = ps1 + ps2;
                        Console.WriteLine("{0}/{1} + {2}/{3} = {4}/{5}", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo, ps3.TuSo, ps3.MauSo);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Phan so 1: ");
                        ps1.Nhap();
                        Console.WriteLine("Phan so 2: ");
                        ps2.Nhap();
                        ps3 = ps1 - ps2;
                        Console.WriteLine("{0}/{1} - {2}/{3} = {4}/{5}", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo, ps3.TuSo, ps3.MauSo);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Phan so 1: ");
                        ps1.Nhap();
                        Console.WriteLine("Phan so 2: ");
                        ps2.Nhap();
                        ps3 = ps1 * ps2;
                        Console.WriteLine("{0}/{1} * {2}/{3} = {4}/{5}", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo, ps3.TuSo, ps3.MauSo);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Phan so 1: ");
                        ps1.Nhap();
                        Console.WriteLine("Phan so 2: ");
                        ps2.Nhap();
                        ps3 = ps1 / ps2;
                        Console.WriteLine("{0}/{1} / {2}/{3} = {4}/{5}", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo, ps3.TuSo, ps3.MauSo);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Nhap phan so muon toi gian: ");
                        ps1.Nhap();
                        ps1.KiemTra();
                        Console.WriteLine("Dang kiem tra...");
                        if (ps1.KiemTra())
                            Console.WriteLine("Phan so da toi gian.");
                        else
                        {
                            ps1.ToiGian();
                            Console.WriteLine("Sau khi toi gian: " + ps1.TuSo + "/" + ps1.TuSo);
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nhap sai !!!");
                        break;
                    }
            }
        }
    }
}
