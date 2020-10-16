using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberriesPerKg = double.Parse(Console.ReadLine());

            double amountOfBananasInKg = double.Parse(Console.ReadLine());
            double amountOfOrangesInKg = double.Parse(Console.ReadLine());
            double amountOfRaspberriesInKg = double.Parse(Console.ReadLine());
            double amountOfStrawberriesInKg = double.Parse(Console.ReadLine());

            double priceOfRaspberriesPerKg = priceStrawberriesPerKg * 0.5;
            double priceOfOrangesPerKg = priceOfRaspberriesPerKg - (priceOfRaspberriesPerKg * 0.4);
            double priceOfBananasPerKg = priceOfRaspberriesPerKg - (priceOfRaspberriesPerKg * 0.8);

            double totalPriceOfRaspberries = amountOfRaspberriesInKg * priceOfRaspberriesPerKg;
            double totalPriceOfOranges = amountOfOrangesInKg * priceOfOrangesPerKg;
            double totalPriceOfBananas = amountOfBananasInKg * priceOfBananasPerKg;
            double totalPriceOfStrawberries = amountOfStrawberriesInKg * priceStrawberriesPerKg;

            double totalSumNeeded = totalPriceOfBananas + totalPriceOfOranges + totalPriceOfRaspberries + totalPriceOfStrawberries;

            Console.WriteLine($"{totalSumNeeded:f2}");
        }
    }
}
