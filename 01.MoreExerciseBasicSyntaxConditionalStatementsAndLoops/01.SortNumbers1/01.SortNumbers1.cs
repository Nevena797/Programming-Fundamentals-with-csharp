namespace _01.SortNumbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b >= c ? b : c);
                Console.WriteLine(b < c ? b : c);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a >= c ? a : c);
                Console.WriteLine(a < c ? a : c);
            }
            else // c>=a && c>=b
            {
                Console.WriteLine(c);
                Console.WriteLine(a >= b ? a : b);
                Console.WriteLine(a < b ? a : b);
            }
        }
    }
}
