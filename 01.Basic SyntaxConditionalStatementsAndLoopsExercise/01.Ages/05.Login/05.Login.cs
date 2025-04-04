using System.Net.Http.Headers;

namespace _05.Login
{
    internal class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = "";


            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int counter = 0;
            while (counter < 4)
            {
                string input = Console.ReadLine();
                counter++;
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}