using System.Diagnostics.Metrics;

namespace _04.SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numberLines; i++)
            {
                char letter = Console.ReadLine()[0];
                int numberChar = (int)letter;
                totalSum += numberChar;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
