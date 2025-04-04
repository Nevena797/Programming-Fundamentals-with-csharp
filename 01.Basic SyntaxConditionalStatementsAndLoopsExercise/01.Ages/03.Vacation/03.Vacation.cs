using System.Diagnostics;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string TypeOfTheGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double singlePrice = 0;


            if (TypeOfTheGroup == "Students")
            {
                if (day == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 10.46;
                }
            }
            else if (TypeOfTheGroup == "Business")
            { 
                if (day == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 16;
                }
            }
            else if (TypeOfTheGroup == "Regular")
            {
                if (day == "Friday")
                {
                    singlePrice = 15;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 22.50;
                }
            }

            double totalPrice = singlePrice * countOfPeople;

            if ((TypeOfTheGroup == "Students") && (countOfPeople >= 30))
            {
                totalPrice *= 0.85;
            }
            else if ((TypeOfTheGroup == "Business") && (countOfPeople >= 100))
            {
                totalPrice = (countOfPeople - 10) * singlePrice;
            }
            else if ((TypeOfTheGroup == "Regular") && (countOfPeople >= 10 && countOfPeople <= 20)) 
            {
                totalPrice += 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");


        }
    }
}
