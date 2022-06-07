using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double expenses = 0.0;
            string typeVacation = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            if (season == "summer")
            {
                if (destination == "Bulgaria")
                {
                    expenses = budget * 30 / 100.0;
                }
                else if (destination == "Balkans")
                {
                    expenses = budget * 40 / 100.0;
                }
                else if (destination == "Europe")
                {
                    expenses = budget * 90 / 100.0;
                }
            }
            else
            {
                if (destination == "Bulgaria")
                {
                    expenses = budget * 70 / 100.0;
                }
                else if (destination == "Balkans")
                {
                    expenses = budget * 80 / 100.0;
                }
                else if (destination == "Europe")
                {
                    expenses = budget * 90 / 100.0;
                }
            }
            if (season == "summer")
            {
                typeVacation = "Camp";
            }
            else
            {
                typeVacation = "Hotel";
            }
            if (destination == "Europe")
            {
                typeVacation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {expenses:f2}");

        }
    }
}
