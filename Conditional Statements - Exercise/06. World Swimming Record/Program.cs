using System;

namespace _06.World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double secNeeded = meters * timeInSec;
            double lostTime = Math.Floor((meters / 15)) * 12.5;
            double secSum = secNeeded + lostTime;
            double secDifference = 0;

            if (secSum < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secSum:f2} seconds.");
            }
            else
            {
                secDifference = secSum - record;
                Console.WriteLine($"No, he failed! He was {secDifference:f2} seconds slower.");
            }
        }
    }
}
