using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int dollNum = int.Parse(Console.ReadLine());
            int bearNum = int.Parse(Console.ReadLine());
            int minionNum = int.Parse(Console.ReadLine());
            int truckNum = int.Parse(Console.ReadLine());

            double puzzlePr = 2.60;
            double dollPr = 3.00;
            double bearPr = 4.10;
            double minionPr = 8.20;
            double truckPr = 2.00;

            double toyNum = puzzleNum + dollNum + bearNum + minionNum + truckNum;

            double puzzleSum = puzzleNum * puzzlePr;
            double dollSum = dollNum * dollPr;
            double bearSum = bearNum * bearPr;
            double minionSum = minionNum * minionPr;
            double truckSum = truckNum * truckPr;

            double income = puzzleSum + dollSum + bearSum + minionSum + truckSum;
            if (toyNum >= 50)
            {
                income = (puzzleSum + dollSum + bearSum + minionSum + truckSum) -
                (25 / 100.0 * (puzzleSum + dollSum + bearSum + minionSum + truckSum));
            }
            double rent = income * 10 / 100.0;
            double freeMoney = income - rent;
            if (freeMoney >= tripPrice)
            {
                double moneyLeft = freeMoney - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeed = tripPrice - freeMoney;
                Console.WriteLine($"Not enough money! {moneyNeed:f2} lv needed.");
            }
        }
    }
}
