using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfCooks = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double priceForCake = 45.0;
            double priceForWaffles = 5.8;
            double priceForPancakes = 3.20;

            double moneyFromCakes = priceForCake * numberOfCakes;
            double moneyFromWaffes = priceForWaffles * numberOfWaffles;
            double moneyFromPancakes = priceForPancakes * numberOfPancakes;

            double monyFromOneDay = (moneyFromCakes + moneyFromPancakes + moneyFromWaffes) * numberOfCooks;
            double totalMoney = monyFromOneDay * days;

            double colectedMoney = totalMoney - (totalMoney / 8);

            Console.WriteLine(colectedMoney);
        }
    }
}
