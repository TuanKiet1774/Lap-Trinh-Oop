using System;

namespace bai3._4
{
    public class Printer
    {
        public string _NhaSanXuat;
        public double _GiaBan;

        public Printer(string nhaSanXuat, double giaBan)
        {
            _NhaSanXuat = nhaSanXuat;
            _GiaBan = giaBan;
        }

        public virtual void Nhap()
        {
            Console.Write("Nha san xuat: ");
            _NhaSanXuat = Console.ReadLine();
            Console.Write("Gia ban: ");
            _GiaBan = double.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Nha san xuat: {0}", _NhaSanXuat);
            Console.WriteLine("Gia ban: {0}", _GiaBan);
        }
    }

    public class LaserPrinter : Printer
    {
        public string _DoPhanGiai;

        public LaserPrinter() : base("",0)
        {
            _DoPhanGiai = "";
        }

        public override void Nhap() 
        {
            base.Nhap();
            Console.Write("Do phan giai: ");
            _DoPhanGiai += Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Do phan giai: {0}", _DoPhanGiai);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong: ");
            n = int.Parse(Console.ReadLine());
            LaserPrinter[] Ds = new LaserPrinter[n];
            //Nhập danh sách n máy in laser.
            for (int i = 0; i<n; i++)
            {
                Ds[i] = new LaserPrinter();
                Console.WriteLine("\nMay: {0}", i + 1);
                Ds[i].Nhap();
            }
            
            //In ra danh sách và thông số kèm theo.
            Console.WriteLine("\nDanh sach may in Laser: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nMay: {0}", i + 1);
                Ds[i].Xuat();
            }

            double Gia_Max = 0;
            double Gia_Min = double.MaxValue;
            int vt_max = 0;
            int vt_min = 0;
            
            //Tìm máy in có giá thấp nhất, cao nhất.
            for (int i = 0; i < n; i++)
            {
                if (Ds[i]._GiaBan > Gia_Max)
                {
                    Gia_Max = Ds[i]._GiaBan;
                    vt_max = i;
                }
                else if (Ds[i]._GiaBan < Gia_Min)
                {
                    Gia_Min = Ds[i]._GiaBan;
                    vt_min = i;
                }
            }
            Console.WriteLine("\nMay in co gia cao nhat: ");
            Ds[vt_max].Xuat();
            Console.WriteLine("\nMay in co gia thap nhat: ");
            Ds[vt_min].Xuat();
            
            //Lọc danh sách máy in theo tên hãng sản xuất.
            Console.Write("\nNhap nha san xuat muon tim: ");
            string nsx = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (Ds[i]._NhaSanXuat == nsx) Ds[i].Xuat();
            }

            //Sắp xếp danh sách xe theo thứ tự tăng dần của giá bán
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Ds[i]._GiaBan > Ds[j]._GiaBan)
                    {
                        LaserPrinter tam = Ds[i];
                        Ds[i] = Ds[j];
                        Ds[j] = tam;
                    }    
                }    
            }
            Console.WriteLine("\nDanh sach sau khi xep theo gia ban tang dan: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nMay: {0}", i + 1);
                Ds[i].Xuat();
            }
        }
    }
}
