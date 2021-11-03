using System;

namespace ConsoleAppHW1
{
    class Program
    {
        static void Task1()
        {
             Console.WriteLine("Enter first number");
                int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second number");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = (5 * a + b * b) / (b - a);
             Console.WriteLine($"Result {c}");
             Console.WriteLine($"Result {c} = (5 * {a} + {b} ^ 2 / {b} - {a})");
        }

        static void Task2()
        {
            Console.WriteLine("Enter first number");
               int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
               int b = Convert.ToInt32(Console.ReadLine());
               int tmp = a;
            Console.WriteLine($"Result { a = b } and { b = tmp }");
        }

        static void Task3()
        {
            Console.WriteLine("Enter first number");
               string inputA = Console.ReadLine();
            Console.WriteLine("Enter second number");
               string inputB = Console.ReadLine();
               double a = Convert.ToDouble(inputA);
               double b = Convert.ToDouble(inputB);
               double c = a / b;
               double d = a % b;
            Console.WriteLine($"Result {c} modulo {d}");
        }

        static void Task4()
        {
            Console.WriteLine("Enter first number");
                string inputA = Console.ReadLine();
            Console.WriteLine("Enter second number");
                string inputB = Console.ReadLine();
            Console.WriteLine("Enter third number");
                string inputC = Console.ReadLine();
                double a = Convert.ToDouble(inputA);
                double b = Convert.ToDouble(inputB);
                double c = Convert.ToDouble(inputC);
                double x = (c - b) / a;
            if (a != 0 && b != 0 && c != 0)
         {
             Console.WriteLine($"Result:{x}");
             Console.WriteLine($"Result:{x} = ( {c} - {b} ) / {a}");
         }
            else
         {
             Console.WriteLine($"enter a number not equal to zero");
         }
        }

        static void Task5()
        {
            Console.WriteLine("Enter first coordinate X");
                string inputX1 = Console.ReadLine();
            Console.WriteLine("Enter second coordinate Y");
                string inputY1 = Console.ReadLine();
            Console.WriteLine("Enter first coordinate X");
                string inputX2 = Console.ReadLine();
            Console.WriteLine("Enter second coordinate Y");
                string inputY2 = Console.ReadLine();
                double X1 = Convert.ToDouble(inputX1);
                double Y1 = Convert.ToDouble(inputY1);
                double X2 = Convert.ToDouble(inputX2);
                double Y2 = Convert.ToDouble(inputY2);
                double A = (Y1 - Y2) / (X1 - X2);
                double B = Y2 - (A * X2);
            Console.WriteLine($"Result: y = {A} x + {B}");
        }
        static void Main(string[] args)
        {
           
        }
    }
}
