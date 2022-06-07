using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = width * length * height;
            string input = Console.ReadLine();
            int oneBoxArea = 1 * 1 * 1;

            while (input != "Done")
            {
                int numberOfBoxes = int.Parse(input);
                area -= numberOfBoxes * oneBoxArea;
                if (area <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(area)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (area >= 0)
            {
                Console.WriteLine($"{area} Cubic meters left.");
            }
        }
    }
}