using System;
using System.Linq;

class P07_MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

        if (nums.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        int longestSeqNumber = nums[0];  
        int longestSeqLength = 1;        
        int currentSeqNumber = nums[0];  
        int currentSeqLength = 1;        


        for (int i = 1; i < nums.Length; i++)
        {

            if (nums[i] == nums[i - 1])
            {

                currentSeqLength++;
            }
            else
            {

                currentSeqNumber = nums[i];
                currentSeqLength = 1;
            }

            if (currentSeqLength > longestSeqLength)
            {
                longestSeqLength = currentSeqLength;
                longestSeqNumber = currentSeqNumber;
            }
        }


        for (int i = 0; i < longestSeqLength; i++)
        {
            Console.Write(longestSeqNumber);


            if (i < longestSeqLength - 1)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}