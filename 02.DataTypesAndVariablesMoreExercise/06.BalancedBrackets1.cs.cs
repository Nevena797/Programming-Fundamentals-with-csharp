namespace _06.BalancedBrackets1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int balance = 0;
            bool unbalanced = false;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    balance++;
                    if (balance > 1)
                    {
                        unbalanced = true;
                        break;
                    }
                }
                else if (input == ")")
                {
                    balance--;
                    if (balance < 0)
                    {
                        unbalanced = true;
                        break;
                    }
                }
            }

            if (balance == 0 && !unbalanced)
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
