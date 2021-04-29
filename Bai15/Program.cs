using System;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so PTGT: ");
            n = int.Parse(Console.ReadLine());
            PTGT[] pTGTs = new PTGT[n];

            QLPTGT qLPTGT = new QLPTGT();
            qLPTGT.DangKy(pTGTs, n);
            qLPTGT.TimKiemTheoMau(pTGTs, n);
        }
    }
}
