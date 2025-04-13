namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int input = int.Parse(Console.ReadLine());
            int currentLiters = 0;

            for (int i = 0; i < input; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (currentLiters + liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                currentLiters += liters;
            }

            Console.WriteLine(currentLiters);
        }
    }
}
