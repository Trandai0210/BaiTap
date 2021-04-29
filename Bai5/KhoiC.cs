namespace Bai5
{
    class KhoiC : ThiSinh
    {
        public KhoiC()
        {

        }

        public override bool TrungTuyen()
        {
            if (diem1 + diem2 + diem3 + diemUuTien > 13.5)
                return true;
            return false;
        }
    }
}
