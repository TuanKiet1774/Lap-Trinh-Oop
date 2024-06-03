using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace XeMay
{
    public abstract class XeMay
    {
        private string BienSo;
        private int NamSX;
        
        public string bienso
        {
            get { return BienSo; }
            set { if(value.Length > 0 ) BienSo = value; }
        }

        public int namSX
        {
            get { return NamSX; }
            set { if (value > 0) NamSX = value; }
        }

        public XeMay(string bs = " ", int nsx = 0)
        {
            BienSo = bs;
            NamSX = nsx;
        }

        public virtual void Nhap()
        {
            Console.Write("Bien so: ");
            do
            {
                BienSo = Console.ReadLine();
            }    
            while(!(BienSo.Length > 0));

            Console.Write("Nam san xuat: ");
            do
            {
                NamSX = int.Parse(Console.ReadLine());
            }
            while (!(NamSX > 0));
        }

        public virtual void Xuat()
        {
            Console.Write("Bien so: {0} - Nam san xuat: {1} ", BienSo, NamSX);
        }

        public abstract int BaoHanh(); 

    }

    public class XeDien:XeMay
    {
        private double Pin;

        public double dlpin
        {
            get { return Pin; }
            set { if( value > 0 ) Pin = value; }
        }

        public XeDien(string bs = " ", int nsx = 0, double pin = 0):base(bs,nsx)
        {
            Pin = pin;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Dung luong pin: ");
            do
            {
                Pin = double.Parse(Console.ReadLine());
            }
            while (!(Pin > 0));
        }

        public override void Xuat()
        {
            Console.Write("Xe Dien - ");
            base.Xuat();
            Console.WriteLine("- Dung luong pin: {0}", Pin);
        }

        public override int BaoHanh()
        {
            return namSX + 3;
        }
    }

    public class XeXang:XeMay
    {
        private double XiLanh;

        public double xiLanh
        {
            get { return  XiLanh; }
            set { if( value > 0 ) XiLanh = value; }
        }

        public XeXang(string bs = " ", int nsx = 0, double xl = 0):base(bs,nsx)
        {
            XiLanh = xl;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Dung tich xi lanh: ");
            do
            {
                XiLanh = double.Parse(Console.ReadLine());
            }
            while (!(XiLanh > 0));
        }

        public override void Xuat()
        {
            Console.Write("Xe Xang - ");
            base.Xuat();
            Console.WriteLine("- Dung tich xi lanh: {0}", XiLanh);
        }

        public override int BaoHanh()
        {
            return namSX + 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập thông tin n xe máy vào một danh sách
            Console.Write("So luong xe: ");
            int n = int.Parse(Console.ReadLine());

            XeMay[] ds = new XeMay[n];

            Console.WriteLine("1 - Xe Dien \n2 - Xe Xang");
            int c;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nChon xe {0}: ", i + 1);
                do
                {
                    c = int.Parse(Console.ReadLine());
                }
                while (!(c == 1 || c == 2));

                if (c == 1)
                {
                    ds[i] = new XeDien();
                    ds[i].Nhap();
                }
                else if (c == 2)
                {
                    ds[i] = new XeXang();
                    ds[i].Nhap();
                }
            }

            //In danh sách xe vừa nhập và thông tin chi tiết từng xe. 
            Console.WriteLine("\nDanh sach cac loai xe may: ");
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }

            //Liệt kê các xe hết thời hạn bảo hành. 
            Console.WriteLine("\nDanh sach cac loai xe het thoi han bao hanh: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].BaoHanh() < DateTime.Now.Year)
                {
                    ds[i].Xuat();
                    Console.WriteLine("Han Bao Hanh: {0}", ds[i].BaoHanh());
                }

            }

            //Sắp xếp danh sách xe theo từng loại, trong mỗi loại có năm sản xuất tăng dần.
            List<XeDien> dsxd = new List<XeDien>();
            List<XeXang> dsxx = new List<XeXang>();

            for (int i = 0; i < n; i++)
            {
                if (ds[i].GetType().ToString() == "XeMay.XeDien")
                {
                    dsxd.Add((XeDien)ds[i]);
                }
                else
                {
                    dsxx.Add((XeXang)ds[i]);
                } 
            }

            Console.WriteLine("\nDanh sach xe dien tang dan theo nam san xuat: ");
            for (int i = 0; i < dsxd.Count-1; i++)
            {
                for (int j = i + 1; j < dsxd.Count; j++)
                {
                    if ((dsxd[i].namSX > dsxd[i].namSX))
                    {
                        var temp = dsxd[i];
                        dsxd[i] = dsxd[j];
                        dsxd[j] = temp;
                    }
                }
            }

            for (int i = 0; i < dsxd.Count; i++)
            {
                dsxd[i].Xuat();
            }    

            Console.WriteLine("\nDanh sach xe xang tang dan theo nam san xuat: ");
            for (int i = 0; i < dsxx.Count - 1; i++)
            {
                for (int j = i + 1; j < dsxx.Count; j++)
                {
                    if ((dsxx[i].namSX > dsxx[i].namSX))
                    {
                        var temp = dsxx[i];
                        dsxx[i] = dsxx[j];
                        dsxx[j] = temp;
                    }
                }
            }

            for (int i = 0; i < dsxx.Count; i++)
            {
                dsxx[i].Xuat();
            }

            //Liệt kê các xe thuộc tỉnh Khánh Hòa 
            Console.WriteLine("\nDanh sach xe cua Khanh Hoa: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].bienso.Substring(0,2) == "79")
                {
                    ds[i].Xuat();
                } 
                    
            }    
        }
    }
}
