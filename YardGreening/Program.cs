using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала[0.00… 10000.00]
            double kvadrati = double.Parse(Console.ReadLine());
            double Cena = kvadrati * 7.61;
            double krainaCena = Cena - (Cena * 0.18);
            double otstupka = Cena - krainaCena;
            Console.WriteLine($"The final price is {krainaCena} lv.");
            Console.WriteLine($"The discount is {otstupka} lv.");
        }
    }
}
