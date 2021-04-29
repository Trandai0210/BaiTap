using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class Nguoi:CaNhan
    {
        public Nguoi()
        {

        }

        public Nguoi(string hoTen,Boolean gt ,int tuoi)
        {
            this.hoTen = hoTen;
            gioiTinh = gt;
            this.tuoi = tuoi;
        }

        public override void Nhap()
        {
            base.Nhap();
        }
        public override void In()
        {
            base.In();
        }
    }
}
