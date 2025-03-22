namespace _06.EvenAndOddSubtraction
{
    internal class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int SumEven = 0;
            int SumOdd = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    SumEven += number;
                }
                else
                {
                    SumOdd += number;
                }
            }
            int difference = SumEven - SumOdd;
            Console.WriteLine(difference);
        }
    }
}
