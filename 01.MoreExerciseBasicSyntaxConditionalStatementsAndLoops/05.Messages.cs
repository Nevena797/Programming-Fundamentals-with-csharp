//Create a program, which emulates typing an SMS, following this guide
//Following the guide, 2 becomes 'a', 22 becomes 'b' and so on.
//A naive approach would be to just put
//all the possible combinations of digits in a giant switch statement.
//A cleverer approach would be to come up with a mathematical formula,
//which converts a number to its alphabet representation:
//Let's take the number 222 (c) for example. Our algorithm would look like this:
//Find the number of digits the number has, e.g. 222  3 digits
//Find the main digit of the number, e.g.  222  2
//Find the offset of the number.
//To do that, you can use the formula: (main digit - 2) *3
//If the main digit is 8 or 9, you need to add 1 to the offset,
//since the digits 7 and 9 have 4 letters each
//Finally, find the letter index (a = 0, c = 2, etc.).
//To do that, you can use the following formula: (offset + digit length - 1).
//After you've found the letter index,
//you can just add that to the ASCII code of the lowercase letter 'a' (97)



using System;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < count; i++)
            {
                string digits = Console.ReadLine();

                if (digits == "0")
                {
                    result += " ";
                    continue;
                }

                int mainDigit = int.Parse(digits[0].ToString());
                int length = digits.Length;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }


                if (mainDigit == 7 || mainDigit == 9)
                {
                    if (length > 4)
                        length = 4;
                }
                else
                {
                    if (length > 3)
                        length = 3;
                }

                int letterIndex = offset + length - 1;
                char letter = (char)(97 + letterIndex); 

                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}