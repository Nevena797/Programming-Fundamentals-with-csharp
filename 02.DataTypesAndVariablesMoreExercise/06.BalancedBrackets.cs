namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
 

            int countOpenBrackets = 0;
            int countCloseBrackets = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    countOpenBrackets++;
                }
                else if (input == ")")
                {
                    countCloseBrackets++;
                    if (countCloseBrackets > countOpenBrackets)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (countOpenBrackets == countCloseBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
