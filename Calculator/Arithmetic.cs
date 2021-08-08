using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Arithmetic
    {
        public static void Addition()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Addition has been selected");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            int sum = (x + y);
            Console.WriteLine("Sum of numbers - " + sum);

        }
        //public static void Subtraction();




    }
}
