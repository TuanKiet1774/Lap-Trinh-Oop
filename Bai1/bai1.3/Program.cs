using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vt, gio, tong = 1;
            Console.Write("So vi trung ban dau: ");
            vt = int.Parse(Console.ReadLine());
            Console.Write("So gio: ");
            gio = int.Parse(Console.ReadLine());
            if (vt < 0 || gio < 0) Console.WriteLine("Error");
            else
            {
                for (int t = 1; t <= gio; t++) vt = vt * 2;
                Console.WriteLine("Tong so vi trung sau {0} gio = {1}", gio, vt);
            }
        }
    }
}
