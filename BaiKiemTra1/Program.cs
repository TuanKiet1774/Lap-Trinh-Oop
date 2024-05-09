using System;

namespace BaiKiemTra1
{
    internal class Program
    {
        public class NhanVien
        {
            private string maNV;
            private string hoten;
            private double hsluong;
            private static int LuongCB = 1500000;

            public string MaNV
            {
                get { return maNV; }
                set { if(value.Length > 0) maNV = value; }
            }

            public string Hoten
            {
                get { return hoten; }
                set { if (value.Length > 0) hoten = value; }
            }

            public double Hsluong
            {
                get { return hsluong; }
                set { if (value >= 2 && value <= 6) hsluong = value; }
            }

            public NhanVien(string mnv = "", string ht = "", double hsl = 1)
            {
                maNV = mnv;
                hoten = ht;
                hsluong = hsl;
            }

            public void Nhap()
            {
                do
                {
                    Console.Write("Nhap ma so: ");
                    maNV = Console.ReadLine();
                }
                while (maNV.Length <= 0);
                do
                {
                    Console.Write("Nhap ten: ");
                    hoten = Console.ReadLine();
                }
                while (hoten.Length <= 0);
                do
                {
                    Console.Write("Nhap he so luong: ");
                    hsluong = double.Parse(Console.ReadLine());
                }
                while (!(hsluong >= 2 && hsluong <= 6));
            }

            public void Xuat()
            {
                Console.WriteLine(String.Format("Nhan vien: {0, -20 }",hoten) + String.Format("| Ma so: {0, -5}",maNV) + String.Format("| Tien luong: {0:#0.00}",Luong()));
            }

            public double Luong()
            {
                return hsluong * LuongCB; 
            }
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong nhan vien: ");
                n = int.Parse(Console.ReadLine());
            }
            while (!(n > 0 && n < 100));

            NhanVien[] ds = new NhanVien[n];
            double hsl_max = 0;

            //Tạo và nhâp ds nhân viên 
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("\nNhan vien {0}",i+1);
                ds[i] = new NhanVien();
                ds[i].Nhap();
                if (ds[i].Hsluong > hsl_max) hsl_max = ds[i].Hsluong;
            }
            
            //In ra danh sách nhân viên vừa nhập
            Console.WriteLine("\nDanh sach nhan vien: ");
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }

            //In ra danh sách nhân viên có hệ số lương cao nhất
            Console.WriteLine("\nDanh sach nhan vien co he so luong co nhat: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].Hsluong == hsl_max) 
                    ds[i].Xuat();
            }

            //Sắp xếp danh sách sinh viên theo thứ tự giảm dần của tiền lương            
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (ds[i].Luong() < ds[j].Luong())
                    {
                        var tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }    
                }    
            }
            Console.WriteLine("\nDanh sach nhan vien theo thu tu giam dan tien luong: ");
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }
        }
    }
}
