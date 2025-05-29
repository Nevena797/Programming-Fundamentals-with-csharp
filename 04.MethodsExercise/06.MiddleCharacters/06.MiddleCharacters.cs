namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {
            int lenght = input.Length;
            int middleIndex = lenght / 2;

            if (lenght % 2 == 0)
            {
                Console.WriteLine(input.Substring(middleIndex - 1, 2));
            }
            else
            {
                Console.WriteLine(input.Substring(middleIndex, 1));
            }
        }
    }
}
