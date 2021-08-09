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
            Console.WriteLine("~~~~~~~~~~~~~~~~||Calculator||~~~~~~~~~~~~~~~~\nPress 1 for addition\nPress 2 for subtraction\nPress 3 for division" +
                "\nPress 4 for multiplication\nPress 5 to exit\nPlease enter your choice:");
        }
        public static void addText()
        {
            int x;
            int y;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nAddition has been selected\nEnter first number ");
            String input1 = Console.ReadLine();
            bool sucess = int.TryParse(input1, out x);
            if
            (sucess)
            {
                Console.WriteLine("First number = " + x);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.ReadKey();
                addText();
            }

            Console.WriteLine("Enter second number");
            String input2 = Console.ReadLine();
            bool sucess2 = int.TryParse(input2, out y);
            if (sucess2)
            {
                Console.WriteLine("Second number = " + y);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.Read();
                addText();
            }
            Arithmetic.Addition(x, y);
        }
        public static void subText()
        {
            int x;
            int y;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nSubtraction has been selected\nEnter first number");
            //Make below error handling into own function
            String input1 = Console.ReadLine();
            bool sucess = int.TryParse(input1, out x);
            if (sucess)
            {
                Console.WriteLine("First number = " + x);
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
                Console.WriteLine("Second number = " + y);
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
            int x;
            int y;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nDivision has been selected\nEnter first number");
            String input1 = Console.ReadLine();
            bool sucess = int.TryParse(input1, out x);
            if (sucess)
            {
                Console.WriteLine("First number = " + x);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.ReadKey();
                divText();
            }

            Console.WriteLine("Enter second number");
            String input2 = Console.ReadLine();
            bool sucess2 = int.TryParse(input2, out y);
            if (sucess2)
            {
                Console.WriteLine("Second number = " + y);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.Read();
                divText();
            }
            Arithmetic.Division(x, y);
        }
        public static void multiText()
        {
            int x;
            int y;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nMultiplication has been selected\nEnter first number");
            String input1 = Console.ReadLine();
            bool sucess = int.TryParse(input1, out x);
            if (sucess)
            {
                Console.WriteLine("First number = " + x);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.ReadKey();
                multiText();
            }

            Console.WriteLine("Enter second number");
            String input2 = Console.ReadLine();
            bool sucess2 = int.TryParse(input2, out y);
            if (sucess2)
            {
                Console.WriteLine("Second number = " + y);
            }
            else
            {
                Console.WriteLine("Incorrect integer format, keypress to return to start");
                Console.Read();
                multiText();
            }
        }
    }
}
