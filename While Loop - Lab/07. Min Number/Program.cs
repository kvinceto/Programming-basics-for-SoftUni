﻿using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numMin = int.MaxValue;
            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num < numMin)
                {
                    numMin = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(numMin);
        }
    }
}