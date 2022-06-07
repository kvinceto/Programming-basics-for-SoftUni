using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int allSteps = 0;
            string stepsToday = Console.ReadLine();

            while (allSteps < goal)
            {
                if (stepsToday == "Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    allSteps += steps;
                    if (allSteps >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{allSteps - goal} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Abs(allSteps - goal)} more steps to reach goal.");
                    }
                    break;
                }
                int stepsNumber = int.Parse(stepsToday);
                allSteps += stepsNumber;
                if (allSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{allSteps - goal} steps over the goal!");
                    break;
                }
                stepsToday = Console.ReadLine();
            }
        }
    }
}