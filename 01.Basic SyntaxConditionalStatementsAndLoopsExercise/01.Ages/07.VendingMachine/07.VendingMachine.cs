using System;

class Program
{
    static void Main()
    {
        string command;
        double change = 0;


        while ((command = Console.ReadLine()) != "Start")
        {
            double coin = double.Parse(command);

            if (coin == 0.1 ||
                coin == 0.2 ||
                coin == 0.5 ||
                coin == 1.0 ||
                coin == 2.0)
            {
                change += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }
        }


        double nutsPrice = 2.0;
        double waterPrice = 0.7;
        double crispsPrice = 1.5;
        double sodaPrice = 0.8;
        double cokePrice = 1.0;

        string input;


        while ((input = Console.ReadLine()) != "End")
        {
            switch (input)
            {
                case "Nuts":
                    if (change >= nutsPrice)
                    {
                        Console.WriteLine("Purchased nuts");
                        change -= nutsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Water":
                    if (change >= waterPrice)
                    {
                        Console.WriteLine("Purchased water");
                        change -= waterPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Crisps":
                    if (change >= crispsPrice)
                    {
                        Console.WriteLine("Purchased crisps");
                        change -= crispsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Soda":
                    if (change >= sodaPrice)
                    {
                        Console.WriteLine("Purchased soda");
                        change -= sodaPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Coke":
                    if (change >= cokePrice)
                    {
                        Console.WriteLine("Purchased coke");
                        change -= cokePrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
        }

        Console.WriteLine($"Change: {change:F2}");
    }
}
