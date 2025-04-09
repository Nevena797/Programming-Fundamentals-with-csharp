namespace _11._RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            

            Console.Write("Height: ");
            double heigtht = double.Parse(Console.ReadLine());


            double volume = (length * width * heigtht) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
