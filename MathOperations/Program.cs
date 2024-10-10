using System;

namespace MathOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Add(1, 2));
            int added = Add(1, 2);
            Console.WriteLine(added);
            
           //Console.WriteLine(Subtract(20, 5));
            int subtract = Subtract(20, 5);
            Console.WriteLine(subtract);
            
            //Console.WriteLine(Multiply(20, 5));
            int multiply = Multiply(20, 5);
            Console.WriteLine(multiply);
            
            //Console.WriteLine(Divide(100, 5));
            int divide = Divide(100, 5);
            Console.WriteLine(divide);
            
            Console.WriteLine($"Add:{added} || Subtract : {subtract} || Multiply : {multiply} || Divide : {divide}" );
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