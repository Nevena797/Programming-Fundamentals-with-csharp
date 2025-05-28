namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            ChartersInRange(first, second);

            static void ChartersInRange(char first, char second)
            {
                if (first > second)
                {
                    char temp = first;
                    first= second;
                    second= temp;
                }
                for (char c = (char)(first + 1); c < second; c++) 
                {
                    Console.Write(c +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
