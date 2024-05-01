using System;

namespace bai3._3
{
    public abstract class HinhVe
    {
        public abstract double DienTich();
    }
    public class HinhChuNhat : HinhVe
    {
        public double ChieuDai;
        public double ChieuRong;

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }
    
    public class HinhTron : HinhVe
    {
        public double R;
        
        public HinhTron(double r)
        {
            R = r;
        }


        public override double DienTich()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }

    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong() : base(0,0)
        {
            
        }
        public override double DienTich()
        {
            return base.DienTich();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("1. Hinh Chu Nhat");
            Console.WriteLine("2. Hinh Vuong");
            Console.WriteLine("3. Hinh Tron");
            Console.WriteLine("0. Stop");
            
            do
            {
                Console.Write("\nChon: ");
                s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        Console.Write("Chieu dai: ");
                        double CD = double.Parse(Console.ReadLine());
                        Console.Write("Chieu rong: ");
                        double CR = double.Parse(Console.ReadLine());
                        HinhChuNhat hcn = new HinhChuNhat(CD, CR);
                        Console.WriteLine("Dien tich: {0}", hcn.DienTich());
                        break;
                    case 2:
                        Console.Write("Canh: ");
                        double C = double.Parse(Console.ReadLine());
                        HinhChuNhat hv = new HinhChuNhat(C, C);
                        Console.WriteLine("Dien tich: {0}", hv.DienTich());
                        break;
                    case 3:
                        Console.Write("Ban kinh: ");
                        double bk = double.Parse(Console.ReadLine());
                        HinhTron ht = new HinhTron(bk);
                        Console.WriteLine("Dien tich: {0:0.00}", ht.DienTich());
                        break;
                    default: break;
                }
            }
            while (s != 0);
        }
    }
}
