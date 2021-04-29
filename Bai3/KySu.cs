using System;

namespace Bai3
{
    class KySu : CanBo
    {
        protected string nganhDaoTao;
        public string NganhDaoTao
        {
            get { return nganhDaoTao; }
            set { nganhDaoTao = value; }
        }

        public KySu()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("-Nhap nganh dao tao: ");
            nganhDaoTao = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Nganh dao tao: " + nganhDaoTao);
        }
    }
}
