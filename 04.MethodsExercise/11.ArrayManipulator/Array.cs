using System;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "end")
            {
                string[] tokens = commandLine.Split();
                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, index);
                    }
                }
                else if (command == "max" || command == "min")
                {
                    string type = tokens[1];
                    PrintMinOrMax(arr, command, type);
                }
                else if (command == "first" || command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string parity = tokens[2];

                    if (count > arr.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        PrintFirstOrLast(arr, count, parity, command);
                    }
                }
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        static int[] Exchange(int[] array, int index)
        {
            int[] result = new int[array.Length];
            int pos = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                result[pos++] = array[i];
            }
            for (int i = 0; i <= index; i++)
            {
                result[pos++] = array[i];
            }

            return result;
        }

        static void PrintMinOrMax(int[] array, string operation, string type)
        {
            int parity = type == "even" ? 0 : 1;
            int index = -1;
            int bestValue = (operation == "max") ? int.MinValue : int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == parity)
                {
                    if ((operation == "max" && array[i] >= bestValue) ||
                        (operation == "min" && array[i] <= bestValue))
                    {
                        bestValue = array[i];
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void PrintFirstOrLast(int[] array, int count, string parityType, string direction)
        {
            int parity = parityType == "even" ? 0 : 1;
            int[] result = new int[count];
            int found = 0;

            if (direction == "first")
            {
                for (int i = 0; i < array.Length && found < count; i++)
                {
                    if (array[i] % 2 == parity)
                    {
                        result[found++] = array[i];
                    }
                }
            }
            else // last
            {
                for (int i = array.Length - 1; i >= 0 && found < count; i--)
                {
                    if (array[i] % 2 == parity)
                    {
                        result[found++] = array[i];
                    }
                }

                Array.Reverse(result, 0, found);
            }

            Console.Write("[");
            for (int i = 0; i < found; i++)
            {
                Console.Write(result[i]);
                if (i < found - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}