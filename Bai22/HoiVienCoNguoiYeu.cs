using System;
using System.Collections.Generic;
using System.Text;

namespace Bai22
{
    class HoiVienCoNguoiYeu:HoiVien
    {
        protected string hoTenNguoiYeu;
        public string HoTenNguoiTen
        {
            get { return hoTenNguoiYeu; }
            set { hoTenNguoiYeu = value; }
        }

        protected string soDienThoaiNguoiYeu;
        public string SoDienThoaiNguoiYeu
        {
            get { return soDienThoaiNguoiYeu; }
            set { soDienThoaiNguoiYeu = value; }
        }

        public HoiVienCoNguoiYeu()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t+ Nhap ho ten nguoi yeu: ");
            hoTenNguoiYeu = Console.ReadLine();
            Console.Write("\t+ So dien thoai nguoi yeu: ");
            SoDienThoaiNguoiYeu = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t+ Ho ten nguoi yeu: " + hoTenNguoiYeu);
            Console.WriteLine("\t+ So dien thoai nguoi yeu " + soDienThoaiNguoiYeu);
        }
    }
}
