namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targets = 0;

            while (pokePower > distance)
            {
                if (pokePower == distance / 2)
                {
                    if (distance % exhaustionFactor == 0)
                    {
                        pokePower = distance / exhaustionFactor;
                    }
                    else
                    {
                        int currentPokePower = pokePower - distance;
                        targets++;
                    }
                }
                Console.WriteLine(pokePower);
                Console.WriteLine(targets);
            }
        }
    }
}
