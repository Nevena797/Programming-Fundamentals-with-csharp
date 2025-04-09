namespace _11.MultiplicationTable2._0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());  
            int numberTwo = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
                numberTwo += 1;

            } while (numberOne <= 10 && numberTwo <= 10);
        }
    }
}
