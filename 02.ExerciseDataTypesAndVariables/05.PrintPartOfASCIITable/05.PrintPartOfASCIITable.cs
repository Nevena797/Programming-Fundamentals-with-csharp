namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i != end)
                {
                    Console.Write((char)i + " ");
                }
                else 
                {
                    Console.Write((char)i);
                }
            }
        }
    }
}
