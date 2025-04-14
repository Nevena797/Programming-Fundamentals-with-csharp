using System.ComponentModel.DataAnnotations;

namespace _1.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (int.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (float.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out _))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
                command = Console.ReadLine();
            }
        }
    }
}
