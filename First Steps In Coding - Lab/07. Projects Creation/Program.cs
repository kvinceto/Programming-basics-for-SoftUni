using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = 3;
            int hours = a * b;
            Console.WriteLine($"The architect {fullName} will need {hours} hours to complete {a} project/s.");
        }
    }
}
