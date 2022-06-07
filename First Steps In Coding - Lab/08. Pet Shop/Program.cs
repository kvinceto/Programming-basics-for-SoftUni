using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            double a = 2.50;
            double dogFood = dog * a;

            int cat = int.Parse(Console.ReadLine());
            double b = 4;
            double catFood = cat * b;

            double sum = dogFood + catFood;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
