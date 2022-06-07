using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sumGPA = 0;
            int counterFail = 0;

            while (grade <= 12)
            {
                double GPA = double.Parse(Console.ReadLine());
                if (GPA < 4)
                {
                    counterFail++;
                    if (counterFail > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                sumGPA += GPA;
                grade++;
            }
            double averageGPA = sumGPA / 12;
            if (counterFail < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGPA:f2}");
            }
        }
    }
}