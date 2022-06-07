using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookWeAreLookingFor = Console.ReadLine();
            string bookName = Console.ReadLine();
            int bookCounter = 0;

            while (bookName != bookWeAreLookingFor)
            {
                bookName = Console.ReadLine();
                bookCounter++;
                if (bookName == "No More Books")
                {
                    break;
                }
            }
            if (bookName == bookWeAreLookingFor)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}