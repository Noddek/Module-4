﻿using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

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
            for (int i = 0; i < 5;)
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

            Console.WriteLine("\nThe task of summing positive numbers: [COMMENTED]");
            /*
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
            */

            Console.WriteLine("\n\nMODULE 4.3. Arrays.");
            Console.WriteLine("\nA program with several favorite colors. [COMMENTED]");
            /*
            string[] favoriteColors = new string[3];
            for (int i = 0; i < favoriteColors.Length; i++)
            {
                Console.Write("\tPlease write your favorite color number {0} with a small letter: ", i + 1);
                favoriteColors[i] = Console.ReadLine();
            }
            foreach (var color in favoriteColors)
            {
                switch (color)
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

            Console.WriteLine("\nAn example with initializing an array and determining its length.");
            int[] arr1 = new int[5] { 1, 2, 4, 8, 16 };
            int[] arr2 = new int[] { 10, 15, 20, 25, 30, 35 };
            int[] arr3 = new[] { 1, 3, 5, 7, 11, 13 };
            int[] arr4 = { 2, 4, 6, 8, 10, 12, 14 };
            Console.WriteLine("\tThe length of array 'arr1': {0}", arr1.Length);
            Console.WriteLine("\tThe length of array 'arr2': {0}", arr2.Length);
            Console.WriteLine("\tThe length of array 'arr3': {0}", arr3.Length);
            Console.WriteLine("\tThe length of array 'arr4': {0}", arr4.Length);

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();

            Console.WriteLine("\nSearch for a MIN in an array and display its value and index.");
            Random randomNumber = new Random();
            var numbers = new int[] { randomNumber.Next(1, 100), randomNumber.Next(1, 100), randomNumber.Next(1, 100), randomNumber.Next(1, 100), randomNumber.Next(1, 100), randomNumber.Next(1, 100) };
            Console.WriteLine("\tArray length: " + numbers.Length);
            Console.WriteLine("\tGenerated random numbers of the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("\t\t{0} index: {1}", i, numbers[i]);
            }
            int minValue = numbers[0];
            int minIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("\tThe MIN element of the array has index {0} and its value is {1}.", minIndex, minValue);

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();

            Console.WriteLine("\nAn example of spelling words out. [COMMENTED]");
            /*
            Console.Write("\tEnter your name: ");
            string yourName = Console.ReadLine();
            Console.Write("\tYour name is spelled");
            foreach (var letter in yourName)
            {
                Console.Write(" " + letter);
            }
            Console.Write(", and the last letter is {0}.\n", yourName[yourName.Length - 1]);
            */

            Console.WriteLine("\nTask 4.3.7. Rearrange the letters of a name in reverse order. [COMMENTED]");
            /*
            Console.Write("\tEnter your name: ");
            string yourName1 = Console.ReadLine();
            Console.Write("\tYour name in reverse:");
            for (int i = yourName1.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + yourName1[i]);
            }
            */

            Console.WriteLine("\n\n1-dimensional array:");
            int[] array1D = new int[] { 1, 2, 3 };
            Console.Write("\tAll elements of the 1D array through foreach cycle:");
            foreach (var element in array1D)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine("\n\tThe 1D array length: " + array1D.Length);
            Console.WriteLine("\tChecking the GetUpperBound(0) for 1D array: " + array1D.GetUpperBound(0));
            

            Console.WriteLine("\n\n2-dimensional array:");
            int[,] array2D = new int [4,3] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 }, { 100, 110, 120 } };
            Console.WriteLine("\tThe element with index [0,0]: " + array2D[0, 0]);
            Console.Write("\tAll elements of the 2D array through foreach cycle:");
            foreach (var element in array2D)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine("\n\tThe 2D array length: " + array2D.Length);
            Console.WriteLine("\tChecking the GetUpperBound(0) for 2D array: " + array2D.GetUpperBound(0));
            Console.WriteLine("\tChecking the GetUpperBound(1) for 2D array: " + array2D.GetUpperBound(1));
            Console.WriteLine("\tPossible number of table rows for 2D array: " + (array2D.GetUpperBound(0) + 1));
            Console.WriteLine("\tPossible number of table columns for 2D array: " + (array2D.GetUpperBound(1) + 1));
            Console.WriteLine("\tCreating the table using two embedded cycles 'for':");
            for (int i = 0; i <= array2D.GetUpperBound(0); i++)
            {
                Console.Write("\t\t");
                for (int k = 0; k <= array2D.GetUpperBound(1); k++)
                {
                    Console.Write(array2D[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\tTask 4.3.11. Create a table by swapping rows and columns.");
            for (int i = 0; i <= array2D.GetUpperBound(1); i++)
            {
                Console.Write("\t\t");
                for (int k = 0; k <= array2D.GetUpperBound(0); k++)
                {
                    Console.Write(array2D[k, i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n3-dimensional array:");
            int[,,] array3D = new int[2, 4, 2] { { { 10, 11 }, { 20, 21 }, { 30, 31 }, { 35, 36 } }, { { 40, 41 }, { 50, 51 }, { 60, 61 }, { 65, 66 } } };
            Console.Write("\tAll elements of the 3D array through foreach cycle:");
            foreach (var element in array3D)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine("\n\tThe 3D array length: " + array3D.Length);
            Console.WriteLine("\tChecking the GetUpperBound(0) for 3D array: " + array3D.GetUpperBound(0));
            Console.WriteLine("\tChecking the GetUpperBound(1) for 3D array: " + array3D.GetUpperBound(1));
            Console.WriteLine("\tChecking the GetUpperBound(2) for 3D array: " + array3D.GetUpperBound(2));

            Console.WriteLine("\n...Press any key to continue..."); Console.ReadKey();

            // ----------------------> Task 4.3.12. My method. START.

            Console.WriteLine("\nTask 4.3.12. Sort a 1D array in ascending order.");
            Console.WriteLine(">>> MY LAST TRY - NEW SORTING METHOD:");
            var U = new int[] { -100, 5, 3, 6, 1, 9, 1, 1, 2, -150, 1, -150, 2, 3, 4, 7, 4, 4 }; // Initial Unsorted array with repeats
            var S = new int[U.Length]; // Result: Sorted array with repeats
            var sortingIteration = 0; // General iteration number of sorting.
            var lastMinIndex = 0; // Current last minimum index in U
            var lastMinValue = U[lastMinIndex]; // Current last minimum value in U
            var tempMinIndex = -1; // Variable for temporary saving indices of interim minimums during the search in U
            var tempMinValue = U[lastMinIndex]; // Variable for temporary saving values of interim minimums during the search in U
            var lastMinCounter = 0; // Number of repetitions of the last minimum in U
            var lastSortedArrayIndex = -1; // Index of the last recorded element in S (recording will be in ascending order of indices, without skipping)
            var tempSortedArrayIndex = -1; // Variable for temporary saving some indexes of S
            Console.Write("\tUnsorted array: ");
            foreach (var element in U)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n\tUnsorted array length: " + U.Length);
            while (lastSortedArrayIndex < S.Length - 1)
            {
                sortingIteration++;
                Console.WriteLine("\n>>> Sorting. General iteration number: " + sortingIteration);
                // 1. Find the minimum
                Console.WriteLine("1. Loop to find the minimum.");
                for (int i = 0; i < U.Length; i++)
                {
                    if ((lastSortedArrayIndex < 0) && (U[i] <= tempMinValue)) // 1.1. To find the first minimum value
                    {
                        tempMinIndex = i;
                        tempMinValue = U[i];
                        Console.WriteLine("\tChanges: tempMinIndex is {0}, tempMinValue is {1}", tempMinIndex, tempMinValue);
                    }
                    else if ((lastSortedArrayIndex >= 0) && (U[i] > lastMinValue) && (U[i] <= tempMinValue)) // 1.2. To find the next minimums
                    {
                        tempMinIndex = i;
                        tempMinValue = U[i];
                        Console.WriteLine("\tChanges: tempMinIndex is {0}, tempMinValue is {1}", tempMinIndex, tempMinValue);
                    }
                }
                lastMinIndex = tempMinIndex;
                lastMinValue = tempMinValue;
                Console.WriteLine("\tChanges: lastMinIndex is {0}, lastMinValue is {1}", lastMinIndex, lastMinValue);
                // 2. Set new values for the variables 'tempMinIndex' and 'tempMinValue'.
                Console.WriteLine("2. Loop to set new values for the variables 'tempMinIndex' and 'tempMinValue'.");
                for (int i = 0; i < U.Length; i++)
                {
                    if (U[i] > lastMinValue)
                    {
                        tempMinIndex = i;
                        tempMinValue = U[i];
                        Console.WriteLine("\tChanges: tempMinIndex is {0}, tempMinValue is {1}", tempMinIndex, tempMinValue);
                        break;
                    }
                    else if (i == (U.Length - 1))
                    {
                        Console.WriteLine("\ttempMinIndex and tempMinValue are not changed.");
                        Console.WriteLine("\ttempMinIndex == lastMinIndex ? - " + (tempMinIndex == lastMinIndex));
                        Console.WriteLine("\ttempMinValue == lastMinValue ? - " + (tempMinValue == lastMinValue));
                        Console.WriteLine("\tIt should be last general iteration!");
                    }
                }
                // 3. Count the amount of elements that are equal to the last minimum value. Use a counter. 
                Console.WriteLine("3. Loop to count the amount of elements that are equal to the last minimum value.");
                for (int i = 0; i < U.Length; i++)
                {
                    if (U[i] == lastMinValue)
                    {
                        lastMinCounter++;
                        Console.WriteLine("\tChanges: lastMinCounter is {0}", lastMinCounter);
                    }
                }
                // 4. Write the found amount of elements with the minimum value to the sorted array. At the end, reset the counter.
                Console.WriteLine("4. Loop to write the found amount of elements with the minimum value to the sorted array.");
                while (lastMinCounter > 0)
                {
                    for (int i = lastSortedArrayIndex + 1; i < lastSortedArrayIndex + 1 + lastMinCounter; i++)
                    {
                        S[i] = lastMinValue;
                        tempSortedArrayIndex = i;
                    }
                    Console.Write("\tSorted array is changed to: ");
                    foreach (var element in S)
                    {
                        Console.Write(element + " ");
                    }
                    lastSortedArrayIndex = tempSortedArrayIndex;
                    Console.WriteLine("\n\tChanges: lastSortedArrayIndex is " + lastSortedArrayIndex);
                    lastMinCounter = 0;
                    Console.WriteLine("\tChanges: lastMinCounter is " + lastMinCounter);
                }
            }
            Console.WriteLine("\nLoop WHILE for sorting is finished.\nTask 4.3.12 is completed (my method).");

            // ----------------------> Task 4.3.12. My method. END.

            
            // ----------------------> Task 4.3.12. SF method. START.

            Console.WriteLine("\nTask 4.3.12. Sort a 1D array in ascending order. SF method: swap positions of elements.");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 }; // Initial Unsorted array
            Console.Write("Initial Unsorted array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nUnsorted array length: " + arr.Length);
            int temp;
            int totalIterations = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalIterations++;
                Console.WriteLine("\tIteration number: i = {0}", i);
                for (int k = i + 1; k < arr.Length; k++)
                {
                    totalIterations++;
                    Console.WriteLine("\t\tk = {0}", k);
                    if (arr[i] > arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                        Console.WriteLine("\t\tChanges: temp = {0} -> arr[{1}] = {2} -> arr[{3}] = {4}", temp, i, arr[i], k, arr[k]);
                        Console.Write("\t\tSorted array is changed to: ");
                        foreach (var item in arr)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.Write("\nSorted array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nTotal number of iterations: " + totalIterations);

            // ----------------------> Task 4.3.12. SF method. END.


            Console.WriteLine("\nTask 4.3.13. Find the sum of all elements of the array. - My method.");
            var U1 = new int[] { 5, 6, 9, 1, 2, 3, 4 }; // Initial Unsorted array
                                                        // var U1 = new int[] { -100, 5, 3, 6, 1, 9, 1, 1, 2, -150, 1, -150, 2, 3, 4, 7, 4, 4 };
            var sum = 0; // Result: sum of all array elements
            Console.Write("\tUnsorted array: ");
            foreach (var element in U1)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n\tUnsorted array length: " + U1.Length);
            for (int i = 0; i < U1.Length; i++) 
            {
                sum += U1[i];
            }
            Console.WriteLine("\tSum of all array elements: " + sum);


            Console.WriteLine("\n\nJagged array (array of arrays) using the example of an array containing strings in its elements:");
            var favouriteColorsJ = new string[] { "red color", "green", "cyan" };
            Console.Write("\n\tElements of the external (main) array:\n\t\t| ");
            foreach (var color in favouriteColorsJ)
            {
                Console.Write(color + " | ");
            }
            Console.WriteLine("\n\n\tElements of the internal (secondary) arrays:");
            foreach (var color in favouriteColorsJ)
            {
                Console.Write("\t\t" + color + ": | ");
                int counter = 0;
                foreach (var item in color)
                {
                    counter++;
                    Console.Write(item + " | ");
                }
                Console.Write(" -> number of elements: {0} (counter) or {1} (color.Length)", counter, color.Length);
                Console.WriteLine();
            }

            Console.WriteLine("\nInitialization of an array of arrays:");
            int[][] arrayOfArrays = new int[3][];
            arrayOfArrays[0] = new int[2] { 1, 2 };
            arrayOfArrays[1] = new int[3] { 1, 2, 3 };
            arrayOfArrays[2] = new int[5] { 1, 2, 3, 4, 5 };
            
            
            Console.WriteLine("\nTask 4.3.14. Go through the elements of the array of arrays by analogy with an array of strings.");
            int counterOfArrays = 0;
            foreach (var array in arrayOfArrays)
            {
                counterOfArrays++;
                Console.Write("\tArray {0}: | ", counterOfArrays);
                foreach (var subarray in array)
                {
                    Console.Write(subarray + " | ");
                }
                Console.Write(" -> number of elements: {0} (array.Length)", array.Length);
                Console.WriteLine();
            }


            Console.WriteLine("\nTask 4.3.15. Find the amount of positive numbers.");
            int[] numericArray = { -5, 0, 6, -50, 2, 4, -5, -50, 2 }; // Initial array with repeats
            int positiveElements = 0; // The amount of positive numbers
            Console.Write("\tElements of the initial array: | ");
            foreach (var number in numericArray)
            {
                Console.Write(number + " | ");
            }
            // My method:
            foreach (var number in numericArray)
            {
                if (number > 0)
                {
                    positiveElements++;
                }
            }
            Console.WriteLine("\n\tThe amount of positive numbers (my method): " + positiveElements);
            // SF method:
            positiveElements = 0;
            for (int i = 0; i < numericArray.Length; i++)
            {
                if (numericArray[i] > 0) 
                {
                    positiveElements++;
                }
            }
            Console.WriteLine("\tThe amount of positive numbers (SF method): " + positiveElements);


            Console.WriteLine("\nTask 4.3.16. Find the amount of positive numbers in 2D-array.");
            int[,] numeric2DArray = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } }; // Initial 2D-array with repeats
            int positiveElements2D = 0; // The amount of positive numbers in the 2D-array
            Console.Write("\tElements of the initial 2D-array: | ");
            foreach (var number in numeric2DArray)
            {
                Console.Write(number + " | ");
            }
            // My method:
            foreach (var number in numeric2DArray)
            {
                if (number > 0)
                {
                    positiveElements2D++;
                }
            }
            Console.WriteLine("\n\tThe amount of positive numbers in 2D-array (my method): " + positiveElements2D);
            // SF method:
            positiveElements2D = 0;
            for (int i = 0; i <= numeric2DArray.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= numeric2DArray.GetUpperBound(1); k++)
                {
                    if (numeric2DArray[i, k] > 0)
                    {
                        positiveElements2D++;
                    }
                }
            }
            Console.WriteLine("\tThe amount of positive numbers in 2D-array (SF method): " + positiveElements2D);


            Console.WriteLine("\nTask 4.3.17. Sorting of 2D-array - sorting within the last dimension");
            Console.Write("\tElements of the initial 2D-array: | ");
            foreach (var number in numeric2DArray)
            {
                Console.Write(number + " | ");
            }
            // My method (SF method is the same):
            int tempValue = 0;
            for (int i = 0; i <= numeric2DArray.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= numeric2DArray.GetUpperBound(1); k++)
                {
                    for (int l = k + 1; l <= numeric2DArray.GetUpperBound(1); l++)
                    {
                        if (numeric2DArray[i,k] > numeric2DArray[i, l])
                        {
                            tempValue = numeric2DArray[i, k];
                            numeric2DArray[i, k] = numeric2DArray[i, l];
                            numeric2DArray[i, l] = tempValue;
                        }
                    }
                }
            }
            Console.Write("\n\tSorted 2D-array:\n\t\t");
            for (int i = 0; i <= numeric2DArray.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= numeric2DArray.GetUpperBound(1); k++)
                {
                    Console.Write(numeric2DArray[i,k] + " | ");
                }
                Console.Write("\n\t\t");
            }


            Console.WriteLine("\n\nMODULE 4.4. Tuples.");
            Console.WriteLine("\nExample of a tuple.");
            var exampleOfTuple = (name: "Jane", age: 27);
            Console.WriteLine("\tYour name: {0} ({1})", exampleOfTuple.name, exampleOfTuple.Item1);
            Console.WriteLine("\tYour age: {0} ({1})", exampleOfTuple.age, exampleOfTuple.Item2);

            Console.WriteLine("\nTask 4.4.2. A program for recording user's personal information in tuple anketa. [COMMENTED]");
            /*
            (string name, int age) anketa;
            Console.Write("\tEnter you name: ");
            anketa.name = Console.ReadLine();
            Console.Write("\tEnter you age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tRecorded data: name '{0}', age '{1}'.", anketa.name, anketa.age);
            */

            Console.WriteLine("\nExample of a tuple without a name.");
            var (exampleName, exampleAge) = ("Robert", 31);
            Console.WriteLine("\tYour name: {0}", exampleName);
            Console.WriteLine("\tYour age: {0}", exampleAge);

            Console.WriteLine("Task 4.4.3. A program with a tuple without a name. [COMMENTED]");
            /*
            var (name, age) = ("Rob", 51);
            Console.WriteLine("\tMy name: {0}", name);
            Console.WriteLine("\tMy age: {0}", age);
            Console.Write("\tEnter you name: ");
            name = Console.ReadLine();
            Console.Write("\tEnter you age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tYour name: {0}", name);
            Console.WriteLine("\tYour age: {0}", age);
            */

            Console.WriteLine("Tasks 4.4.4 and 4.4.5. A tuple for pet. [COMMENTED]");
            /*
            // (string Name, string Type, double Age) Pet; -> Task 4.4.4.
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("\tEnter the pet's name: ");
            Pet.Name = Console.ReadLine();
            Console.Write("\tEnter the pet's type: ");
            Pet.Type = Console.ReadLine();
            Console.Write("\tEnter the pet's age: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            //SF variant: Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = 0;
            foreach (var letter in Pet.Name)
            { Pet.NameCount++; }
            //SF variant: Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("\tPet's name: {0}", Pet.Name);
            Console.WriteLine("\tPet's type: {0}", Pet.Type);
            Console.WriteLine("\tPet's age: {0}", Pet.Age);
            Console.WriteLine("\tThe length of the pet's name: {0}", Pet.NameCount);
            */

            Console.WriteLine("\n\nMODULE 4.5. Training workshop.[COMMENTED]");
            /*
            Console.WriteLine("\tGeneral task: User survey.");
            Console.WriteLine("\tTask 4.5.1. Declare a tuple User.");
            (string Name, string Surname, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;
            Console.WriteLine("\tTask 4.5.6. Make the survey repeat for 3 users.");
            int numberOfUsers = 3;
            for (j = 1; j <= numberOfUsers; j++)
            {
                Console.WriteLine("\tTask 4.5.2. Key in data for Name, Surname, Login.");
                Console.Write("\tEnter the your name: ");
                User.Name = Console.ReadLine();
                Console.Write("\tEnter your surname: ");
                User.Surname = Console.ReadLine();
                Console.Write("\tEnter your login: ");
                User.Login = Console.ReadLine();
                Console.WriteLine("\tTask 4.5.3. Calculate user login length.");
                User.LoginLength = User.Login.Length;
                Console.WriteLine("\tTask 4.5.4. Write a yes-no condition for the pet.");
                Console.Write("\tDo you have a pet? Yes or No: ");
                string answerPet = Console.ReadLine();
                if (answerPet == "Yes" || answerPet == "yes")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                Console.WriteLine("\tTask 4.5.5. Write code to enter the user's age and three favorite colors.");
                Console.Write("\tEnter your age: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                //SF variant: User.Age = double.Parse(Console.ReadLine());
                Console.WriteLine("\tEnter your 3 favorite colors: ");
                User.favcolors = new string[3];
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    Console.Write("\t\t");
                    User.favcolors[i] = Console.ReadLine();
                }
            }
            */





            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
