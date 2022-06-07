using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string quality = Console.ReadLine();

            double roonForOnePr = 18.00;
            double apartmentPr = 25.00;
            double presApartPr = 35.00;
            double costOfVacation = 0.0;
            int nights = days - 1;

            if (roomType == "room for one person")
            {
                costOfVacation = nights * roonForOnePr;
            }
            else if (roomType == "apartment")
            {
                costOfVacation = nights * apartmentPr;
                if (days < 10)
                {
                    costOfVacation = costOfVacation - costOfVacation * 30 / 100.0;
                }
                else if (days >= 10 && days <= 15)
                {
                    costOfVacation = costOfVacation - costOfVacation * 35 / 100.0;
                }
                else if (days > 15)
                {
                    costOfVacation = costOfVacation - costOfVacation * 50 / 100.0;
                }
            }
            else if (roomType == "president apartment")
            {
                costOfVacation = nights * presApartPr;
                if (days < 10)
                {
                    costOfVacation = costOfVacation - costOfVacation * 10 / 100.0;
                }
                else if (days >= 10 && days <= 15)
                {
                    costOfVacation = costOfVacation - costOfVacation * 15 / 100.0;
                }
                else if (days > 15)
                {
                    costOfVacation = costOfVacation - costOfVacation * 20 / 100.0;
                }
            }
            if (quality == "positive")
            {
                costOfVacation = costOfVacation + costOfVacation * 25 / 100.0;
            }
            else if (quality == "negative")
            {
                costOfVacation = costOfVacation - costOfVacation * 10 / 100.0;
            }
            Console.WriteLine($"{costOfVacation:f2}");


        }
    }
}
