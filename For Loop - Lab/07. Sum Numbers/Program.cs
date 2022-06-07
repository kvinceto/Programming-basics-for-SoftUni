using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                int newNum = num;
                sum = newNum + sum;
            }
            Console.WriteLine(sum);
        }
    }
}