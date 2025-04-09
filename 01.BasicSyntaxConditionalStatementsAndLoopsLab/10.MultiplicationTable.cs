namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result = i * number;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
