﻿namespace _08.CondenseArrayToNumber
{
    internal class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] condesed = new int[array.Length - 1];
                for (int i = 0; i < array.Length -1; i++)
                {
                    condesed[i] = array[i] + array[i + 1];
                }
                array = condesed;
            }
            Console.WriteLine(array[0]);
        }
    }
}
