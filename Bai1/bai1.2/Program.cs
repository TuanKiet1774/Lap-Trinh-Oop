using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            //double ketQua = 0;

            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan(+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            switch(phepToan)
            {
                case '+': Console.WriteLine("{0} + {1} = {2}", a, b, a + b); break;
                case '-': Console.WriteLine("{0} - {1} = {2}", a, b, a - b); break;
                case '*': Console.WriteLine("{0} * {1} = {2}", a, b, a * b); break;
                case '/':
                    if (b == 0) Console.WriteLine("Khong the chia cho 0!");
                    else Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b); break;
                default: Console.WriteLine("Nhap sai phep tinh"); break;
            } 
        }
    }
}
