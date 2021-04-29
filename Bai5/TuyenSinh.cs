using System;

namespace Bai5
{
    class TuyenSinh
    {
        public TuyenSinh()
        {

        }

        public void Nhap(ThiSinh[] thiSinhs, int n)
        {
            int x;
            Console.WriteLine("-nhap \'1\' neu la thi sinh khoi A \n-nhap \'2\' neu la thi sinh khoi A \n-nhap \'3\' " +
                "neu la thi sinh khoi A \n");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thi sinh " + i);
                if (x == 1)
                {
                    thiSinhs[i] = new KhoiA();
                    thiSinhs[i].Nhap();
                }
                if (x == 2)
                {
                    thiSinhs[i] = new KhoiB();
                    thiSinhs[i].Nhap();
                }
                if (x == 3)
                {
                    thiSinhs[i] = new KhoiC();
                    thiSinhs[i].Nhap();
                }
            }
        }
        public void DSTrungTuyen(ThiSinh[] thiSinhs, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (thiSinhs[i].TrungTuyen())
                {
                    Console.WriteLine("Thi sinh " + i);
                    thiSinhs[i].Xuat();
                }

            }
        }

        public void TimKiemSBD(ThiSinh[] thiSinhs, int n)
        {
            string sbd;
            Console.WriteLine("Nhap so bao danh cua thi sinh muon tim kiem: ");
            sbd = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (thiSinhs[i].SoBaoDanh == sbd)
                {
                    thiSinhs[i].Xuat();
                    break;
                }
            }
        }
    }
}
