using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using static System.Collections.Specialized.BitVector32;

namespace BasicConstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MODULE 4.1. Selection statements (conditional statements).");
            Console.WriteLine("\nComparing fruits:");
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;
            var result = (myapples != hispeares) & (myapples < hisapples);
            Console.WriteLine("\t" + result);

            Console.WriteLine("\nFinding out if it's winter or not:");
            int currentDayInYear = 293;
            bool isLeapYear = false;
            bool isWinter = 
                (!isLeapYear && (currentDayInYear >= 335 || currentDayInYear <= 59)) // The outer brackets can be removed
                ||
                (isLeapYear && (currentDayInYear >= 336 || currentDayInYear <= 60)); // The outer brackets can be removed
            Console.WriteLine("\tIs it winter? - {0}.", isWinter);

            Console.WriteLine("\nTask 4.1.4. Comparing variables of string type.");
            string A1 = "";
            string B1 = "";
            bool C1 = (A1 != B1); // The outer brackets can be removed
            Console.WriteLine("\tIsn't A equal to B? - {0}.", C1);

            Console.WriteLine("\nTask 4.1.5. Comparing variables of numeric types.");
            int A2 = 1, B2 = 2;
            double X2 = 3, Y2 = 4;
            bool C2 = (A2 < B2) || (X2 > Y2);
            Console.WriteLine("\tIs the condition met? - {0}.", C2);

            Console.WriteLine("\nComparing & and && :");
            var a = 5 + 6;
            var b = 7 + 8;
            var c = (b != a) & (b > a + 1);
            var d = (b != a) && (b > a + 1);
            var e = (b == a) & (b > a + 1);
            var f = (b == a) && (b > a + 1);
            Console.WriteLine("\t" + c);
            Console.WriteLine("\t" + d);
            Console.WriteLine("\t" + e);
            Console.WriteLine("\t" + f);

            Console.WriteLine("\nTesting XOR :");
            var a1 = 6;
            var b1 = 7;
            var c1 = (a1 > b1) ^ (a1 != b1);
            Console.WriteLine("\tResult: " + c1);

            Console.WriteLine("\nTesting logical negation. Task 4.1.10:");
            var inv = true;
            var negationResult = !inv;
            Console.WriteLine("\tNegation result: " + negationResult);
            bool trueVar = true;
            bool invertedVar = !trueVar;
            bool lastVar = !invertedVar;

            Console.WriteLine("\nSelection statements (conditional statements): if-else. ");
            var a2 = 6;
            var b2 = 7;

            // 1st way:
            Console.WriteLine("\t\t1st way:");
            if (a2 == b2)
            {
                Console.WriteLine("\tThe condition is true.");
            }
            else
            {
                Console.WriteLine("\tThe condition is false.");
                
                if (b2 < 10) Console.WriteLine("\tThe value of the variable b2 is {0}.", b2); // If there is only one line of code after the condition, curly braces can be omitted.

                if (b2 < 10)
                { 
                    Console.WriteLine("\tThe value of the variable b2 is {0} and less than 10.", b2); 
                }
                else
                {
                    Console.WriteLine("\tThe value of the variable b2 is {0} and greater than 10.", b2);
                }
            }

            // 2nd way:
            Console.WriteLine("\t\t2nd way:");
            if (a2 == b2)
            {
                Console.WriteLine("\tThe condition is true.");
            }
            else if (b2 < 10)
            {
                Console.WriteLine("\tThe value of the variable b2 is {0} and less than 10.", b2);
            }
            else
            {
                Console.WriteLine("\tThe value of the variable b2 is {0} and greater than 10.", b2);
            }

            // 3rd way:
            Console.WriteLine("\t\t3rd way:");
            if (a2 == b2 && b2 > 1)
            {
                Console.WriteLine("\tThe condition is true.");
            }
            else if (b2 > 10 || b2 == 7)
            {
                Console.WriteLine("\tThe value of the variable b2 is {0}, greater than 10 or equal to 7.", b2);
            }
            else
            {
                Console.WriteLine("\tThe value of the variable b2 is {0}", b2);
            }

            Console.WriteLine("\nTernary operation (or ternary operator).");
            var a3 = 6;
            var b3 = 7;
            var c3 = a3 != b3 ? a3 + b3 : b3;
            Console.WriteLine("\tResult of ternary operation: " + c3);


            Console.WriteLine("\nTask 4.1.17. A program about colors to reinforce skills. [COMMENTED]");
            /*
            Console.Write("\tPlease write your favorite color with a small letter: ");
            var color = Console.ReadLine();
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red; //A property of the console background color that our data has.
                Console.ForegroundColor = ConsoleColor.Black; //A property of the font color.
                Console.WriteLine("\tOK, your color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\tOK, your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\tOK, your color is cyan!");
            }
            */

            Console.WriteLine("\nSelection statement (conditional statement): switch.");
            Console.WriteLine("\nTask 4.1.18. Color selection with switch. [COMMENTED]");
            /*
            Console.Write("\tPlease write your favorite color with a small letter: ");
            var color1 = Console.ReadLine();
            switch (color1)
                // We could have just written: switch (Console.ReadLine()), without using the variable color1.
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\tOK, your color is red!");
                    break;
                        // The 'break' operator is mandatory. Instead of it we can use 'goto case', 'return', 'throw'.
                        // return - jump statement; terminates execution of the function in which it appears and returns control and the function's result, if any, to the caller.
                        // goto case - to transfer control to a switch section with a constant case label.
                        // goto default; - to transfer control to the switch section with the default label.
                        // throw - throws an exception.
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor= ConsoleColor.Black;
                    Console.WriteLine("\tOK, your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\tOK, your color is cyan!");
                    break;
                default:
                    // The block 'default' can be omitted.
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tOK, your colors are yellow and red!");
                    break;
            }
            */
            
            Console.WriteLine("\n\nMODULE 4.2. Iteration statements (cycles).");
            Console.WriteLine("\nColor change cycle. [COMMENTED.]");
            /*
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("\tIteration {0}", i);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
            }
            */

            Console.WriteLine("\nCycle with double i:");
            for (double i = 0.0; i < 0.1; i += 0.01)
            {
                Console.WriteLine("\ti = " + i);
            }
            
            Console.WriteLine("\nCycle with long i:");
            for (long i = 0; i < 10; i++)
            {
                Console.WriteLine("\ti = " + i);
            }

            Console.WriteLine("\nCycle with an external variable j:");
            int j = 25;
            for (; j < 30; j++)
            {
                Console.WriteLine("\tj = " + j);
            }

            Console.WriteLine("\nCycle with counter change in the cycle body:");
            for (int i = 0; i < 5; )
            {
                Console.WriteLine("\ti = " + i);
                i++;
            }

            Console.WriteLine("\nCycle in reverse order:");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("\ti = " + i);
            }

            Console.WriteLine("\nInfinite cycle for: [COMMENTED]");
            /*
            for (int i = 1; ; i++)
            {
                Console.WriteLine("\tIteration " + i);
                Console.Write("\tWrite a word: ");
                string word = Console.ReadLine();
                Console.WriteLine("\tYour word: " + word);
            }
            */

            Console.WriteLine("\nInfinite cycle 'for' for changing colors: [COMMENTED]");
            /*
            for (; ;)
            {
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
            }
            */

            Console.WriteLine("\nInfinite cycle 'while' for changing colors: [COMMENTED]");
            /*
            while (true)
            {
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
            }
            */

            Console.WriteLine("\nInfinite cycle 'do...while' for changing colors: [COMMENTED]");
            /*
            do
            {
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
            }
            while (true);
            */


            Console.WriteLine("\nCycle 'while' with counter for changing colors: [COMMENTED]");
            /*
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("\tIteration " + k);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
                k++;
            }
            */

            Console.WriteLine("\nTask 4.2.11. Cycle 'do...while' with counter for changing colors: [COMMENTED]");
            /*
            int t = 1;
            do
            {
                Console.WriteLine("\tIteration " + t);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
                t++;
            }
            while (t < 4);
            */

            Console.WriteLine("\nTask 4.2.13. Difference between 'while' and 'do...while'. [COMMENTED]");
            /*
            Console.WriteLine("\tCycle 'while':");
            int k1 = 0;
            while (k1 < 0)
            {
                Console.WriteLine("\tIteration " + k1);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
                k1++;
            }
            Console.WriteLine("\tCycle 'do...while':");
            int t1 = 0;
            do
            {
                Console.WriteLine("\tIteration " + t1);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
                t1++;
            }
            while (t1 < 0);
            */

            Console.WriteLine("\nInfinite cycle 'while' with user-controlled stop: [COMMENTED]");
            /*
            int k2 = 0;
            while (true)
            {
                Console.WriteLine("\tIteration " + k2);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("\t\tCycle is stopped.");
                    break;
                }
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is yellow!");
                        break;
                }
                k2++;
            }
            */

            Console.WriteLine("\nInfinite cycle 'while' with user-controlled stop and the 'continue' operator: [COMMENTED]");
            /*
            int k3 = 0;
            while (true)
            {
                Console.WriteLine("\tIteration " + k3);
                Console.Write("\tPlease write your favorite color with a small letter: ");
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("\t\tCycle is stopped.");
                    break;
                }
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\tOK, your color is cyan!");
                        break;
                    default:
                        continue;
                }
                k3++;
            }
            */

            Console.WriteLine("\nThe task of summing positive numbers:");
            int sum = 0;
            while (true)
            {
                Console.Write("\tEnter the summand: ");
                var summand = Convert.ToInt32(Console.ReadLine());
                if (summand < 0)
                {
                    Console.WriteLine("\t\tEnter a positive number, or 0 to exit the program.");
                    continue;
                }
                else if (summand == 0) 
                {
                    Console.WriteLine("\t\tThe summation has been stopped.");
                    break;
                }
                sum += summand; // We sum only positive numbers.
            }
            Console.WriteLine("\tSum total: " + sum);
            



            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.ReadKey();

        }
    }
}
