using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5h50");
            int n;
            Console.WriteLine("Nhap n; ");
            n = int.Parse(Console.ReadLine());

            ThiSinh[] thiSinhs = new ThiSinh[n];

            TuyenSinh tuyenSinh = new TuyenSinh();

            tuyenSinh.Nhap(thiSinhs, n);
            Console.WriteLine("Danh sach cac thi sinh trung tuyen: ");
            tuyenSinh.DSTrungTuyen(thiSinhs, n);
            tuyenSinh.TimKiemSBD(thiSinhs, n);
        }
    }
}
