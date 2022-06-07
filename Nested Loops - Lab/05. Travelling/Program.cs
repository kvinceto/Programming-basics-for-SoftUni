using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double sum = 0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (sum < budget)
                {
                    double income = double.Parse(Console.ReadLine());
                    sum += income;
                }
                Console.WriteLine($"Going to {destination}!");
                sum = 0;
                destination = Console.ReadLine();
            }
        }
    }
}