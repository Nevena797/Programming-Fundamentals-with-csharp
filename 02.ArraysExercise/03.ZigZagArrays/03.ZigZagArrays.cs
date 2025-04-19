//Create a program that creates 2 arrays.
//You will be given an integer n. On the next n lines, you will get 2 integers.
//Form 2 new arrays in a zig-zag pattern as shown below.

namespace P03_ZigZagArrays
{
    using System;
    using System.Linq;

    class P03_ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();

                if (i % 2 != 0)   
                {
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }
                else  
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }
            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}