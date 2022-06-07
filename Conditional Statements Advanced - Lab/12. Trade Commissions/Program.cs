using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comision = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comision = sales * 5 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comision = sales * 7 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comision = sales * 8 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comision = sales * 12 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comision = sales * 4.5 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comision = sales * 7.5 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comision = sales * 10 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comision = sales * 13 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comision = sales * 5.5 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comision = sales * 8 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comision = sales * 12 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comision = sales * 14.5 / 100.0;
                        Console.WriteLine($"{comision:f2}");
                    }
                    else if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
