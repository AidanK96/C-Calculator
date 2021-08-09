using System;

namespace Calculator
{
    class Controller
    {
        public static void Main(string[] args)

        {
            ConsoleText.menuText();
            int menuInput = int.Parse(Console.ReadLine());

            //Checks for user input, choses function based off input
            if (menuInput == 1)
            {
                ConsoleText.addText();
            }

            if (menuInput == 2)
            {
                ConsoleText.subText();
            }

            if (menuInput == 3)
            {
                ConsoleText.divText();
            }

            if (menuInput == 4)
            {
                ConsoleText.multiText();
            }

            if (menuInput == 5)
            {
                Environment.Exit(0);
            }
            
        }
    }
}
