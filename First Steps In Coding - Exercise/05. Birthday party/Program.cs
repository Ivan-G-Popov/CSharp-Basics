using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForHall = double.Parse(Console.ReadLine());

            double cakePrice = (priceForHall / 100 * 20);
            double drinksPrice = cakePrice - (cakePrice * 45 / 100);
            double animatorPrice = priceForHall / 3;

            double totalPrice = priceForHall + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
