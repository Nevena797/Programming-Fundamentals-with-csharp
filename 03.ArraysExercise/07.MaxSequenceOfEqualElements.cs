using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int maxLength = 1;
            int currentLength = 1;
            int startIndex = 0;
            int bestStartIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    startIndex = i;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestStartIndex = startIndex;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(numbers[bestStartIndex] + " ");
            }
        }
    }
}