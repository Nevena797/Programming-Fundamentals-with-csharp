namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thurdChar = char.Parse(Console.ReadLine());

            string newString = $"{firstChar}{secondChar}{thurdChar}";
            Console.WriteLine(newString);

        }
    }
}
