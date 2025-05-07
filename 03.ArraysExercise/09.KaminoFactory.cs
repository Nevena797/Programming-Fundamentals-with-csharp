using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string input;

            int[] bestDNA = new int[dnaLength];
            int bestSum = 0;
            int bestCount = 0;
            int bestStartIndex = dnaLength;
            int bestSample = 0;
            int sampleNumber = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] currentDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleNumber++;

                int maxCount = 0;
                int startIndex = 0;
                int currentCount = 0;
                int tempStart = 0;

                for (int i = 0; i < dnaLength; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (currentCount == 0)
                        {
                            tempStart = i;
                        }
                        currentCount++;

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            startIndex = tempStart;
                        }
                    }
                    else
                    {
                        currentCount = 0;
                    }
                }

                int currentSum = currentDNA.Sum();

                bool isBetterDNA = false;

                if (maxCount > bestCount)
                {
                    isBetterDNA = true;
                }
                else if (maxCount == bestCount)
                {
                    if (startIndex < bestStartIndex)
                    {
                        isBetterDNA = true;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isBetterDNA = true;
                        }
                    }
                }

                if (isBetterDNA)
                {
                    bestDNA = currentDNA;
                    bestCount = maxCount;
                    bestStartIndex = startIndex;
                    bestSum = currentSum;
                    bestSample = sampleNumber;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
