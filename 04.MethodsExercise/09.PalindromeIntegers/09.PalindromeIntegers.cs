namespace _09.PalindromeIntegers
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
            char[] reversed = number.ToCharArray();
            Array.Reverse(reversed);
            string reversedString=new string(reversed);

            return number == reversedString;
        }
    }
}
