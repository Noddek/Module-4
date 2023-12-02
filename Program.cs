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








            Console.ReadKey();

        }
    }
}
