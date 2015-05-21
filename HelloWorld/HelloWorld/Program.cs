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
            // The full command.
            System.Console.WriteLine(System.Environment.CommandLine);

            // Input
            System.Console.Write("Please input something: ");
            String inputStr = System.Console.ReadLine();
            System.Console.WriteLine("The input string is {0}", inputStr);
        }

        static int Main(string[] args)
        {
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
