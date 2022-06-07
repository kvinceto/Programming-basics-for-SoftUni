using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double volumeInLitres = volume / 1000.0;
            double space = volumeInLitres * (1 - (percent / 100.0));

            Console.WriteLine(space);
        }
    }
}
