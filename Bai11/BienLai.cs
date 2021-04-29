using System;

namespace Bai11
{
    class BienLai
    {
        protected KhachHang khach;
        public KhachHang Khach
        {
            get { return khach; }
            set { khach = value; }
        }

        protected double chiSoCu;
        public double ChiSoCu
        {
            get { return chiSoCu; }
            set { chiSoCu = value; }
        }

        protected double chiSoMoi;
        public double ChiSoMoi
        {
            get { return chiSoMoi; }
            set { chiSoMoi = value; }
        }

        protected double soTienPhaiTra;
        public double SoTienPhaiTra
        {
            get { return soTienPhaiTra; }
            set { soTienPhaiTra = value; }
        }

        public BienLai()
        {

        }

        public void Nhap()
        {
            Khach = new KhachHang();
            Khach.Nhap();
            Console.WriteLine("-Nhap chi so cu: ");
            ChiSoCu = double.Parse(Console.ReadLine());
            Console.WriteLine("-Nhap chi so moi: ");
            ChiSoMoi = double.Parse(Console.ReadLine());
            if (ChiSoMoi - ChiSoCu < 50)
                soTienPhaiTra = (ChiSoMoi - ChiSoCu) * 1250;
            else
            {
                if (ChiSoMoi - ChiSoCu >= 50 && ChiSoMoi - ChiSoCu < 100)
                    soTienPhaiTra = (ChiSoMoi - ChiSoCu) * 1500;
                else
                    soTienPhaiTra = (ChiSoMoi - ChiSoCu) * 2000;
            }
        }
        public void Xuat()
        {
            Khach.Xuat();
            Console.WriteLine("-Chi so cu: " + ChiSoCu);
            Console.WriteLine("-Chi so moi: " + ChiSoMoi);
            Console.WriteLine("-So tien phai tra: " + soTienPhaiTra);
        }
    }
}
