using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int mounts = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double interestRate = (depositSum * percent / 100.0) / 12;
            double depositAmount = depositSum + mounts * interestRate;

            Console.WriteLine(depositAmount);
        }
    }
}
