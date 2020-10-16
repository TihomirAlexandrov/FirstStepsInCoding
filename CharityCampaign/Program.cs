using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfParticipants = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double priceOfCake = 45;
            double priceOfWaffles = 5.80;
            double priceOfPancakes = 3.20;

            double cakesADayFromSingleParticipant = priceOfCake * numberOfCakes;
            double wafflesADayFromSingleParticipant = priceOfWaffles * numberOfWaffles;
            double pancakesADayFromSingleParticipant = priceOfPancakes * numberOfPancakes;

            double totalSumDaily = (cakesADayFromSingleParticipant + wafflesADayFromSingleParticipant + pancakesADayFromSingleParticipant) * numberOfParticipants;
            double totalSumCampaign = totalSumDaily * numberOfDays;
            double totalSumAfterBills = totalSumCampaign - (totalSumCampaign / 8);

            Console.WriteLine(totalSumAfterBills);
        }
    }
}
