int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

void PrintTriangle(int n)
{
    for (int i = 1; i <= n; i++)
    {
        PrintTriangleLine(i);
    }

    for (int i = n - 1; i >= 1; i--)
    {
        PrintTriangleLine(i);
    }
}

void PrintTriangleLine(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i} "); 
    }

    Console.WriteLine(); 
}
