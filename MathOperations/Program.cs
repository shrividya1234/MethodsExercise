using System;

namespace MathOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Multiply(2, 10));
            Console.WriteLine(Divide(100, 5));
            Console.WriteLine(Subtract(20, 5));
        }
  static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}