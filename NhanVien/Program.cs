using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace NhanVien
{
    public static class MyLuong
    {
        public static int luongcb = 1500000;
    } 
    public class NhanVien
    {
        //Các trường
        private string maNV;
        private string hoten;
        private double hsluong;
        //Các thuộc tính
        public string MaNV
        {
            get { return maNV; }
            set { if (value.Length > 0) maNV = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set { if (value.Length > 0) hoten = value; }
        }

        public double HSluong
        {
            get { return hsluong; }
            set { if(value >=2 && value <=6) hsluong = value; }
        }
        //Phương thức thiết lập
        public NhanVien(string ms = "", string ht = "", double hs = 1)
        {
            MaNV = ms;
            hoten = ht;
            hsluong = hs;
        }

        //Nhập
        public void Nhap()
        {
            Console.Write("Nhập mã số: ");
            maNV = Console.ReadLine();
            Console.Write("Nhập tên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập hệ số lương: ");
            hsluong = double .Parse(Console.ReadLine());
        }
        //Tính lương
        public double Luong()
        {
            return hsluong * MyLuong.luongcb;
        }
        //Xuất
        public void Xuat()
        {
            Console.WriteLine("Nhân viên: {0} - {1} - lương {2}",maNV,hoten,Luong());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tạo và nhập danh sách n nhân viên (0 < n < 100) từ bàn phím.
            int n;
            do
            {
                Console.Write("Nhập số lượng: ");
                n = int.Parse(Console.ReadLine());
            }
            while (!(n > 0 && n < 100));

            double hsl_max = 0;

            NhanVien[] ds = new NhanVien[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien {0}",i+1);
                ds[i] = new NhanVien();
                ds[i].Nhap();
                if (ds[i].HSluong > hsl_max) hsl_max = ds[i].HSluong;
            }

            // In danh sách nhân viên vừa nhập, mỗi nhân viên trên một dòng.
            Console.WriteLine("\nDanh sách nhân viên: ");
            for(int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }

            // In ra thông tin (các) nhân viên có hệ số lương cao nhất.
            Console.WriteLine("\nDanh sách nhân viên có hệ số lương cao nhất: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].HSluong == hsl_max)
                    ds[i].Xuat();
            }
            //Sắp xếp danh sách nhân viên theo thứ tự giảm dần của tiền lương
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].Luong() < ds[j].Luong())
                    {
                        var tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    } 
                }
            }
            Console.WriteLine("\nDanh sách nhân viên theo thứ tự giảm dần của tiền lương: ");
            for (int i = 0; i < n; i++)
            {
                    ds[i].Xuat();
            }
        }
    }
}
