namespace ConsoleTestApplication;

using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;

internal static class Program
{
    private static void Main(string[] args)
    {
        bool isQuit = false;
        UserInterfaceManager userInterfaceManager = new UserInterfaceManager();
        UserInterfaceManager.DisplayWelcome();

        while (!isQuit)
        {
            UserInterfaceManager.DisplayInformation();
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input) ||
                (input == "q" ||
                 input == "Q" ||
                 input.Equals("quit", StringComparison.OrdinalIgnoreCase)))
            {
                isQuit = true;
            }
            else
            {
                string celsiusValue = input.FromCelsius()
                    .ToCelsius();
                string fahrenheitValue = input.FromCelsius()
                    .ToFahrenheit();
                string kelvinValue = input.FromCelsius()
                    .ToKelvin();
                string rankinValue = input.FromCelsius()
                    .ToRankine();
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
                    rankinValue,
                    gasValue);
            }
        }
    }
}