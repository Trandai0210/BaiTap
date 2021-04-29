using System;
using System.Collections.Generic;
using System.Text;

namespace Bai15
{
    class OTo:PTGT
    {
        protected int soChoNgoi;
        public int SoChoNgoi
        {
            get { return soChoNgoi; }
            set { soChoNgoi = value; }
        }

        protected string kieuDongCo;
        public string KieuDongCo
        {
            get { return kieuDongCo; }
            set { kieuDongCo = value; }
        }

        public OTo()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("-So cho ngoi: " + soChoNgoi);
            soChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("-Kieu dong co: " + kieuDongCo);
            kieuDongCo = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-So cho ngoi: "+ soChoNgoi);
            Console.WriteLine("-Kieu dong co: " + kieuDongCo);
        }
    }
}
