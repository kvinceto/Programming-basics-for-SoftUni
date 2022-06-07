using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegi = int.Parse(Console.ReadLine());

            double chickenAmount = chicken * 10.35;
            double fishAmount = fish * 12.40;
            double vegiAmount = vegi * 8.15;
            double desert = (chickenAmount + fishAmount + vegiAmount) * 20 / 100.0;
            double delivery = 2.50;
            double sum = chickenAmount + fishAmount + vegiAmount + desert + delivery;

            Console.WriteLine(sum);
        }
    }
}
