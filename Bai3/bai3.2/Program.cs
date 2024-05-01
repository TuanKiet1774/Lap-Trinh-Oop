using System;

namespace bai3._2
{
    public class NhanVien
    {
        public string _HoTen;
        public DateTime _NgaySinh;
        public double _luong;

        public NhanVien(string hoTen, DateTime ngaySinh )
        {
            _HoTen = hoTen;
            _NgaySinh = ngaySinh;
        }

        public virtual void Luong()
        {

        }

        public virtual void Nhap()
        {
            Console.Write("Ho va ten: ");
            _HoTen = Console.ReadLine();
            Console.Write("Ngay sinh(mm/dd/yy): ");
            string sinh = Console.ReadLine();
            _NgaySinh = DateTime.Parse(sinh);
        }

        public virtual void Xuat() 
        {
            Console.WriteLine("Ho ten: {0}",_HoTen);
            Console.WriteLine("Ngay sing: {0}",_NgaySinh.ToString("dd/MM/yyyy"));
        }
    }
    
    public class NvSanXuat : NhanVien
    {
        public double LuongCB;
        public int SoSP;

        public NvSanXuat() : base(" ", DateTime.Now)
        {
            LuongCB = 0;
            SoSP = 0;
        }

        public override void Luong()
        {
            _luong = LuongCB + SoSP * 5000;
            Console.WriteLine("Luong nhan vien SX: {0}", _luong);
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Luong co ban: ");
            LuongCB = double.Parse(Console.ReadLine());
            Console.WriteLine("So san pham: ");
            SoSP = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Luong();
        }
    }

    public class NvVanPhong : NhanVien
    {
        public int SoNgay;
        public NvVanPhong() : base("", DateTime.Now)
        {
            SoNgay = 0;
        }

        public override void Luong()
        {
            _luong = SoNgay * 100000;
            Console.WriteLine("Luong nhan vien VP: {0}", _luong);
        }


        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So ngay lam viec: ");
            SoNgay = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Luong();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien [] DsNv = new NhanVien[n];

            int LoaiNv;
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("\nNhan vien {0}", i + 1);
                Console.Write("Loai nhan vien: ");
                LoaiNv = int.Parse(Console.ReadLine());
                if(LoaiNv == 1)
                {
                    DsNv[i] = new NvVanPhong();
                    DsNv[i].Nhap();
                }    
                else if(LoaiNv == 2)
                {
                    DsNv[i] = new NvSanXuat();
                    DsNv[i].Nhap();
                }
            }
            //Dánh sách nhân viên
            Console.WriteLine("\nDanh sach nhan vien: ");
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Nhan vien {0}", i + 1);
                DsNv[i].Xuat();
            }
            //Sắp xếp theo số lương giảm dần
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (DsNv[i]._luong < DsNv[j]._luong)
                    {
                        NhanVien tam = DsNv[i];
                        DsNv[i] = DsNv[j];
                        DsNv[j] = tam;
                    }    
                }    
            }
            Console.WriteLine("\nDanh sach sau khi xep theo so luong giam dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien {0}", i + 1);
                DsNv[i].Xuat();
            }

        }    
    }
}
