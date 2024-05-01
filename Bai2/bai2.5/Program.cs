using System;

namespace bai2._5
{
    public class Stack
    {
        private int top;
        private int Max;
        private int[] stack;

        public Stack(int max)
        {
            Max = max;
            stack = new int[Max];
            top = -1;
        }

        public void Push(int data)
        {
            if (top == Max - 1)
            {
                Console.WriteLine("Stack Tran");
                return;
            }
            stack[++top] = data;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Tran");
                return -1;
            }
            return stack[top--];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack PtSo = new Stack(1000);
            int n;
            Console.Write("Nhap so: ");
            n = int.Parse(Console.ReadLine());
            int tam = n;
            //Phân tích số thành tích các số nguyên tố
            while (n > 1)
            {
                int i = 2;
                while (n % i != 0) i++;
                PtSo.Push(i);
                n = n / i;
            }

            Console.Write("Output: {0} = ",tam);
            while (!PtSo.IsEmpty())
            {
                Console.Write(PtSo.Pop());
                if (!PtSo.IsEmpty())
                    Console.Write(" * ");
            }
            Console.WriteLine();
            //Phân tích só sang nhị phân/Thập phân
            Console.Write("Doi sang he: ");
            int h = int.Parse(Console.ReadLine());
            
            if(tam == 0) PtSo.Push(tam);
            else
            {
                while (tam > 0)
                {
                    PtSo.Push(tam%h);
                    tam = tam / h;
                }
            }
            Console.Write("Output: ");
            while (!PtSo.IsEmpty())
            {
                Console.Write(PtSo.Pop());
            }
            Console.WriteLine();
        }
    }
}
