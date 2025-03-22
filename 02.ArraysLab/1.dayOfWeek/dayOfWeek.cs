namespace _1.dayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day >= 1 && day <= 7)
            {
                int index = day - 1;
                Console.WriteLine(days[index]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }
        }
    }
}
