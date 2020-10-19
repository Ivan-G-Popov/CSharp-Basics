using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int aderAnimal = int.Parse(Console.ReadLine());

            double totalPrice = numberOfDogs * 2.50 + aderAnimal * 4.0;
            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
