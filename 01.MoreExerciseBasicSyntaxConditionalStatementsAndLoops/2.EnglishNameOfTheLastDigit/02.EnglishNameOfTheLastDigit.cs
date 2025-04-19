namespace _2.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastNumber = Math.Abs(number % 10);

            if (lastNumber == 0)
            {
                Console.WriteLine("zero");
            }
            else if (lastNumber == 1)
            {
                Console.WriteLine("one");
            }
            else if (lastNumber == 2)
            {
                Console.WriteLine("two");
            }
            else if (lastNumber == 3)
            {
                Console.WriteLine("three");
            }
            else if (lastNumber == 4)
            {
                Console.WriteLine("four");
            }
            else if (lastNumber == 5)
            {
                Console.WriteLine("five");
            }
            else if (lastNumber == 6)
            {
                Console.WriteLine("six");
            }
            else if (lastNumber == 7)
            {
                Console.WriteLine("seven");
            }
            else if (lastNumber == 8)
            {
                Console.WriteLine("eight");
            }
            else 
            {
                Console.WriteLine("nine");
            }
        }
    }
}
