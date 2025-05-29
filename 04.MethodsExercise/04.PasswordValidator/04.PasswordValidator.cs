using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ValidatePassword(input);
        }

        public static void ValidatePassword(string input)
        {
            bool isLengthValid = input.Length >= 6 && input.Length <= 10;
            bool isAlphaNumeric = true;
            int digitCount = 0;

            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    isAlphaNumeric = false;
                }
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            bool hasAtLeastTwoDigits = digitCount >= 2;

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthValid && isAlphaNumeric && hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
