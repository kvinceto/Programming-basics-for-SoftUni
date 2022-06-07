using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNum = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rosesPr = 5.00;
            double dahliasPr = 3.80;
            double tulipsPr = 2.80;
            double narcissusPr = 3.00;
            double gladiolusPr = 2.50;

            double flowersSum = 0.00;

            if (flowerType == "Roses")
            {
                if (flowerNum > 80)
                {
                    flowersSum = (flowerNum * rosesPr) - (flowerNum * rosesPr * 10 / 100.0);
                }
                else
                {
                    flowersSum = flowerNum * rosesPr;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowerNum > 90)
                {
                    flowersSum = (flowerNum * dahliasPr) - (flowerNum * dahliasPr * 15 / 100.0);
                }
                else
                {
                    flowersSum = flowerNum * dahliasPr;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerNum > 80)
                {
                    flowersSum = (flowerNum * tulipsPr) - (flowerNum * tulipsPr * 15 / 100.0);
                }
                else
                {
                    flowersSum = flowerNum * tulipsPr;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerNum < 120)
                {
                    flowersSum = (flowerNum * narcissusPr) + (flowerNum * narcissusPr * 15 / 100.0);
                }
                else
                {
                    flowersSum = flowerNum * narcissusPr;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerNum < 80)
                {
                    flowersSum = (flowerNum * gladiolusPr) + (flowerNum * gladiolusPr * 20 / 100.0);
                }
                else
                {
                    flowersSum = flowerNum * gladiolusPr;
                }
            }

            double diference = budget - flowersSum;
            if (diference < 0)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(diference):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNum} {flowerType} and {diference:f2} leva left.");
            }
        }
    }
}
