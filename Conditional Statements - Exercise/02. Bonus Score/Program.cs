using System;

namespace _02.Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonus = points * 20 / 100.0;
            }
            else if (points > 1000)
            {
                bonus = points * 10 / 100.0;
            }

            if (points % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (points % 10 == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
