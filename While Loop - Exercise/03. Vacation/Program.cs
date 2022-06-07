using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TripCost = double.Parse(Console.ReadLine());
            double moneyWeHave = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int daysSpendCounter = 0;

            while (moneyWeHave < TripCost)
            {
                string action = Console.ReadLine();
                if (action == "save")
                {
                    double amount = double.Parse(Console.ReadLine());
                    daysCounter++;
                    daysSpendCounter = 0;
                    moneyWeHave += amount;
                }
                else if (action == "spend")
                {
                    double amount = double.Parse(Console.ReadLine());
                    daysCounter++;
                    daysSpendCounter++;
                    moneyWeHave -= amount;
                    if (moneyWeHave < 0)
                    {
                        moneyWeHave = 0;
                    }
                    if (daysSpendCounter == 5)
                    {
                        break;
                    }
                }
            }
            if (daysSpendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (moneyWeHave >= TripCost)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}