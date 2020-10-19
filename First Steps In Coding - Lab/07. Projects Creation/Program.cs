using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());

            int needetHours = projectsNumber * 3;

            Console.WriteLine($"The architect {architectName} will need {needetHours} hours to complete {projectsNumber} project/s.");
        }
    }
}
