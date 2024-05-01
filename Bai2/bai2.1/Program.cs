using System;

namespace bai2._1
{
    public class PhanSo
    {
        // Cac truong
        private int _tuSo;
        private int _mauSo;

        // thuoc tinh
        public int TuSo
        {
            get { return _tuSo; }
            set { _tuSo = value; }
        }
        public int MauSo
        {
            get { return _mauSo; }
            set
            {
                if (value == 0) Console.WriteLine("Mau so khong the bang 0");
                else _mauSo = value;
            }
        }

        //Thiet lap phan so
        public PhanSo(int ts, int ms)
        {
            _tuSo = ts;
            MauSo = ms; // Thuoc tinh
        }

        //Thiet lap sao chep
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }

        // Nhap phan so
        public static PhanSo Nhap()
        {
            Console.Write("Tu so: ");
            int tuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            int mauSo = int.Parse(Console.ReadLine());

            return new PhanSo(tuSo, mauSo);
        }

        //Xuat phan so
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
        }

        //Toi gian phan so
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void ToiGian()
        {
            int tg = UCLN(_tuSo, _mauSo);
            _tuSo /= tg;
            _mauSo /= tg;
        }

        //Cong phan so
        public PhanSo Cong(PhanSo ps)
        {
            int t = _tuSo * ps._mauSo + ps._tuSo * _mauSo;
            int m = _mauSo * ps._mauSo;
            return new PhanSo(t, m);
        }
        //Tru phan so
        public PhanSo Tru(PhanSo ps)
        {
            int t = _tuSo * ps._mauSo - ps._tuSo * _mauSo;
            int m = _mauSo * ps._mauSo;
            return new PhanSo(t, m);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {       
            PhanSo ps1, ps2;
            
            Console.WriteLine("Nhap phan so 1:");
            ps1 = PhanSo.Nhap();

            Console.WriteLine("Nhap phan so 2:");
            ps2 = PhanSo.Nhap();

            Console.WriteLine("\nCac phan so vua nhap:");
            ps1.Xuat();
            ps2.Xuat();
                        
            PhanSo tong = ps1.Cong(ps2);
            PhanSo hieu = ps1.Tru(ps2);

            tong.ToiGian();
            Console.Write("\nTong hai phan so:");
            tong.Xuat();
            
            hieu.ToiGian();
            Console.Write("Hieu hai phan so:");
            hieu.Xuat();
        }
    }
}
