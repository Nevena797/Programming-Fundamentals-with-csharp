using System;

namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal course = 1.31m;
            decimal dollars = pounds * course;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}
