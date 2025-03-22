namespace printNumbersInReverseOrder2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers)); 
        }
    }
}
