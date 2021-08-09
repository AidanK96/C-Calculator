using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /**
     * The purpose of this class is to display the text to the console, take in the user input, class the arithmetic fucntion and then display the output.
     * Error handling is currently only in the subtraction function at this time.
     **/
    class ConsoleText
    {
        public static void menuText()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~||Calculator||~~~~~~~~~~~~~~~~");
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for division");
            Console.WriteLine("Press 4 for multiplication");
            Console.WriteLine("Press 5 to exit");
            Console.WriteLine("Please enter your choice:");
            
        }
        public static void addText()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Addition has been selected");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Arithmetic.Addition(x, y);
        }
        public static void subText()
        {
            int x;
            int y;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Subtraction has been selected");
            Console.WriteLine("Enter first number");
            //Make below error handling into own function
            String input1 = Console.ReadLine();
            bool sucess = int.TryParse(input1, out x);
            if (sucess)
            {
                Console.WriteLine("Entered number 1 = " + x);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.ReadKey();
                subText();
            }

            Console.WriteLine("Enter second number");
            String input2 = Console.ReadLine();
            bool sucess2 = int.TryParse(input2, out y);
            if (sucess2)
            {
                Console.WriteLine("Number 2 = " + y);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.Read();
                subText();
            }
            Arithmetic.Subtraction(x, y);
        }
        public static void divText()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Division has been selected");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Arithmetic.Division(x, y);
        }
        public static void multiText()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Multiplication has been selected");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Arithmetic.Multiplication(x, y);
        }
    }
}
