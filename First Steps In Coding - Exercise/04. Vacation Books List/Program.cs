using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesAmount = int.Parse(Console.ReadLine());
            int pagesPerHouer = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double pagesPerDay = (pagesAmount / pagesPerHouer) / days;
            Console.WriteLine(pagesPerDay);
        }
    }
}
