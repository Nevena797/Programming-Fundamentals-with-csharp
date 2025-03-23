string command = Console.ReadLine();
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

switch (command.ToLower())
{
    case "add":
        Add(numberOne, numberTwo);
        break;
    case "subtract":
        Subtract(numberOne, numberTwo);
        break;
    case "multiply":
        Multiply(numberOne, numberTwo);
        break;
    case "divide":
        Divide(numberOne, numberTwo);
        break;
    default:
        Console.WriteLine("Invalid command. Please try again.");
        break;
}

void Add(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne + numberTwo);
}

void Subtract(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne - numberTwo);
}

void Multiply(int numberOne, int numberTwo)
{
    Console.WriteLine(numberOne * numberTwo);
}

void Divide(int numberOne, int numberTwo)
{
    if (numberTwo == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        Console.WriteLine((double)numberOne / numberTwo);
    }
}
