using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffeePr = 0;
            double waterPr = 0;
            double beerPr = 0;
            double sweetsPr = 0;
            double peanutsPr = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    coffeePr = 0.50;
                }
                else if (product == "water")
                {
                    waterPr = 0.80;
                }
                else if (product == "beer")
                {
                    beerPr = 1.20;
                }
                else if (product == "sweets")
                {
                    sweetsPr = 1.45;
                }
                else if (product == "peanuts")
                {
                    peanutsPr = 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    coffeePr = 0.40;
                }
                else if (product == "water")
                {
                    waterPr = 0.70;
                }
                else if (product == "beer")
                {
                    beerPr = 1.15;
                }
                else if (product == "sweets")
                {
                    sweetsPr = 1.30;
                }
                else if (product == "peanuts")
                {
                    peanutsPr = 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    coffeePr = 0.45;
                }
                else if (product == "water")
                {
                    waterPr = 0.70;
                }
                else if (product == "beer")
                {
                    beerPr = 1.10;
                }
                else if (product == "sweets")
                {
                    sweetsPr = 1.35;
                }
                else if (product == "peanuts")
                {
                    peanutsPr = 1.55;
                }
            }

            double coffeeSum = quantity * coffeePr;
            double waterSum = quantity * waterPr;
            double beerSum = quantity * beerPr;
            double sweetsSum = quantity * sweetsPr;
            double peanutsSum = quantity * peanutsPr;

            if (product == "coffee")
            {
                Console.WriteLine($"{coffeeSum}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{waterSum}");
            }
            else if (product == "beer")
            {
                Console.WriteLine($"{beerSum}");
            }
            else if (product == "sweets")
            {
                Console.WriteLine($"{sweetsSum}");
            }
            else if (product == "peanuts")
            {
                Console.WriteLine($"{peanutsSum}");
            }
        }
    }
}
