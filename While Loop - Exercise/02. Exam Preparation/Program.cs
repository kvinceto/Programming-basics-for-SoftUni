using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string nameOfTheCurentTask = Console.ReadLine();
            int badGradeCounter = 0;
            int taskCounter = 0;
            double gradeSum = 0;
            int gradeCounter = 0;
            string lastTask = String.Empty;

            while (nameOfTheCurentTask != "Enough")
            {
                lastTask = nameOfTheCurentTask;
                taskCounter++;
                double curentGrade = double.Parse(Console.ReadLine());
                gradeCounter++;
                gradeSum += curentGrade;
                if (curentGrade <= 4)
                {
                    badGradeCounter++;
                }
                if (badGradeCounter >= badGrades)
                {
                    break;
                }
                nameOfTheCurentTask = Console.ReadLine();
            }
            if (nameOfTheCurentTask == "Enough")
            {
                Console.WriteLine($"Average score: {gradeSum / gradeCounter:f2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            if (badGradeCounter >= badGrades)
            {
                Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
            }

        }
    }
}