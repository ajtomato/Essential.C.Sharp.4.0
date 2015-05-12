﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            System.Console.WriteLine("Hello world");

            // Only the command line arguments are included.
            foreach (string arg in args)
            {
                System.Console.WriteLine(arg);
            }

            // The full command.
            System.Console.WriteLine(System.Environment.CommandLine);

            return 0;
        }
    }
}
