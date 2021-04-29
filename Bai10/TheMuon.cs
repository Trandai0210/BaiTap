using System;

namespace Bai10
{
    class TheMuon
    {
        protected string soPhieuMuon;
        public string SoPhieuMuon
        {
            get { return soPhieuMuon; }
            set { soPhieuMuon = value; }
        }

        protected DateTime ngayMuon;
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

        protected DateTime hanTra;
        public DateTime HanTra
        {
            get { return hanTra; }
            set { hanTra = value; }
        }

        protected string soHieuSach;
        public string SoHieuSach
        {
            get { return soHieuSach; }
            set { soHieuSach = value; }
        }

        protected SinhVien sinhVien;
        public SinhVien SinhVien
        {
            get { return sinhVien; }
            set { sinhVien = value; }
        }
        public TheMuon()
        {

        }

        public void Nhap()
        {
            Console.Write("-Nhap so phieu muon: ");
            SoPhieuMuon = Console.ReadLine();
            Console.Write("-Nhap ngay muon: ");
            ngayMuon = Convert.ToDateTime(Console.ReadLine());
            Console.Write("-Nhap han tra: ");
            hanTra = Convert.ToDateTime(Console.ReadLine());
            Console.Write("-Nhap so hieu sach: ");
            soHieuSach = Console.ReadLine();
            sinhVien = new SinhVien();
            sinhVien.Nhap();
        }

        public void Xuat()
        {
            Console.Write("-So phieu muon: " + SoHieuSach);
            Console.Write("-Ngay muon: " + NgayMuon);
            Console.Write("-Han tra: " + hanTra);
            Console.Write("-So hieu sach: " + SoHieuSach);
            sinhVien.Xuat();
        }
    }
}
