namespace _02.ArraysExercise
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[]pasengers = new int[wagons];
            int totalPassengers = 0;

            for (int i = 0; i < wagons; i++)
            {
                pasengers[i]= int.Parse(Console.ReadLine());
                totalPassengers += pasengers[i];
            }
            Console.WriteLine(string.Join(" ", pasengers));
            Console.WriteLine(totalPassengers);

        }
    }
}
