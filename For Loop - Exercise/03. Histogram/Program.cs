using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                }
                else if (num >= 200 && num < 400)
                {
                    counter2++;
                }
                else if (num >= 400 && num < 600)
                {
                    counter3++;
                }
                else if (num >= 600 && num < 800)
                {
                    counter4++;
                }
                else if (num >= 800)
                {
                    counter5++;
                }
            }

            double p1 = counter1 / (n * 1.0) * 100;
            double p2 = counter2 / (n * 1.0) * 100;
            double p3 = counter3 / (n * 1.0) * 100;
            double p4 = counter4 / (n * 1.0) * 100;
            double p5 = counter5 / (n * 1.0) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}