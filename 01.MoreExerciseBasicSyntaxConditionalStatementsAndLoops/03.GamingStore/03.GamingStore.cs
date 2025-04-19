using System.Xml.Linq;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double prise = 0;
            double totalSpent = 0;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        prise = 39.99;
                        break;
                    case "CS: OG":
                        prise = 15.99;
                        break;
                    case "Zplinter Zell":
                        prise = 19.99;
                        break;
                    case "Honored 2":
                        prise = 59.99;
                        break;
                    case "RoverWatch":
                        prise = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        prise = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (currentBalance >= prise)
                {
                    currentBalance -= prise;
                    totalSpent += prise;
                    Console.WriteLine($"Bought {game}");
                }
                else
                {
                    Console.WriteLine($"Too Expensive");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}

