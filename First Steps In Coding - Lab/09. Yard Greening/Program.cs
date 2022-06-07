using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = 7.61;
            double amount = area * price;
            double discount = amount * 0.18;
            double sum = amount - discount;

            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
