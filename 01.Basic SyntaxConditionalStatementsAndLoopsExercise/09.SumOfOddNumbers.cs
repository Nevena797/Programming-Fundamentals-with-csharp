namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int oddNumber = 1;

            while (count < n)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
                count++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}