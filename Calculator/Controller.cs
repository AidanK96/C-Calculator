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
            
            //to be added to Arithmetic.cs
            if (menuInput == 1)
            {
                Arithmetic.Addition();
            
            }
            if (menuInput == 2)
            {
                Console.Clear();
                Console.WriteLine("Subtraction has been selected");

            }
            if (menuInput == 3)
            {
                Console.Clear();
                Console.WriteLine("Division has been selected");

            }
            if (menuInput == 4)
            {
                Console.Clear();
                Console.WriteLine("Multiplication has been selected");

            }
            if (menuInput == 5)
            {
                Environment.Exit(0);
            }

        }
    

    }
}
