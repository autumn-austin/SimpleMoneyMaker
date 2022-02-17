using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {   // Greet the user and get input
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount to convert to coins: ");

            string totalAsString = Console.ReadLine();
            double total = Convert.ToDouble(totalAsString);

            Console.WriteLine($"{total} is equal to ...");

            // Define coin values
            int quarterValue = 25;
            int dimeValue = 10;
            int nickelValue = 5;

            // Calculate the change
            double quarters = Math.Floor(total / quarterValue);
            double remainder = total % quarterValue;

            double dimes = Math.Floor(remainder / dimeValue);
            remainder = remainder % dimeValue;

            double nickels = Math.Floor(remainder / nickelValue);
            remainder = remainder % nickelValue;

            // Print the results
            Console.WriteLine($"Quarters: {quarters}");
            Console.WriteLine($"Dimes: {dimes}");
            Console.WriteLine($"Nickels: {nickels}");
            Console.WriteLine($"Pennies: {remainder}");


        
        }
    }
}
