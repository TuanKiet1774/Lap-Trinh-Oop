using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace bai1._4
{
    internal class Program
    {
        public static void NhapMang(int[] a, out int n)
        {
            Console.Write("Nhap so luong: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void InMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        public static int MaxMang(int[] a, int n)
        {
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                if(max < a[i]) max = a[i];
            }
            return max; 
        }

        public static bool KiemTra(int[] a, int n)
        {
            if (n <= 1)
                return true;

            for (int i = 1; i < n; i++)
            {
                if (a[i] < a[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void SapXep(int[] a, int n)
        {
            for(int i =0; i < n; i++)
            {
                int temp;
                for(int j = i+1; j < n; j++)
                {
                    if ((a[j] < a[i]))
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            InMang(a, n);
        }

        public static void TachMang(int[] a, int n)
        {
            int[] c = new int[1000];
            int sc = 0;
            int[] l = new int[1000];
            int sl = 0;
            for(int i = 0;i < n; i++)
            {
                if (a[i] % 2 == 0) c[sc++] = a[i];
                else l[sl++] = a[i];
            }
            Console.Write("Mang chan: ");
            InMang(c, sc);
            Console.Write("Nhap le: ");
            InMang(l, sl);
        }

        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            NhapMang(a, out n);
            Console.Write("Noi dung mang: ");
            InMang(a, n);

            int max = MaxMang(a, n);
            Console.WriteLine("Gia tri lon nhat: {0}", max);

            if (KiemTra(a, n) == true) Console.WriteLine("Mang tang dan");
            else Console.WriteLine("Mang khong tang dan");

            if (KiemTra(a, n) == false)
            {
                Console.Write("Mang tang dan: ");
                SapXep(a, n);
                Console.WriteLine();
            }
            else Console.WriteLine("Mang da sap xep");

            TachMang(a, n);
        }
    }
}
