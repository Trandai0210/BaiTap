namespace Bai12
{
    class VanBan
    {
        protected string str;
        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public VanBan()
        {

        }

        public VanBan(string str)
        {
            this.str = str;
        }

        public int DemTu()
        {
            int tu = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    tu++;
                }
            }
            return tu;
        }

        public int sokytuh()
        {
            int slxh = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'h' || str[i] == 'H')
                {
                    slxh++;
                }
            }
            return slxh;
        }

        public void ChuanHoa()
        {
            string chuanhoa = "";
            int first = 0;
            int last = str.Length - 1;

            while (str[first] == ' ' && first < last)
                first++;
            while (str[last] == ' ' && last > first)
                last--;
            str.ToLower();
            for (int i = first; i <= last; i++)
            {
                if (i + 1 <= last)
                {
                    if (str[i] == ' ' && str[i + 1] == ' ')
                        continue;
                }
                chuanhoa += str[i];
            }
            str = chuanhoa;
        }
    }
}
