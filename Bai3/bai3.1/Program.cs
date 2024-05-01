using System;

namespace bai3._1
{
    public class Xe
    {
        public string _BienSo;
        public int _Nam;
        public double _Gia;

        public Xe(string bien, int nam, double gia)
        {
            _BienSo = bien;
            _Nam = nam;
            _Gia = gia;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            _BienSo = Console.ReadLine();
            Console.Write("Nam san xuat: ");
            _Nam = int.Parse(Console.ReadLine());
            Console.Write("Gia: ");
            _Gia = double.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Bien so: {0}", _BienSo);
            Console.WriteLine("Nam SX: {0}", _Nam);
            Console.WriteLine("Gia: {0} Trieu", _Gia);
        }
    }
    public class XeCon : Xe
    {
        public int SoChoNgoi;
        public string LoaiXe;
        //Pương thức thiết lập có tham số
        public XeCon(string bien, int nam, double gia, int Socho, string Lxe) : base(bien, nam, gia)
        {
            SoChoNgoi = Socho;
            Lxe = LoaiXe;
        }
        //Phương thức thiết lập không tham số
        public XeCon() : base("", 0, 0)
        {
            SoChoNgoi = 0;
            LoaiXe = "";
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Loai xe: ");
            LoaiXe = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi: {0}", SoChoNgoi);
            Console.WriteLine("Loai xe: {0}", LoaiXe);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong xe: ");
            n = int.Parse(Console.ReadLine());

            XeCon[] mxe = new XeCon[100];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Xe {0}", i + 1);
                mxe[i] = new XeCon();
                mxe[i].Nhap();
            }
            //Tìm xe có giá cao nhất, thấp nhất
            double Gia_Max = 0;
            double Gia_Min = double.MaxValue;
            int xemax = 0;
            int xemin = 0;
            for (int i = 0; i < n; i++)
            {
                if (mxe[i]._Gia > Gia_Max)
                {
                    Gia_Max = mxe[i]._Gia;
                    xemax = i;
                }
                if (mxe[i]._Gia < Gia_Min)
                {
                    Gia_Min = mxe[i]._Gia;
                    xemin = i;
                }
            }
            Console.WriteLine("\nThong tin xe co gia cao nhat: ");
            mxe[xemax].Xuat();
            Console.WriteLine("\nThong tin xe co gia thap nhat: ");
            mxe[xemin].Xuat();

            //Danh sach xe co bien so bang so nhap vao
            Console.Write("\nNhap bien so cua tinh: ");
            string bst = Console.ReadLine();
            Console.WriteLine("\nNhap bien so cua tinh: ");
            for (int i = 0; i < n; i++)
            {
                if (mxe[i]._BienSo.Substring(0, 2) == bst)
                {
                    mxe[i].Xuat();
                    Console.WriteLine();
                }
            }
            //Sắp xếp danh sách xe theo thứ tự tăng dần của năm sản xuất
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mxe[i]._Nam > mxe[j]._Nam)
                    {
                        XeCon tam = mxe[i];
                        mxe[i] = mxe[j];
                        mxe[j] = tam;
                    }
                }
            }
            Console.WriteLine("\nDanh sach sap xep theo so nam tang dan: ");
            for (int i = 0; i < n; i++)
            {
                mxe[i].Xuat();
                Console.WriteLine();
            }
        }
    }
}