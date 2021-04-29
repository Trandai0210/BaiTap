namespace Bai5
{
    class KhoiA : ThiSinh
    {
        public KhoiA()
        {

        }

        public override bool TrungTuyen()
        {
            if (diem1 + diem2 + diem3 + diemUuTien > 15)
                return true;
            return false;
        }
    }
}
