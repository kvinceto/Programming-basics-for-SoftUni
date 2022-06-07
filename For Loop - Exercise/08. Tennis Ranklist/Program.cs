using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turnirs = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            double pointsWon = 0;
            int counterWin = 0;
            for (int i = 0; i < turnirs; i++)
            {
                string place = Console.ReadLine();
                switch (place)
                {
                    case "W":
                        pointsWon += 2000;
                        counterWin++;
                        break;
                    case "F":
                        pointsWon += 1200;
                        break;
                    case "SF":
                        pointsWon += 720;
                        break;
                    default:
                        break;
                }
            }
            double allPoints = points + pointsWon;
            double averagePoints = Math.Floor(pointsWon / turnirs);
            double percentWinings = ((double)counterWin / turnirs) * 100;
            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWinings:f2}%");
        }
    }
}