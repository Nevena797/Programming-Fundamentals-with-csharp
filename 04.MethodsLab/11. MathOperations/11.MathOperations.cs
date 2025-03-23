namespace _11._MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());


            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0.0;

            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber; 
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = (double)firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            return result;
        }
    }
}
