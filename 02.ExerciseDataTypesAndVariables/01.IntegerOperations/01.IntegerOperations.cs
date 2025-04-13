namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberTree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            int result = ((numberOne + numberTwo) / numberTree) * numberFour;

            Console.WriteLine(result);
        }
    }
}
