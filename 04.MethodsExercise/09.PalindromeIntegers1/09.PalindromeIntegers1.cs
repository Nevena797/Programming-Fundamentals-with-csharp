namespace _09.PalindromeIntegers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                Console.WriteLine(IsPalindrome(command));
                command = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string number)
        {
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
