using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double preparationPrice = preparation * 1.20;
            double discount = percent / 100;

            double sum = pensPrice + markersPrice + preparationPrice;
            double finalSum = sum - (sum * percent / 100);
            Console.WriteLine(finalSum);
        }
    }
}
