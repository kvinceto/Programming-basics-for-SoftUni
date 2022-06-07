using System;

namespace _05.Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothesPr = double.Parse(Console.ReadLine());

            double clothesAmount = people * clothesPr;
            if (people > 150)
            {
                double discount = clothesAmount * 10 / 100.0;
                clothesAmount = clothesAmount - discount;
            }
            double decor = budget * 10 / 100.0;

            double expenses = clothesAmount + decor;
            if (budget >= expenses)
            {
                double moneyLeft = budget - expenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = expenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
