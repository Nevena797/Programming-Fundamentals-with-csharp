int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        PrintTriangleLine(i + 1);
    }

    for (int i = 1; i < n; i++)
    {
        PrintTriangleLine(n - i);
    }
}

void PrintTriangleLine(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{i + 1} ");
    }
    Console.WriteLine();
}
