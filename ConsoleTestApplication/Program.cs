using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;

namespace ConsoleTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Temperature Converter test application.");
            Console.WriteLine("This version is the console application.");

            bool isQuit = false;


            while (!isQuit)
            {
                DisplayUserInformation();
                var input = Console.ReadLine();

                if (input != null && (input.Equals("q", StringComparison.OrdinalIgnoreCase) || input.Equals("quit", StringComparison.OrdinalIgnoreCase)))
                {
                    isQuit = true;
                }
                else
                {
                    var celsiusValue = input.FromCelsius().ToCelsius();
                    var fahrenheitValue = input.FromCelsius().ToFahrenheit();
                    var kelvinValue = input.FromCelsius().ToKelvin();
                    string gasValue;

                    try
                    {
                        gasValue = input.FromCelsius().ToGas();
                    }
                    catch (ArgumentOutOfRangeException exception)
                    {
                        gasValue = exception.Message;
                    }

                    Console.WriteLine("\r\nThe results are as follows:");
                    Console.WriteLine($"Celsius: {celsiusValue}\u00b0C");
                    Console.WriteLine($"Fahrenheit: {fahrenheitValue}\u00b0F");
                    Console.WriteLine($"Kelvin: {kelvinValue} kelvin");
                    Console.WriteLine($"Gas mark: {gasValue}");
                }
            }
        }

        private static void DisplayUserInformation()
        {
            Console.WriteLine("\r\nPlease use 'q', 'Q' or 'quit' to exit.");
            Console.WriteLine("\r\nPlease enter a value for converting:\r\n");
        }
    }
}
