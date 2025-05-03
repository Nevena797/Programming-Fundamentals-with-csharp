using System.Globalization;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input from comnsole,split by space,convert to Integers ans store in array
            int[] numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();
           //Flag to track if we found a position with equal sums on both sides
            bool found = false;
            
            // Loop throught all positions in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                //Initialize sums for elements to the left and right of current position
                int leftSum = 0;
                int rightSum = 0;

                //Calculate sum of all elements to the left of position i
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }

                //Calculate sum of all elements to the right of position i
                for (int right = i + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                // Check if sums are equal
                if (leftSum == rightSum)
                {
                    //Found a position where left sum equals right sum
                    Console.WriteLine(i);
                    found = true;
                    break; // Exit loop after finisching first match
                }
            }

            //If no positions with equal sums was found, print "no"
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}