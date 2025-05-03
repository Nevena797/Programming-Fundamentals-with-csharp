namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                               .Split(" ")
                               .Select(int.Parse)
                               .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = numbers.Take(i).Sum();
                int rightSum = numbers.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
