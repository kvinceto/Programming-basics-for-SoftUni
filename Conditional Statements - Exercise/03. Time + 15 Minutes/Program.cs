﻿using System;

namespace _03.Time_15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double hourInMin = minutes + 15;

            if (hourInMin >= 60)
            {
                hour++;
                hourInMin -= 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            if (hourInMin < 10)
            {
                Console.WriteLine($"{hour}:0{hourInMin}");
            }
            else
            {
                Console.WriteLine($"{hour}:{hourInMin}");
            }
        }
    }
}
