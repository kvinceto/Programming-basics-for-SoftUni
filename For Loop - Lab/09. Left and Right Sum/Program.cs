using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumL = 0;
            int sumR = 0;

            for (int i = 0; i < n; i++)
            {
                int numL = int.Parse(Console.ReadLine());
                sumL += numL;
            }
            for (int i = 0; i < n; i++)
            {
                int numR = int.Parse(Console.ReadLine());
                sumR += numR;
            }
            if (sumL == sumR)
            {
                Console.WriteLine("Yes, sum = " + sumL);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumR - sumL));
            }
        }
    }
}