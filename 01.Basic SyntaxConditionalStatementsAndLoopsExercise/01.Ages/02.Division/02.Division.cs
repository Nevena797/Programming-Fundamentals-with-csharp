namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divisor = 0;

            if (number % 10 == 0)
            {
                divisor = 10;
            }
            else if (number % 7 == 0)
            {
                divisor = 7;
            }
            else if (number % 6 == 0)
            {
                divisor = 6;
            }
            else if (number % 3 == 0)
            {
                divisor = 3;
            }
            else if (number % 2 == 0)
            {
                divisor = 2;
            }
        if (divisor != 0)
            {
                Console.WriteLine($"The number is divisible by {divisor}");
            }
            else 
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
