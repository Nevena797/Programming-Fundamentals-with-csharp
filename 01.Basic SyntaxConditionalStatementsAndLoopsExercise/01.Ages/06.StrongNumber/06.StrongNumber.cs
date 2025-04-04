using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int original = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            int fact = 1;

            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }

            sum += fact;
            num /= 10;
        }

        if (sum == original)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
