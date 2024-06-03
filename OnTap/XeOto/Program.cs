using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace XeOto
{
    public abstract class Xe
    {
        private string BienSo;
        private int NamSX;

        public string bienso
        {
            get { return BienSo; }
            set { if (value.Length > 0) BienSo = value; }
        }

        public int namSX
        {
            get { return NamSX; }
            set { if (value > 0) NamSX = value; }
        }

        public Xe(string bs = " ", int nsx = 0)
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
            while (!(BienSo.Length > 0));

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

        public abstract int HanSuDung();

    }

    public class XeCon : Xe
    {
        private int SoCho;
        public int socho
        {
            get { return SoCho; }
            set { if(value > 0) SoCho = value; }
        }

        public XeCon(string bs = " ", int nsx = 0, int sc = 0):base(bs,nsx)
        {
            SoCho = sc;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So cho ngoi: ");
            do
            {
                SoCho = int.Parse(Console.ReadLine());
            }
            while (!(SoCho > 0));
        }

        public override void Xuat()
        {
            Console.Write("Xe Con - ");
            base.Xuat();
            Console.WriteLine("- So cho: {0}", SoCho);
        }

        public override int HanSuDung()
        {
            return namSX + 30;
        }
    }

    public class XeTai : Xe 
    {
        private double TaiTrong;
        public double taitrong
        {
            get { return TaiTrong; }
            set { if(value > 0) TaiTrong = value; }
        }

        public XeTai(string bs = " ", int nsx = 0, double tt = 0):base(bs,nsx)
        {
            TaiTrong = tt;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tai trong: ");
            do
            {
                TaiTrong = double.Parse(Console.ReadLine());
            }
            while (!(TaiTrong > 0));
        }

        public override void Xuat()
        {
            Console.Write("Xe Tai - ");
            base.Xuat();
            Console.WriteLine("- Tai trong: {0}", TaiTrong);
        }

        public override int HanSuDung()
        {
            return namSX + 20;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập thông tin n xe máy vào một danh sách
            Console.Write("So luong xe: ");
            int n = int.Parse(Console.ReadLine());

            Xe[] ds = new Xe[n];

            Console.WriteLine("1 - Xe Con \n2 - Xe Tai");
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
                    ds[i] = new XeCon();
                    ds[i].Nhap();
                }
                else if (c == 2)
                {
                    ds[i] = new XeTai();
                    ds[i].Nhap();
                }
            }

            //In danh sách xe vừa nhập và thông tin chi tiết từng xe. 
            Console.WriteLine("\nDanh sach cac loai xe: ");
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }

            //Liệt kê các xe hết thời hạn bảo hành. 
            Console.WriteLine("\nDanh sach xe het thoi han luu hanh: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].HanSuDung() < DateTime.Now.Year)
                {
                    ds[i].Xuat();
                    Console.WriteLine("Thoi han luu hanh: {0}", ds[i].HanSuDung());
                }
            }

            //Sắp xếp danh sách xe theo từng loại, trong mỗi loại có năm sản xuất tăng dần.
            List<XeCon> dsxc = new List<XeCon>();
            List<XeTai> dsxt = new List<XeTai>();

            for (int i = 0; i < n; i++)
            {
                if (ds[i].GetType().ToString() == "Xe.XeCon")
                {
                    dsxc.Add((XeCon)ds[i]);
                }
                else
                {
                    dsxt.Add((XeTai)ds[i]);
                }
            }

            Console.WriteLine("\nDanh sach xe con tang dan theo nam san xuat: ");
            for (int i = 0; i < dsxc.Count - 1; i++)
            {
                for (int j = i + 1; j < dsxc.Count; j++)
                {
                    if ((dsxc[i].namSX > dsxc[i].namSX))
                    {
                        var temp = dsxc[i];
                        dsxc[i] = dsxc[j];
                        dsxc[j] = temp;
                    }
                }
            }
            for (int i = 0; i < dsxc.Count; i++)
            {
                dsxc[i].Xuat();
            }

            Console.WriteLine("\nDanh sach xe tai tang dan theo nam san xuat: ");
            for (int i = 0; i < dsxt.Count - 1; i++)
            {
                for (int j = i + 1; j < dsxt.Count; j++)
                {
                    if ((dsxt[i].namSX > dsxt[i].namSX))
                    {
                        var temp = dsxt[i];
                        dsxt[i] = dsxt[j];
                        dsxt[j] = temp;
                    }
                }
            }

            for (int i = 0; i < dsxt.Count; i++)
            {
                dsxt[i].Xuat();
            }

            //Liệt kê các xe thuộc tỉnh Khánh Hòa 
            Console.WriteLine("\nDanh sach xe cua Khanh Hoa: ");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].bienso.Substring(0, 2) == "79")
                {
                    ds[i].Xuat();
                }

            }
        }
    }
}
