namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < length; i++)
            {
                char currentChar = Console.ReadLine()[0];
                int asciiValue = (int)currentChar;
                int messageValue = asciiValue + step;
                char messageChar = (char)messageValue;
                message += messageChar;
            }

            Console.WriteLine(message);
        }
    }
}