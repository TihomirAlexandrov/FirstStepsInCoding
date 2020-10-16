using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall = double.Parse(Console.ReadLine());
            double cake = hall * 0.2;
            double drinks = cake - (0.45 * cake);
            double animator = hall / 3;
            double budget = hall + cake + drinks + animator;

            Console.WriteLine(budget);
        }
    }
}
