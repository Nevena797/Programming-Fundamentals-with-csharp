using System;

class Program
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine()); 
        int power = int.Parse(Console.ReadLine()); 

        double result = RaisePower(number, power);
        Console.WriteLine(result);
    }

    static double RaisePower(double number, int power)
    {
        double result = 1; 
        for (int i = 0; i < power; i++) 
        {
            result *= number; 
        }
        return result; 
    }
}
