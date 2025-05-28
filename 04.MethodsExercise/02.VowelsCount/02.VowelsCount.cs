using System.Diagnostics.Metrics;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = VowelsCount(input);
            Console.WriteLine(count);
        }


        static int VowelsCount(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]); 
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    count++;
                }
            }
            return count;
        }
    }
}