using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());


            int[] ladyBugs = new int[fieldSize];


            int[] initialIndexes = Console.ReadLine()
                                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    ladyBugs[index] = 1;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int flyLength = int.Parse(commandParts[2]);

                if (index < 0 || index >= fieldSize || ladyBugs[index] == 0)
                {
                    continue;
                }


                if (flyLength < 0)
                {
                    flyLength = Math.Abs(flyLength);
                    direction = direction == "right" ? "left" : "right";
                }


                ladyBugs[index] = 0;
                int currentIndex = index;

                while (true)
                {
                    if (direction == "right")
                    {
                        currentIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        currentIndex -= flyLength;
                    }


                    if (currentIndex < 0 || currentIndex >= fieldSize)
                    {
                        break;
                    }


                    if (ladyBugs[currentIndex] == 0)
                    {
                        ladyBugs[currentIndex] = 1;
                        break;
                    }

                }
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
