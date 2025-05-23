namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int n = 0; n < lines; n++)
            {
                int value = 1;
                for (int k = 0; k <= n; k++)
                {
                    Console.Write(value + " ");
                    value = value * (n - k) / (k + 1);
                }
                Console.WriteLine();
            }
        }
    }
}