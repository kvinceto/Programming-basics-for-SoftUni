using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 1 / 8.0;
            double restTime = breakTime * 1 / 4.0;
            double timeLeft = breakTime - lunchTime - restTime;

            if (timeLeft >= duration)
            {
                double timeNotUsed = Math.Ceiling(timeLeft - duration);
                Console.WriteLine($"You have enough time to watch {name} and left with {timeNotUsed} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(duration - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {timeNeeded} more minutes.");
            }
        }
    }
}
