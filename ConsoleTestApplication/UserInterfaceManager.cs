using System;

namespace ConsoleTestApplication
{
    internal sealed class UserInterfaceManager
    {
        internal static void DisplayWelcome()
        {
            Console.WriteLine("Hello and welcome to the Temperature Converter test application.");
            Console.WriteLine("This version is the console application.");
        }

        internal static void DisplayInformation()
        {
            Console.WriteLine("\r\nPlease use 'q', 'Q' or 'quit' to exit.");
            Console.WriteLine("\r\nPlease enter a value for converting:\r\n");
        }

        internal static void DisplayResults(
            string celsiusValue,
            string fahrenheitValue,
            string kelvinValue,
            string gasValue)
        {
            Console.WriteLine("\r\nThe results are as follows:");
            Console.WriteLine($"Celsius: {celsiusValue}\u00b0C");
            Console.WriteLine($"Fahrenheit: {fahrenheitValue}\u00b0F");
            Console.WriteLine($"Kelvin: {kelvinValue} kelvin");
            Console.WriteLine($"Gas mark: {gasValue}");
        }
    }
}