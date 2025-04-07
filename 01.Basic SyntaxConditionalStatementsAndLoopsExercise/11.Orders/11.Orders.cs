
    internal class Program
    {
        static void Main()
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double price = pricePerCapsule * (days * capsulesCount);
                total += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }

