namespace Operators_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            int intMult = 8 * 13; // Initializes an integer that multiplies two numbers.
            int intAdd = 45 + 52; //Initializes an integer that adds two numbers.

            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}"); // Prints the max and min of the two integer variables.
           
            bool isIntGreater = intMult > intAdd; // Initaializes boolean to see if intMult is greater than intAdd.
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n"); // Prints if inMult is greater than intAdd.


            Console.WriteLine("SHORTS");
            short shortMult = 8 * 13; // Initializes an short that multiplies two shorts.
            short shortAdd = 45 + 52; //Initializes an short that adds to short.

            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}."); // Prints the max and min of the two short variables.
           
            bool isshortGreater = shortMult > shortAdd; // Initaializes boolean to see if shortMult is greater than shortAdd.
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n"); // Prints if shortMult is greater than shortAdd.


            Console.WriteLine("LONGS");
            long longMult = 8 * 13; // Initializes an long that multiplies two numbers.
            long longAdd = 45 + 52; //Initializes an long that adds to long.

            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"The min of the two is {Math.Min(longMult, longAdd)}."); // Prints the max and min of the two long variables.

            bool islongGreater = longMult > longAdd; // Initaializes boolean to see if longMult is greater than longAdd.
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n"); // Prints if longMult is greater than longAdd.


            Console.WriteLine("FLOATS");
            float floatMult = 8 * 13; // Initializes an float that multiplies two numbers.
            float floatAdd = 45 + 52; //Initializes an float that adds to float.

            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}."); // Prints the max and min of the two float variables.

            bool isfloatGreater = floatMult > floatAdd; // Initaializes boolean to see if floatMult is greater than floatAdd.
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n"); // Prints if floatMult is greater than floatAdd.


            Console.WriteLine("DOUBLES");
            double doubleMult = 8 * 13; // Initializes an double that multiplies two numbers.
            double doubleAdd = 45 + 52; //Initializes an double that adds to doublee.

            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}."); // Prints the max and min of the two double variables.

            bool isdoubleGreater = doubleMult > doubleAdd; // Initaializes boolean to see if doubleMult is greater than doubleAdd.
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n"); // Prints if doubleMult is greater than doubleAdd.


            Console.WriteLine("DECIMAL");
            decimal decimalMult = (decimal)(8.64 * 13.25); // Initializes an decimal that multiplies two numbers.
            decimal decimalAdd = (decimal)(45.33 + 52.74); //Initializes an decimal that adds to decimal.

            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}."); // Prints the max and min of the two decimal variables.

            bool isdecimalGreater = decimalMult > decimalAdd; // Initaializes boolean to see if decimalMult is greater than decimalAdd.
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n"); // Prints if decimalMult is greater than decimalAdd.
        }
    }
}
