using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;

namespace ConsoleTestApplication
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            bool isQuit = false;
            var userInterfaceManager = new UserInterfaceManager();
            UserInterfaceManager.DisplayWelcome();

            while (!isQuit)
            {
                UserInterfaceManager.DisplayInformation();
                var input = Console.ReadLine();

                if (input != null &&
                    (input.Equals("q", StringComparison.OrdinalIgnoreCase) ||
                     input.Equals("quit", StringComparison.OrdinalIgnoreCase)))
                {
                    isQuit = true;
                }
                else
                {
                    var celsiusValue = input.FromCelsius()
                        .ToCelsius();
                    var fahrenheitValue = input.FromCelsius()
                        .ToFahrenheit();
                    var kelvinValue = input.FromCelsius()
                        .ToKelvin();
                    string gasValue;

                    try
                    {
                        gasValue = input.FromCelsius()
                            .ToGas();
                    }
                    catch (ArgumentOutOfRangeException exception)
                    {
                        gasValue = exception.Message;
                    }

                    UserInterfaceManager.DisplayResults(
                        celsiusValue,
                        fahrenheitValue,
                        kelvinValue,
                        gasValue);
                }
            }
        }
    }
}