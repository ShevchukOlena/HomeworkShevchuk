using System;

namespace ConsoleAppHW1
{
    class Program
    {
        static double Task1(int a, int b)
        {
                 return = (5 * a + b * b) / (b - a);
        }

        static void Task2( ref string a, ref string b,  ref string tmp)
        {
            return = (tmp = a, a = b , b = tmp);
        }

        static (double division, double reminder) Task3(double a, double b,)
        {
            return = (a / b, a % b);
        }

        static double Task4(double a, double b, double c)
        {
                return = (c - b) / a;
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

        static (double valueA, double valueB) Task5(double X1, double X2, double Y2)
        {
            return = ((Y1 - Y2) / (X1 - X2), Y2 - (A * X2);
        }
        static void Main(string[] args)
        {
           
        }
    }
}
