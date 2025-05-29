namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            long facOne = GetFactorial(numberOne);
            long facTwo = GetFactorial(numberTwo);

            double result = (double)facOne/facTwo;
            Console.WriteLine($"{result:F2}");
        }
        static long GetFactorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
