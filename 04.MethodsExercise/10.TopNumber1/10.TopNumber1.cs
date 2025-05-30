namespace _10.TopNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] topNumbers = new int[n];
            int count = 0;

            for (int i= 0; i <= n; i++)
            {
                if (isTopNumber(i))
                {
                    topNumbers[count] = i;
                    count++;
                }
            }
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(topNumbers[i]);
            }
        }
        static bool isTopNumber(int number)
        {
            int sum = 0;
            bool hasOddDigits = false;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;

                if (digit % 2 != 0)
                {
                    hasOddDigits = true;
                }
                temp /= 10;
            }
            return sum % 8==0 && hasOddDigits;  
        }
    }
}
