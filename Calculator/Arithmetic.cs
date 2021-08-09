using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Arithmetic
    {

        public bool sucess = true;
        public static void Addition(int x, int y)
        {
            int sum = (x + y);
            Console.WriteLine("Sum of numbers - " + sum);
        }
        public static void Subtraction(int x, int y)
        {
            int sum = (x - y);
            Console.WriteLine("Sum of numbers - " + sum);
        }
        public static void Division(int x, int y)
        {
            int sum = (x / y);
            Console.WriteLine("Sum of numbers - " + sum);          
        }
        public static void Multiplication(int x, int y)
        {
            int sum = (x * y);
            Console.WriteLine("Sum of numbers - " + sum);
        }
    }
}
