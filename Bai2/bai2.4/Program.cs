using System;

namespace bai2._4
{
    public class Point
    {
        public double _x, _y;
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
    public class Circle
    {
        //Thuộc tính;
        public double r; //Bán kính
        public Point c; //Tâm hình tròn

        //Hàm thiết lập khởi tạo hình tròn.
        public Circle(double R, Point C)
        {
            r = R;
            c = C;
        }

        //Hàm Area() tính diện tích hình tròn.
        public double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        //Hàm Move(double dx, double xy) di chuyển hình tròn với khoảng cách tương ứng dx, dy.
        public void Move(double dx, double dy)
        {
            c._x += dx;
            c._y += dy;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tam tron: ");
            Console.Write("x = ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double Y = double.Parse(Console.ReadLine());

            Point c = new Point(X, Y); //Tạo tọa độ tâm tròn 
            Console.Write("Ban kinh: ");
            double r = double.Parse(Console.ReadLine()); 

            Circle Tron = new Circle(r, c); //Tạo đường tròn

            Console.WriteLine("Dien tich Dtr ban kinh {0} la {2:0.00}",Tron.r, Tron.Area());

            Tron.Move(2, 3); //Di chuyển tới vị tri (2,3)

            Console.WriteLine("Tam duong tron sau khi dich chuyen toi (2,3): ({0},{1})", Tron.c._x, Tron.c._y);
        }
    }
}
