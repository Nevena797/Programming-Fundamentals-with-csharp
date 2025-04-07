namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double singlePriceSaber = double.Parse(Console.ReadLine());
            double singlePriceRobe = double.Parse(Console.ReadLine());
            double singlePriceBelt = double.Parse(Console.ReadLine());

            double percent = countOfStudents * 10.0 / 100;
            double allSabers = countOfStudents + Math.Ceiling(percent);
            double totalPriceSaber = allSabers * singlePriceSaber;

            double totalPriceRobe = countOfStudents * singlePriceRobe;
            double beltsCount = countOfStudents  - Math.Ceiling((double)(countOfStudents/ 6)); 
            double totalPriceBelt = beltsCount * singlePriceBelt;

            double totalPrice = totalPriceSaber + totalPriceRobe + totalPriceBelt;

            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - amountOfMoney):F2}lv more.");
            }

        }
    }
}
