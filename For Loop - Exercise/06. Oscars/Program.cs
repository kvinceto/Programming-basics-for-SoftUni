using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int peopleNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= peopleNum; i++)
            {
                string nameJury = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                points = points + ((nameJury.Length * juryPoints) / 2);
                if (points > 1250.5)
                {
                    break;
                }
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {(1250.5 - points):f1} more!");
            }
        }
    }
}