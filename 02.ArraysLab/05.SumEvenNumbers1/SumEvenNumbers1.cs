using System;
using System.Linq;

namespace _05.SumEvenNumbers1
{
    internal class SumEvenNumbers1
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = SumEvenNumbersFromArray(numbers);
            Console.WriteLine(sum);
        }
        static int SumEvenNumbersFromArray(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
