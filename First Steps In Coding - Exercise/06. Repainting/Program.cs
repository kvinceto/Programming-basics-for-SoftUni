using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylonAmount = (nylon + 2) * 1.50;
            double paintAmount = (paint + (paint * 10 / 100.0)) * 14.50;
            double thinnerAmount = thinner * 5;
            double bag = 0.40;
            double sumOfMaterials = nylonAmount + paintAmount + thinnerAmount + bag;
            double workersSum = (sumOfMaterials * 30 / 100) * workHours;

            double Sum = sumOfMaterials + workersSum;
            Console.WriteLine(Sum);
        }
    }
}
