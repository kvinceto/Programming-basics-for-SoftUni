using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int freeSeats;
            string type = string.Empty;
            int counterTickets = 0;
            int counterTicketsCurent = 0;
            int counterStudent = 0;
            int counterStandart = 0;
            int counterKid = 0;

            while (name != "Finish")
            {
                freeSeats = int.Parse(Console.ReadLine());
                type = Console.ReadLine();
                while (type != "End")
                {
                    if (type == "student")
                    {
                        counterStudent++;
                    }
                    else if (type == "standard")
                    {
                        counterStandart++;
                    }
                    else if (type == "kid")
                    {
                        counterKid++;
                    }
                    counterTicketsCurent++;
                    if (counterTicketsCurent >= freeSeats)
                    {
                        break;
                    }
                    type = Console.ReadLine();
                }
                double p = (double)counterTicketsCurent / freeSeats * 100;
                Console.WriteLine($"{name} - {p:f2}% full.");
                counterTickets += counterTicketsCurent;
                counterTicketsCurent = 0;
                name = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {counterTickets}");
            Console.WriteLine($"{((double)counterStudent / counterTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{((double)counterStandart / counterTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{((double)counterKid / counterTickets * 100):f2}% kids tickets.");
        }
    }
}
