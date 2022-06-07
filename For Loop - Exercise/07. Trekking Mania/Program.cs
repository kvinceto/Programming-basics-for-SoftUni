using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int counterMusala = 0;
            int counterMonblan = 0;
            int counterKilimandjaro = 0;
            int counterK2 = 0;
            int counterEverest = 0;
            int couterPeople = 0;
            for (int i = 0; i < groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                couterPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    counterMusala += peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup <= 12)
                {
                    counterMonblan += peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    counterKilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    counterK2 += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    counterEverest += peopleInGroup;
                }
            }
            double p1 = (double)counterMusala / couterPeople * 100;
            double p2 = (double)counterMonblan / couterPeople * 100;
            double p3 = (double)counterKilimandjaro / couterPeople * 100;
            double p4 = (double)counterK2 / couterPeople * 100;
            double p5 = (double)counterEverest / couterPeople * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}