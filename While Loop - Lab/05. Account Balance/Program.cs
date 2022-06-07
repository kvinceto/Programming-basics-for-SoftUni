using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while (input != "NoMoreMoney")
            {
                double newInput = double.Parse(input);
                if (newInput < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += newInput;
                Console.WriteLine($"Increase: {newInput:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}