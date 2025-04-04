namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string determination = "";

            if (ages >= 0 && ages <= 2)
            {
                determination = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                determination = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                determination = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                determination = "adult";
            }
            else
            {
                determination = "elder";
            }
            Console.WriteLine(determination);
        }
    }
}
