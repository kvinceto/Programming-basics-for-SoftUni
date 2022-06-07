using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evaluationCurrent = 0;
            double evaluationTotal = 0;
            string name = string.Empty;
            double evaluationAverage = 0;
            double evaluationsAll = 0;
            int counterEvaluations = 0;

            string input = Console.ReadLine();
            while (input != "Finish")
            {
                name = input;
                for (int i = 1; i <= n; i++)
                {
                    evaluationCurrent = double.Parse(Console.ReadLine());
                    counterEvaluations++;
                    evaluationTotal += evaluationCurrent;
                }
                evaluationsAll += evaluationTotal;
                evaluationAverage = evaluationTotal / n;
                Console.WriteLine($"{name} - {evaluationAverage:f2}.");
                evaluationTotal = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(evaluationsAll / counterEvaluations):f2}.");
        }
    }
}