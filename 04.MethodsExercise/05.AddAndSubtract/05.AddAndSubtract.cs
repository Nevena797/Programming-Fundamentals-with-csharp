using System.Runtime.ExceptionServices;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thurd = int.Parse(Console.ReadLine());
            int firstResult = Add(first, second);
            int secondResult = Substract(firstResult,thurd);
            Console.WriteLine(secondResult);


        }
        static int Add(int first, int second)
        {
            int firstResult = first + second;
            return (firstResult);
        }
        static int Substract(int firstResult, int thurd)
        {
            int secondResult = firstResult - thurd;
            return (secondResult);
        }
    }
}
