namespace _06.EvenAndOddSubtraction1
{
    internal class EvenAndOddSubtraction1
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumEven = SumEvenNumbers(numbers);
            int sumOdd = SumOddNumbers(numbers);

            int difference = sumEven - sumOdd;
            Console.WriteLine(difference);

        }

        static int SumEvenNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        static int SumOddNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if ((num % 2) != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
