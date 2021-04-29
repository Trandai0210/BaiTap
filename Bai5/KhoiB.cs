namespace Bai5
{
    class KhoiB : ThiSinh
    {
        public KhoiB()
        {

        }

        public override bool TrungTuyen()
        {
            if (diem1 + diem2 + diem3 + diemUuTien > 16)
                return true;
            return false;
        }
    }
}
