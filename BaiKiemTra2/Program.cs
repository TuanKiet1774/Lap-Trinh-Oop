using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sp
{
    internal interface ISanPham
    {
        void Nhap();
        double TinhTien();
        void Xuat();
    }

    public class Gao : ISanPham
    {
        public double KhoiLuong { get; set; }
        public double DonGia { get; set; }

        public Gao(double kl = 0, double dg = 0)
        {
            KhoiLuong = kl;
            DonGia = dg;
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Khoi luong: ");
                KhoiLuong = double.Parse(Console.ReadLine());
            }
            while (!(KhoiLuong > 0));
            do
            {
                Console.Write("Don gia: ");
                DonGia = double.Parse(Console.ReadLine());
            }
            while (!(DonGia > 0));

        }

        public void Xuat()
        {
            Console.WriteLine("\tKhoi luong: {0} kg - Don gia: {1} VND/kg", KhoiLuong, DonGia);
        }

        public double TinhTien()
        {
            return KhoiLuong * DonGia;
        }
    }

    public class DauAn : ISanPham
    {
        public double DungTich { get; set; }
        public double DonGia { get; set; }

        public DauAn(double dt = 0, double dg = 0)
        {
            DungTich = dt;
            DonGia = dg;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Dung tich: ");
                DungTich = double.Parse(Console.ReadLine());
            }
            while (!(DungTich > 0));
            do
            {
                Console.Write("Don gia: ");
                DonGia = double.Parse(Console.ReadLine());
            }
            while (!(DonGia > 0));
        }

        public void Xuat()
        {
            Console.WriteLine("\tDung tich: {0} lit - Don gia: {1} VND/lit", DungTich, DonGia);
        }
        public double TinhTien()
        {
            return DungTich * DonGia;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong: ");
                n = int.Parse(Console.ReadLine());
            }
            while (!(n > 0));

            ISanPham[] ds = new ISanPham[n];

            int c;
            //Nhap danh sach san pham
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Nhap lua chon (1: Gao - 2: Dau An): ");
                    c = int.Parse(Console.ReadLine());
                }
                while (!(c == 1 || c == 2));
                if (c == 1)
                {
                    Console.WriteLine("Nhap thong tin cho san pham gao");
                    ds[i] = new Gao();
                    ds[i].Nhap();
                }
                else if (c == 2)
                {
                    Console.WriteLine("Nhap thong tin cho san pham dau an");
                    ds[i] = new DauAn();
                    ds[i].Nhap();
                }
            }

            //Xuat danh sach cac san pham
            Console.WriteLine("\nDanh sach san pham: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].GetType().ToString() == "sp.Gao")
                {
                    Console.Write("San pham {0} la gao", i + 1);
                    ds[i].Xuat();
                }
                else
                {
                    Console.Write("San pham {0} la dau an", i + 1);
                    ds[i].Xuat();
                }
            }

            //Sap xep danh sach theo tong tien giam dan
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].TinhTien() < ds[j].TinhTien())
                    {
                        var tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }

            Console.WriteLine("\nDanh sach san pham xep theo tong tien giam dan: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].GetType().ToString() == "sp.Gao")
                {
                    Console.Write("San pham {0} la gao", i + 1);
                    ds[i].Xuat();
                }
                else
                {
                    Console.Write("San pham {0} la dau an", i + 1);
                    ds[i].Xuat();
                }
            }

            //Tinh tong doanh thu moi loai
            double dt_gao = 0;
            double dt_dau = 0;
            Console.WriteLine("\nDanh sach tong doanh thu moi loai: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].GetType().ToString() == "sp.Gao")
                {
                    dt_gao += ds[i].TinhTien();
                }
                else
                {
                    dt_dau += ds[i].TinhTien();
                }
            }

            Console.WriteLine("Doanh thu gao: {0} VND", dt_gao);
            Console.WriteLine("Doanh thu dau an: {0} VND", dt_dau);
        }
    }
}
