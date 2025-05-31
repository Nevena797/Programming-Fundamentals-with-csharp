using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();  
            string inputValue = Console.ReadLine(); 

           
            ProcessData(inputType, inputValue);
        }

        static void ProcessData(string type, string value)
        {
            if (type == "int")
            {
                int number = int.Parse(value); 
                Console.WriteLine(number * 2);  
            }
            else if (type == "real")
            {
                double number = double.Parse(value); 
                double result = number * 1.5;  
                Console.WriteLine($"{result:F2}"); 
            }
            else if (type == "string")
            {
                Console.WriteLine($"${value}$"); 
            }
        }
    }
}
