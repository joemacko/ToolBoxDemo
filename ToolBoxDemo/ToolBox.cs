using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class ToolBox
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit \"Y\" then ENTER to continue, or hit \"N\" then ENTER to Clear the Console and Continue.");

            string userResponse = Console.ReadLine();
            if (userResponse == "Y")
            {
                KeyToContinue();
            }
            else if (userResponse == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }

            Console.ReadLine();



            //Functions below this line
            void KeyToContinue()
            {
            Console.WriteLine("Hit ENTER to continue on with the code...");
            Console.ReadLine();
            }

            void ClearConsole()
            {
            Console.Clear();
            }
            
            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
            }
        }
    }
}
        //The Main method acts as our program's .exe file, aka "executable" or entry point.
        //This is the file we double click on to start any program.

            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class

            //Console.WriteLine("Congratulations! You've cleared the console!...hit ENTER to close the program");