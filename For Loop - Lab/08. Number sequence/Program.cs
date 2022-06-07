using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newNumMax = int.MinValue;
            int newNumMin = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (newNumMax < num)
                {
                    newNumMax = num;
                }
                if (newNumMin > num)
                {
                    newNumMin = num;
                }
            }

            Console.WriteLine($"Max number: {newNumMax}");
            Console.WriteLine($"Min number: {newNumMin}");
        }
    }
}