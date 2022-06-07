using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the data
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMin = int.Parse(Console.ReadLine());

            // varuables
            int examInMin = examHour * 60 + examMin;
            int arrivelInMin = arrivelHour * 60 + arrivelMin;
            int diference = examInMin - arrivelInMin;
            diference = Math.Abs(diference);
            int diferenceInHour = diference / 60;
            int diferenceInMin = diference % 60;

            // if
            if (examInMin < arrivelInMin)
            {
                Console.WriteLine("Late");
                if (diference < 60)
                {
                    Console.WriteLine($"{diferenceInMin} minutes after the start");
                }
                else
                {
                    if (diferenceInMin < 10)
                    {
                        Console.WriteLine($"{diferenceInHour}:0{diferenceInMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diferenceInHour}:{diferenceInMin} hours after the start");
                    }

                }
            }
            else if (arrivelInMin <= examInMin && (diference >= 0 && diference <= 30))
            {
                Console.WriteLine("On time");
                if (diference != 0)
                {
                    Console.WriteLine($"{diferenceInMin} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (diference < 60)
                {
                    Console.WriteLine($"{diferenceInMin} minutes before the start");
                }
                else
                {
                    if (diferenceInMin < 10)
                    {
                        Console.WriteLine($"{diferenceInHour}:0{diferenceInMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diferenceInHour}:{diferenceInMin} hours before the start");
                    }
                }
            }
        }
    }
}
