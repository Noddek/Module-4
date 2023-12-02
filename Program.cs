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









            Console.ReadKey();

        }
    }
}
