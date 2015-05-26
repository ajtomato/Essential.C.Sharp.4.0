using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void ConsoleInputOutput()
        {
            // Input a line.
            System.Console.Write("Please input something: ");
            String inputStr = System.Console.ReadLine();
            System.Console.WriteLine("The input string is {0}", inputStr);

            // Input a character. System.Console.Read() is NOT preferable.
            System.Console.Write("Please input something again: ");
            System.ConsoleKeyInfo inputKey = System.Console.ReadKey();
            System.Console.WriteLine(inputKey.Key.ToString());
        }

        static int Main(string[] args)
        {
            // The full command.
            System.Console.WriteLine(System.Environment.CommandLine);

            // Only the command line arguments are included.
            foreach (string arg in args)
            {
                System.Console.WriteLine(arg);
            }

            ConsoleInputOutput();

            return 0;
        }
    }
}
