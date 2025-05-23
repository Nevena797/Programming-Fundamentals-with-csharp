using System;

class Program
{
    static void Main()
    {
        int numRows = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRows; i++)
        {
            long[] row = new long[i + 1];
            row[0] = 1;

            for (int j = 1; j <= i; j++)
            {
                row[j] = row[j - 1] * (i - j + 1) / j;
            }

            foreach (long val in row)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}