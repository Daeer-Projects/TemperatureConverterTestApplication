namespace ConsoleTestApplication;

using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.Extensions.To.Rømer;

internal static class Program
{
    private static void Main()
    {
        bool isQuit = false;
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
                string rømerValue = input.FromCelsius()
                    .ToRømer();
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
                    rømerValue,
                    gasValue);
            }
        }
    }
}