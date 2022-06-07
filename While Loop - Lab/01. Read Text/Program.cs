using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            while (data != "Stop")
            {
                Console.WriteLine(data);
                data = Console.ReadLine();
            }

        }
    }
}