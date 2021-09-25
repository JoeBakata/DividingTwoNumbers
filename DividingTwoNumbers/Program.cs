using System;

namespace DividingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print name, version and name of creator in cyan.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDividingTwoNumbers\tVer 1.0\tcreated by JB");

            // Console foreground color back to default.
            Console.ForegroundColor = ConsoleColor.Gray;

            //  Ask the user to enter the first number called the dividend - the number that is being divided.
            Console.Write($"Please enter the Dividend: ");

            // Define a variable to store the dividend. Parse it from a string into a double.
            double dividend = double.Parse(Console.ReadLine());

            // Ask the user to enter the second number called the divisor - the number that it is being divided by.
            Console.Write($"Please enter the Divisor: ");

            // Define a variable to store the divisor. Remember to parse it from a string into a double.
            double divisor = double.Parse(Console.ReadLine());

            // Define a variable for the answer.
            double quotient;

            // Define the equation that will give the answer. Store it in the quotient.
            quotient = (dividend / divisor);

            // Change the console foreground color to green.
            Console.ForegroundColor = ConsoleColor.Green;

            // Show the user the answer in green.
            Console.Write($"\nWhen you divide {dividend} by {divisor}\nyou get {quotient} which is the quotient.\n");

            // todo1 Should I show the remainder?
            // todo2 make a way for the program to continue. Loop.
            // todo3 make a way to exit the program. Boolean logic.
            // todo4 check for valid input. 

        }
    }
}
