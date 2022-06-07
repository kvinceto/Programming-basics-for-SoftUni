using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());

            double result = 0.0;
            string status = "";
            switch (simbol)
            {
                case '+':
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        status = "even";
                    }
                    else
                    {
                        status = "odd";
                    }
                    Console.WriteLine($"{n1} + {n2} = {result} - {status}");
                    break;
                case '-':
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        status = "even";
                    }
                    else
                    {
                        status = "odd";
                    }
                    Console.WriteLine($"{n1} - {n2} = {result} - {status}");
                    break;
                case '*':
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        status = "even";
                    }
                    else
                    {
                        status = "odd";
                    }
                    Console.WriteLine($"{n1} * {n2} = {result} - {status}");
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
