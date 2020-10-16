using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert four random numbers:");
            
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());

            double averageNumber = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The average number is: {averageNumber}");

        }
    }
}
