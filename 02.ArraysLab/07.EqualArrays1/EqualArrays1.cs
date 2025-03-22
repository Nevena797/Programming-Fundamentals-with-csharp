using System;
using System.Linq;

namespace _07.EqualArrays1
{
    internal class EqualArrays1
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arrayTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int differenceIndex = IdenticalArray(arrayOne, arrayTwo);
            if (differenceIndex != -1)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differenceIndex} index");
            }
            else
            {
                int sum = arrayOne.Sum(); 
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }

        static int IdenticalArray(int[] arrayOne, int[] arrayTwo)
        {
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}