using System.Net.WebSockets;
using static System.Collections.Specialized.BitVector32;

namespace BasicConstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparing fruits:");
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

            Console.WriteLine("\nSelection statements (conditional statements) if-else. ");
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


            Console.WriteLine("\nTask 4.1.17. A program about colors to reinforce skills.");
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





            Console.ReadKey();

        }
    }
}
