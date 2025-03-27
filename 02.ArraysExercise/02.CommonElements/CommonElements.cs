namespace _02.CommonElements
{
    internal class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            foreach (string secondElement in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string firstElement= firstArray[i];
                    if (firstElement == secondElement)
                    {
                        Console.Write(firstElement + " ");
                        break;
                    }
                }
            }
        }
    }
}
