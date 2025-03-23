double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

Console.WriteLine(CalculateRectangleArea(width, height));

double CalculateRectangleArea(double width, double height)
{
    return width * height;
}