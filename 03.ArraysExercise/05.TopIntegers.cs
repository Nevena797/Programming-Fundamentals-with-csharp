using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine() // Example: "1 4 3 2"
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();

            // count how many top integers 
            int topIntegersCount = 0;
            for (int i = 0; i < array.Length; i++) //27 19 42 2 13 45 48
            {
                bool isTopInteger = true;

                // Compare current number with all numbers to its right
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegersCount++;
                }
            }

            // Create a properly sized array for our result
            int[] topIntegers = new int[topIntegersCount];
            int index = 0;

            // Now populate the array
            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[index] = array[i];
                    index++;
                }
            }
            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}