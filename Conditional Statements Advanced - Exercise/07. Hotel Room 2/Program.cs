using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPr = 0.00;
            double apartmentPr = 0.00;

            switch (month)
            {
                case "May":
                case "October":
                    studioPr = 50.00;
                    apartmentPr = 65.00;
                    break;
                case "June":
                case "September":
                    studioPr = 75.20;
                    apartmentPr = 68.70;
                    break;
                case "July":
                case "August":
                    studioPr = 76.00;
                    apartmentPr = 77.00;
                    break;
                default:
                    break;
            }
            switch (month)
            {
                case "May":
                case "October":
                    if (days > 7 && days <= 14)
                    {
                        studioPr = studioPr - studioPr * 5 / 100.0;
                    }
                    else if (days > 14)
                    {
                        studioPr = studioPr - studioPr * 30 / 100.0;
                    }
                    break;
                case "June":
                case "September":
                    if (days > 14)
                    {
                        studioPr = studioPr - studioPr * 20 / 100.0;
                    }
                    break;
                default:
                    break;
            }
            if (days > 14)
            {
                apartmentPr = apartmentPr - apartmentPr * 10 / 100.0;
            }
            double studioSum = days * studioPr;
            double apartmentSum = days * apartmentPr;

            Console.WriteLine($"Apartment: {apartmentSum:f2} lv.");
            Console.WriteLine($"Studio: {studioSum:f2} lv.");

        }
    }
}
