using System;

internal class Program
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        double daysExact = years * 365.2422;
        long days = (long)daysExact;
        long hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
