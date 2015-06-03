// #define TEST_SYMBOL 1   Macro is NOT supported.

#define TEST_SYMBOL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWrite = System.Console;

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

        static void TestCastException()
        {
            try
            {
                long l = System.Int64.MaxValue;
                int i = (int)l;
                System.Console.WriteLine("Cast: " + l + " => " + i);
                System.Console.WriteLine("There is no exception for cast error without checked block.");

                checked
                {
                    i = (int)l;
                    System.Console.WriteLine("There is no exception for cast error with checked block.");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("A cast exception is caught: " + e);
            }
        }

        static void TestParse()
        {
            try
            {
                int j = 0;
                if (int.TryParse("100", out j))
                {
                    System.Console.WriteLine("TryParse is successful.");
                }
                else
                {
                    System.Console.WriteLine("TryParse is failed.");
                }
                if (int.TryParse("abc", out j))
                {
                    System.Console.WriteLine("TryParse is successful.");
                }
                else
                {
                    System.Console.WriteLine("TryParse is failed.");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Parse error exception is caught.");
            }

            try
            {
                int i = int.Parse("100");
                float f = float.Parse("0.99");
                System.Console.WriteLine("fundamentalType.Parse(string): " + i + ", " + f);

                int j = int.Parse("abc");
                System.Console.WriteLine("No exception for parse error");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Parse error exception is caught.");
            }
        }

        class ArrayItem
        {
            public ArrayItem()
            {
                System.Console.WriteLine("ArrayItem Construction");
            }
        }

        static void TestArray()
        {
            string[] array1 = new string[] { "Hello", "World" };
            string[] array2 = new string[3];

            foreach (string s in array2)
            {
                if (s == null)
                {
                    System.Console.WriteLine("new string[cnt] does NOT create the real string.");
                    break;
                }
            }

            ArrayItem[] array3 = new ArrayItem[4];
            foreach (ArrayItem arrayItem in array3)
            {
                if (arrayItem == null)
                {
                    System.Console.WriteLine("new ArrayItem[cnt] does NOT create the real string.");
                    break;
                }
            }

            int[,] array4 = new int[3, 3];
            System.Console.WriteLine("DataType[,] means the size of subarray is fixed.");

            int[][] array5; // jagged array
            array5 = new int[3][];
            for (int i = 0; i < 3; ++ i)
            {
                array5[i] = new int[i + 1];
            }
            System.Console.WriteLine("DataType[][] means the size of subarray is flexible.");

            // String => char array
            string s1 = "hello world";
            char[] array6 = s1.ToCharArray();
            System.Array.Reverse(array6);
            s1 = new string(array6);
            System.Console.WriteLine("A method to reverse a string: string => char array => reverse => string: " + s1);
        }

        static void TestAssert()
        {
            System.Diagnostics.Trace.Assert(false);
        }

        static void TestNullCoalescingOperator()
        {
            string s1 = null;
            System.Console.WriteLine(s1 ?? "s1 is null.");
        }

        static void TestForeach()
        {
            int[] array = { 0, 1 };

            foreach (int i in array)
            {
                // i += 5;
                System.Console.WriteLine("The compiler prevents the modification of iteration variable.");
                break;
            }
        }

        static void TestSwitch()
        {
            string[] strArray = { "a", "b", "q", "c" };

            foreach (string s in strArray)
            {
                switch (s)
                {
                    case "a":
                    case "b":
                        // The statement cannot be inserted here without break/continue.
                    case "c":
                        System.Console.WriteLine("Hit: " + s);
                        break;
                    default:
                        System.Console.WriteLine("Not hit");
                        continue;
                }
            }
        }

#if TEST_SYMBOL // #if 1 is NOT supported. It must be #if SYMBOL
#endif

        static void TestUsing()
        {
            Console.WriteLine("using introduces namespace level by level");
            MyWrite.WriteLine("using alias = namespace");
            MyWrite.WriteLine("using alias is used to disambiguate two types that have the same name"
                    + " and to abbreviate a long name.");
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

            TestUsing();

            return 0;
        }
    }
}
