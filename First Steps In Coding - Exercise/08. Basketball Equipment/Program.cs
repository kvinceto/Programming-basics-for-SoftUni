using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double shoes = tax - (tax * 40 / 100.0);
            double clothes = shoes - (shoes * 20 / 100.0);
            double ball = clothes / 4;
            double acc = ball / 5;
            double sum = tax + shoes + clothes + ball + acc;
            Console.WriteLine(sum);
        }
    }
}
