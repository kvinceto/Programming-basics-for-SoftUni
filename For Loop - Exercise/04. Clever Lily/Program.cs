using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfTheMashine = double.Parse(Console.ReadLine());
            double priceOfToy = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            double amountOfMoney = 0;
            double sum = 0;
            int moneyCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    amountOfMoney += 10;
                    sum = sum + amountOfMoney;
                    moneyCounter++;
                }
                else
                {
                    toyCounter++;
                }
            }
            double moneyFromToys = toyCounter * priceOfToy;
            double moneyLost = moneyCounter * 1;
            sum = sum + moneyFromToys - moneyLost;
            double diff = sum - priceOfTheMashine;
            if (sum >= priceOfTheMashine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(diff):f2}");
            }
        }
    }
}