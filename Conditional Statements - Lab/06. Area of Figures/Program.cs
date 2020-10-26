using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;
                case "rectangle":
                    double c = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = c * b;
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;
                case "triangle":
                    double d = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    area = (d * h) / 2;
                    break;
            }
            Console.WriteLine("{0:f3}", area);
        }
    }
}
