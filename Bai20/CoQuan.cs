using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class CoQuan:Nguoi
    {
        protected string donViCongTac;
        public string DonViCongTac
        {
            get { return donViCongTac; }
            set { donViCongTac = value; }
        }

        protected double heSoLuong;
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }

        public CoQuan()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("-Nhap don vi cong tac: ");
            donViCongTac = Console.ReadLine();
            Console.Write("-Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());
        }
        public override void In()
        {
            base.In();
            Console.WriteLine("\t-Don vi cong tac: " + donViCongTac);
            Console.WriteLine("\t-He so luong: " + heSoLuong);
        }

        public double TinhLuong()
        {
            return heSoLuong * 1050000;
        }
    }
}
