namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            negativePositivZero(first, second, third);
        }

        static void negativePositivZero(int first, int second, int third)
        {

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("zero");  
            }
            else
            {

                int negativeCount = 0;

                if (first < 0) negativeCount++;
                if (second < 0) negativeCount++;
                if (third < 0) negativeCount++;


                if (negativeCount % 2 != 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {

                    Console.WriteLine("positive");
                }
            }
        }
    }
}
