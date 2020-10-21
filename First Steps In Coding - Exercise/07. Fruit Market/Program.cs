using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double banabasInKg = double.Parse(Console.ReadLine());
            double orangeInKg = double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice / 100 * 40);
            double banabasPrice = raspberriesPrice - (raspberriesPrice / 100 * 80);

            double totalPrice = (banabasInKg * banabasPrice) + (orangeInKg * orangesPrice) + (raspberriesInKg * raspberriesPrice) + (strawberriesInKg * strawberriesPrice);

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
