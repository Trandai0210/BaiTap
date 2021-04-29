using System;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "   hoc   de   thay   doi    ";
            VanBan vanBan = new VanBan(s);
            Console.WriteLine("van ban co {0} tu", vanBan.DemTu());
            Console.WriteLine("van ban co {0} ky tu \'h\' ", vanBan.sokytuh());
            vanBan.ChuanHoa();
            Console.WriteLine(vanBan.Str);
        }
    }
}
