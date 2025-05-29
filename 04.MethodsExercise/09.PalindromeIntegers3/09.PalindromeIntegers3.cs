namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);
                Console.WriteLine(IsPalindrome(number));
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(int number)
        {
            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;
                number /= 10;
            }

            return original == reversed;
        }
    }
}
