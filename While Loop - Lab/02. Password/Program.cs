﻿using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}