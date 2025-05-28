namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo= int.Parse(Console.ReadLine());
            int numberTree = int.Parse(Console.ReadLine());
            int result = SmallestNumber(numberOne, numberTwo, numberTree);

            Console.WriteLine(result);

            static int SmallestNumber(int first, int second,int third)
            {
                int smallest = first;
                if (second < smallest)
                {
                    smallest = second;
                }
                if (third < smallest)
                {
                    smallest = third;
                }
                return smallest;
            }
        }
    }
}
