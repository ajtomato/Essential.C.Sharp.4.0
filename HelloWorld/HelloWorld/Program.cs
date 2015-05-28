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

        static void TestFundamentalTypes()
        {
            System.Console.WriteLine("[sbyte]: min - {0}, max - {1}",
                                     System.SByte.MinValue, System.SByte.MaxValue);
            System.Console.WriteLine("[byte]: min - {0}, max - {1}",
                                     System.Byte.MinValue, System.Byte.MaxValue);
            System.Console.WriteLine("[short]: min - {0}, max - {1}",
                                     System.Int16.MinValue, System.Int16.MaxValue);
            System.Console.WriteLine("[ushort]: min - {0}, max - {1}",
                                     System.UInt16.MinValue, System.UInt16.MaxValue);
            System.Console.WriteLine("[int]: min - {0}, max - {1}",
                                     System.Int32.MinValue, System.Int32.MaxValue);
            System.Console.WriteLine("[uint]: min - {0}, max - {1}",
                                     System.UInt32.MinValue, System.UInt32.MaxValue);
            System.Console.WriteLine("[long]: min - {0}, max - {1}",
                                     System.Int64.MinValue, System.Int64.MaxValue);
            System.Console.WriteLine("[ulong]: min - {0}, max - {1}",
                                     System.UInt64.MinValue, System.UInt64.MaxValue);
            System.Console.WriteLine("[float]: min - {0}, max - {1}",
                                     System.Single.MinValue, System.Single.MaxValue);
            System.Console.WriteLine("[double]: min - {0}, max - {1}",
                                     System.Double.MinValue, System.Double.MaxValue);
            System.Console.WriteLine("[decimal]: min - {0}, max - {1}",
                                     System.Decimal.MinValue, System.Decimal.MaxValue);
            System.Console.WriteLine("Decimal is more accurate than float/double, "
                                     + "but the range is smaller.");
            System.Console.WriteLine("Decimal literal is as follows: {0}. "
                                     + "M means that it is often used in monetary calculations.",
                                     1.99M);
            System.Console.WriteLine("Print a number in HEX format: 0x{0:X}, 0x{0:x}", 15);
            System.Console.WriteLine("Print a float in round-trip format: {0:R}", 1.99999999999999);
            System.Console.WriteLine("[bool]: {0}, {1}", true, false);
            System.Console.WriteLine("[char]: min - {0}, max - {1}", (int)System.Char.MinValue, (int)System.Char.MaxValue);
            System.Console.WriteLine("char corresponds to the Unicode character set.");
            System.Console.WriteLine(@"The @ symbol in front of the string means a verbatim string literal.\n");
            System.Console.Write("A cross platform new line" + System.Environment.NewLine);
        }

        static void TestNullableModifier()
        {
            int? i = null;
            if (i == null)
            {
                System.Console.WriteLine("? can be used after the value type as a nullable modifier, e.g., int?");
            }
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

            TestNullableModifier();

            return 0;
        }
    }
}
