namespace _04.ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");

            Array.Reverse(strings);

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
