namespace _06.EqualSum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                 .ToArray();

            int totalSum = arr.Sum();
            int leftSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = totalSum - leftSum - arr[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += arr[i];
            }
            Console.WriteLine("no");
        }
    }
}
