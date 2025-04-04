using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = 0;

        foreach (char digitChar in number)
        {
            int digit = digitChar - '0'; 
            int factorial = 1;

            for (int i = 1; i <= digit; i++)
            {
                factorial *= i;
            }

            sum += factorial;
        }

        if (sum == int.Parse(number))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
