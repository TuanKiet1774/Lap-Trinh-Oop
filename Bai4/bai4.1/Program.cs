using System;

namespace bai4._1
{
    public class stack
    {
        public int Max = 1000;
        public int Top;
        public int[] Data;

        public stack(int max)
        {
            Max = max;
            Data = new int[Max];
            Top = -1;
        }

        public void Push(int data)
        {
            if (Top == Max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            Data[++Top] = data;
        }

        public int Pop()
        {
            if (Top < 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return Data[Top--];
        }

        public virtual void Print()
        {

        }
    }

    public class Prime_stack : stack
    {
        public Prime_stack(int max) : base(max) { }

        public bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public override void Print()
        {
            while (Top != -1)
            {
                Console.Write(Pop());
                if (Top != -1)
                    Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }

    public class Hexa_stack:stack
    {
        public Hexa_stack(int max) : base(max) { }

        public override void Print()
        {
            string Digits = "0123456789ABCDEF";
            for (int i = Top; i >= 0; i--)
                Console.Write(Digits[Data[i]]);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        public static stack PhanTich(int n)
        {
            stack Stack = new Prime_stack(1000);
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Stack.Push(i);
                    n = n / i;
                }
            }
            return Stack;
        }

        public static stack ThapLuc(int n)
        {
            stack Stack = new Hexa_stack(1000);
            while (n > 0)
            {
                int Du = n % 16;
                Stack.Push(Du);
                n = n / 16;
            }
            return Stack;
        }
       
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 2);
            int tam = n;

            var Pt_SNT = PhanTich(n);
            Console.Write("{0} = ", tam);
            Pt_SNT.Print();

            int tam1 = tam;
            var ThLuc = ThapLuc(tam);
            Console.Write("Gia tri he thap luc: {0} = ", tam1);
            ThLuc.Print();
        }
    }
}
