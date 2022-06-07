using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int areaOfCake = wight * hight;
            int onePieceArea = 1 * 1;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                areaOfCake -= pieces * onePieceArea;
                if (areaOfCake <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(areaOfCake) / onePieceArea} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (areaOfCake >= 0)
            {
                Console.WriteLine($"{areaOfCake / onePieceArea} pieces are left.");
            }
        }
    }
}