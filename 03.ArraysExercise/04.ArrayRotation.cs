﻿using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            rotations = rotations % array.Length; // optional: optimize excessive rotations

            for (int i = 0;  i < rotations; i++)
            {
                int first = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = first;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
