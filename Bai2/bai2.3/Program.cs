using System;

namespace bai2._3
{
    public class Point
    {
        public double _x, _y;
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void In(Point[] MangP, out int n)
        {

            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("P[{0}]", i + 1);
                Console.Write("x = ");
                double X = double.Parse(Console.ReadLine());
                Console.Write("y = ");
                double Y = double.Parse(Console.ReadLine());

                MangP[i] = new Point(X, Y);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("({0},{1})", MangP[i]._x, MangP[i]._y);
            }
        }
        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public double KhoangCach(Point p)
        {
            double kc = Math.Sqrt(Math.Pow((_x - p._x), 2) + Math.Pow((_y - p._y), 2));
            return kc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo một danh sách đối tượng điểm.
            int n;
            Point[] MangP = new Point[1000];
            Point P = new Point(0,0);

            //In ra tọa độ của các điểm
            Console.WriteLine("Danh sach diem: ");
            P.In(MangP,out n);

            //Tìm điểm cách xa gốc tọa độ nhất.
            double KcMax = 0;
            int VtMax = 0;
            Point GTD = new Point(0, 0); // Gốc tọa độ
            for(int i = 0; i<n; i++)
            {
                if (GTD.KhoangCach(MangP[i]) > KcMax)
                {
                    KcMax = GTD.KhoangCach(MangP[i]);
                    VtMax = i;
                } 
            }
            Console.WriteLine("Diem xa goc toa do nhat: ({0},{1})", MangP[VtMax]._x, MangP[VtMax]._y);

            //Tìm cặp điểm gần nhau nhất.
            double KcMin = double.MaxValue;
            int Vt1 = 0, Vt2 = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (MangP[j].KhoangCach(MangP[i]) < KcMin)
                    {
                        KcMin = MangP[j].KhoangCach(MangP[i]);
                        Vt1 = i;
                        Vt2 = j;
                    }    
                }    
            }
            Console.WriteLine("Cap diem gan nhau nhat: ({0},{1}) và ({2},{3})", MangP[Vt1]._x, MangP[Vt1]._y, MangP[Vt2]._x, MangP[Vt2]._y);
        }
    }
}
