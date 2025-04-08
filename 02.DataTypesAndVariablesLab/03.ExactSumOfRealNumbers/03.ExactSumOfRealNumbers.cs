namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal sumOfNumbers = 0;

            for (int i = 1; i <= number; i++)
            {
               decimal currentNumber = decimal.Parse(Console.ReadLine());
                sumOfNumbers += currentNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
