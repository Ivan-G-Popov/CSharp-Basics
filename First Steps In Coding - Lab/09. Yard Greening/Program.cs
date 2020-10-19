using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetre = double.Parse(Console.ReadLine());

            double pricePerSqMeter = 7.61;

            double totalPrice = squareMetre * pricePerSqMeter;
            double discount = (totalPrice / 100) * 18;

            Console.WriteLine($"The final price is: {totalPrice - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
