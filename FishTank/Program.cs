using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int size = length * width * height;
            double sizeInLitres = size * 0.001;
            double convertedPercentage = percentage * 0.01; 
            double totalSize = sizeInLitres * (1 - convertedPercentage);

            Console.WriteLine(totalSize);
        }
    }
}
