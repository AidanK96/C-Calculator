using System;

namespace Calculator
{
    class Controller
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("~~~~~~~~~~~~~~~~||Calculator||~~~~~~~~~~~~~~~~");
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for division");
            Console.WriteLine("Press 4 for multiplication");
            Console.WriteLine("Press 5 to exit");
            Console.WriteLine("Please enter your choice:");
            int menuInput = int.Parse(Console.ReadLine());
            
            //Checks for user input, choses function based off input
            if (menuInput == 1)
            {
                Arithmetic.Addition();
            
            }
            if (menuInput == 2)
            {
                Arithmetic.Subtraction();

            }
            if (menuInput == 3)
            {

                Arithmetic.Division();

            }
            if (menuInput == 4)
            {
                Arithmetic.Multiplication();

            }
            if (menuInput == 5)
            {
                Environment.Exit(0);
            }

        }
    }
}
