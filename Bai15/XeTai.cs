using System;
using System.Collections.Generic;
using System.Text;

namespace Bai15
{
    class XeTai:PTGT
    {
        protected double trongTan;
        public double TrongTan
        {
            get { return trongTan; }
            set { trongTan = value; }
        }

        public XeTai()
        {

        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("-Trong tan: ");
            trongTan = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-Trong tan: " + trongTan);
        }
    }
}
