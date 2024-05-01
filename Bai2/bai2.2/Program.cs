using System;

namespace bai2._2
{
    //Lớp phân số
    public class PhanSo
    {
        //Các trường
        public int _tuso;
        public int _mauso;

        //Các thuộc tính
        public int TuSo
        {
            get { return _tuso; }
            set { _tuso = value; }
        }

        public int MauSo
        {
            get { return _mauso; }
            set
            {
                if (value == 0) Console.WriteLine("ERROR");
                else _mauso = value;
            }
        }

        //Thiết lập phân số
        public PhanSo(int ts, int ms)
        {
            _tuso = ts;
            _mauso = ms;
        }

        public PhanSo(int tuso, int mauso, int tuSo, int mauSo) : this(tuso, mauso)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public double GiaTri()
        {
            return (double)_tuso / _mauso;
        }
    }
    //Lớp DS Phân số
    public class DSPhanSo
    {
        //Các trường 
        private PhanSo[] _dsPS;
        private int _size;

        //Thuộc tính
        public DSPhanSo(int size)
        {
            _size = size;
            _dsPS = new PhanSo[size];
        }
        //Thiết lập danh sách
        public PhanSo this[int i]
        {
            get { return _dsPS[i]; }
            set { _dsPS[i] = value; }
        }

        public void Nhap()
        {
            for (int i = 0; i < this._size; i++)
            {
                Console.WriteLine("Phan So {0}", i + 1);
                Console.WriteLine("Tu So: ");
                int TS = int.Parse(Console.ReadLine());
                Console.WriteLine("Mau So: ");
                int MS = int.Parse(Console.ReadLine());

                _dsPS[i] = new PhanSo(TS, MS);
            }
        }
        public void In()
        {
            for (int i = 0; i < this._size; i++)
            {
                Console.WriteLine("{0}/{1}", _dsPS[i]._tuso, _dsPS[i]._mauso);
            }
        }

        public void PSmax()
        {
            double MAX = 0;
            int vt_max = 0;
            for (int i = 0; i < this._size; i++)
            {
                if (_dsPS[i].GiaTri() > MAX)
                {
                    MAX = _dsPS[i].GiaTri();
                    vt_max = i;
                }

            }
            Console.WriteLine("Phan so lon nhat: {0}/{1}", _dsPS[vt_max]._tuso, _dsPS[vt_max]._mauso);
        }

        public void SapXep()
        {
            PhanSo tam;
            for (int i = 0; i < this._size - 1; i++)
            {
                for (int j = i + 1; j < this._size; j++)
                {
                    if (_dsPS[j].GiaTri() < _dsPS[i].GiaTri())
                    {
                        tam = _dsPS[j];
                        _dsPS[j] = _dsPS[i];
                        _dsPS[i] = tam;
                    }
                }
            }
            Console.WriteLine("Danh sach tang dan: ");
            In();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; //Kích thước
            DSPhanSo dsps; // tên mảng 

            Console.WriteLine("Nhap so luong phan so: ");
            n = int.Parse(Console.ReadLine());
            dsps = new DSPhanSo(n);

            dsps.Nhap();

            Console.WriteLine("Danh sach phan so: ");
            dsps.In();

            dsps.PSmax();

            dsps.SapXep();
        }
    }
}
