﻿using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numMax = int.MinValue;
            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num > numMax)
                {
                    numMax = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(numMax);
        }
    }
}