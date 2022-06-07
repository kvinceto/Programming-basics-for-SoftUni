using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double shipPr = 0.00;

            switch (season)
            {
                case "Spring":
                    shipPr = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipPr = 4200;
                    break;
                case "Winter":
                    shipPr = 2600;
                    break;
                default:
                    break;
            }

            if (people <= 6)
            {
                shipPr = shipPr - shipPr * 10 / 100.0;
            }
            else if (people > 6 && people <= 11)
            {
                shipPr = shipPr - shipPr * 15 / 100.0;
            }
            else if (people > 11)
            {
                shipPr = shipPr - shipPr * 25 / 100.0;
            }
            if (people % 2 == 0)
            {
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                    case "Winter":
                        shipPr = shipPr - shipPr * 5 / 100.0;
                        break;
                    default:
                        break;
                }
            }
            double diference = budget - shipPr;

            if (diference >= 0)
            {
                Console.WriteLine($"Yes! You have {diference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(diference):f2} leva.");
            }
        }
    }
}