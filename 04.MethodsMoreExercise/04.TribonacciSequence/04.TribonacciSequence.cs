using System;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  
            TribonacciSequence(num);
        }

        static void TribonacciSequence(int num)
        {

            long first = 1;
            long second = 1;
            long third = 2;


            if (num >= 1) Console.Write(first);  
            if (num >= 2) Console.Write(" " + second);  
            if (num >= 3) Console.Write(" " + third);  


            for (int i = 4; i <= num; i++)
            {
                long next = first + second + third;  
                Console.Write(" " + next);  

                first = second;
                second = third;
                third = next;
            }

            Console.WriteLine();  
        }
    }
}
