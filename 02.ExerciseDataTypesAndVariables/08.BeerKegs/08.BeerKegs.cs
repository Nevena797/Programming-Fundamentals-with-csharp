using System.Reflection;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keg = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string biggestModel = "";

            for (int i = 1; i <= keg; i++) 
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = (Math.PI * radius * radius * height);


                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
