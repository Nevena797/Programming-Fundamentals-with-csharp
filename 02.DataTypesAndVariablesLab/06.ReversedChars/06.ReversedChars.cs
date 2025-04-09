using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            char[] chars = new char[3];


            for (int i = 0; i < 3; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }


            for (int i = 2; i >= 0; i--)
            {
                Console.Write(chars[i]);


                if (i != 0)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine(); 
        }
    }
}
