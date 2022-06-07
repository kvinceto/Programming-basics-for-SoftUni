using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            string num;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = first; i <= last; i++)
            {
                num = i.ToString();
                for (int j = 0; j < num.Length; j++)
                {
                    int simbol = num[j];
                    if (j % 2 == 0)
                    {
                        oddSum += simbol;
                    }
                    else
                    {
                        evenSum += simbol;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
                oddSum = 0;
                evenSum = 0;
            }

        }
    }
}