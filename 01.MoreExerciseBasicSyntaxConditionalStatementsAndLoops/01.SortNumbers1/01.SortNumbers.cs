//Create a program that receives three real numbers
//and sorts them in descending order.
//Print each number on a new line.

using System.ComponentModel.Design;

namespace _01.MoreExerciseBasicSyntaxConditionalStatementsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double[] numbers = new double[] { firstNumber, secondNumber, thirdNumber };

            double[] sorted = numbers.OrderByDescending(n => n).ToArray();

            foreach (double number in sorted)
            {
                Console.WriteLine(number);
            }
        }
    }
}
