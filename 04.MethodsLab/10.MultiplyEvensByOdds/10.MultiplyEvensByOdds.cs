using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int result = GetMultipleOfEvenAndOdds(Math.Abs(number)); // Handle negative numbers with Math.Abs
        Console.WriteLine(result);
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        int sumEven = GetSumOfEvenDigits(number);
        int sumOdd = GetSumOfOddDigits(number);
        return sumEven * sumOdd;
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0) // Check if the digit is even
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0) // Check if the digit is odd
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
}
