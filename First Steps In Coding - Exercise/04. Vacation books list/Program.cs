using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesNumber = int.Parse(Console.ReadLine());
            double pagesPerAuer = double.Parse(Console.ReadLine());
            int numbersOfDais = int.Parse(Console.ReadLine());

            double totalTimeForRead = pagesNumber / pagesPerAuer;
            double needetTime = totalTimeForRead / numbersOfDais;

            Console.WriteLine(needetTime);
        }
    }
}
