namespace _06._CalculateRectangleArea02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double GetRectanglkeArea(double width,double height) 
            {
                return width * height; 
            }
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectanglkeArea(width,height);
            Console.WriteLine(area);
        }
    }
}
