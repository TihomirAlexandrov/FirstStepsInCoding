using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dollarCourse = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine($"{bgn:f2}");
        }
    }
}
