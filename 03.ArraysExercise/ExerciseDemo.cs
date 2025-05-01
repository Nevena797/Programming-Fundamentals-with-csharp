/*
 * 12 86 69
 */

namespace exercisedemo
{
    internal class exercisedemo
    {
        static void main(string[] args)
        {
            int[] numbers = console.readline() // "12 86 69"
                .split(" ")// ["12 86 69"]
                .select(int.parse) // [12 86 69]
                .toarray();// [12 86 69]

            Console.WriteLine(string.Join("_", numbers));
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]); // indexoutofrangeexeption

            numbers[2] = 666;
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[numbers.Length - 1]);
            }

            int index = int.Parse(Console.ReadLine());
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;
            if (index >= firstIndex && index <= lastIndex)
            {
                Console.WriteLine(numbers[index]);
            }
            else 
            {
                Console.WriteLine($"Index out of Range");
            }

            if (index <0 || index > numbers.Length)
            {
                Console.WriteLine($"Index out of Range");
            }
            else
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
