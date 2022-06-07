using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardNum = int.Parse(Console.ReadLine());
            int processorNum = int.Parse(Console.ReadLine());
            int ramNum = int.Parse(Console.ReadLine());

            double videoCardPr = 250.00;
            double videoCardSum = videoCardNum * videoCardPr;
            double processorPr = videoCardSum * 35 / 100.0;
            double processorSum = processorNum * processorPr;
            double ramPr = videoCardSum * 10 / 100.0;
            double ramSum = ramNum * ramPr;

            double amountExpenses = videoCardSum + processorSum + ramSum;
            if (videoCardNum > processorNum)
            {
                double discount = amountExpenses * 15 / 100.0;
                amountExpenses = amountExpenses - discount;
            }
            if (budget >= amountExpenses)
            {
                double moneyLeft = budget - amountExpenses;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = amountExpenses - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
