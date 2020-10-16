using System;

namespace CelsiusToKelvinAndFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = int.Parse(Console.ReadLine());

            int kelvin = celsius + 273;
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"Temperature in Kelvin is: {kelvin}");
            Console.WriteLine($"Temperature in Fahrenheit is: {fahrenheit}");
        }
    }
}
