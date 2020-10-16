using System;
using System.Reflection.Metadata;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Броят на кучетата – цяло число в интервала[0… 100]
            int countOfDogs = int.Parse(Console.ReadLine());
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            //3. Цена за една опаковка кучешка храна 2.50
            double dogFood = 2.50;
            double othersFood = 4;
            double sum = (countOfDogs * dogFood) + (countOfOtherAnimals * othersFood);
            Console.WriteLine($"{sum} lv.");

        }
    }
}
