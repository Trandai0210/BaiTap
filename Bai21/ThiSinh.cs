using System;
using System.Collections.Generic;
using System.Text;

namespace Bai21
{
    class ThiSinh
    {
        protected HoTen hoTen = new HoTen();
        public HoTen HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        protected QueQuan queQuan = new QueQuan();
        public QueQuan QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        protected string truong;
        public string Truong
        {
            get { return truong; }
            set { truong = value; }
        }

        protected int tuoi;
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }

        protected string soBaoDanh;
        public string SoBaoDanh
        {
            get { return soBaoDanh; }
            set { soBaoDanh = value; }
        }

        protected DiemThi diemThi = new DiemThi();
        public DiemThi DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }

        public ThiSinh()
        {

        }

        public void Nhap()
        {
            hoTen.Nhap();
            QueQuan.Nhap();
            Console.Write("-Nhap truong: ");
            truong = Console.ReadLine();
            Console.Write("-Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("-Nhap so bao danh: ");
            soBaoDanh = Console.ReadLine();
            diemThi.Nhap();
        }

        public void Xuat()
        {
            HoTen.Xuat();
            Console.Write("\t\t");
            QueQuan.Xuat();
            Console.Write("\t" + soBaoDanh + "\t\t\t");
            DiemThi.Xuat();
        }
    }
}
