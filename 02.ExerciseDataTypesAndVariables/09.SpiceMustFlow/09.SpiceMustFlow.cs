using System.ComponentModel.Design;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int dayMined = 0;
            int totalMined = 0;

            while (startYield >= 100)
            {
                totalMined += startYield - 26;
                startYield -= 10;
                dayMined++;
            }
            if (totalMined >= 26)
            {
                totalMined -= 26;
            }
            Console.WriteLine(dayMined);
            Console.WriteLine(totalMined);
        }
    }
}
