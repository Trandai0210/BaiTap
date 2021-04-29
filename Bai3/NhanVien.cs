using System;

namespace Bai3
{
    class NhanVien : CanBo
    {
        protected string congViec;
        public string CongViec
        {
            get { return congViec; }
            set { congViec = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("-Nhap cong viec: ");
            congViec = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Cong viec: " + congViec);
        }
    }
}
