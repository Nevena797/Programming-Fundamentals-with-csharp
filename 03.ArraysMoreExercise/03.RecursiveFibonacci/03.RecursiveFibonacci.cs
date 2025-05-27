//Fib(5)
///      \
//           Fib(4)      Fib(3)
//          /      \     /      \
//      Fib(3)   Fib(2) Fib(2)  Fib(1)
//     /     \      |      |       |
//  Fib(2) Fib(1)   1      1       1
//     |      |
//     1      1

//GetFibonacci(2) should return 1 and GetFibonacci(1) should return 1
//stop when Fib(0) and Fib(1) stop and return 1

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        private static long[] fib;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fib = new long[n +1];
            Console.WriteLine(GetFibonacci(n-1));
        }

        //--Recursion with Dynamic Programming(DP),Memorization

        public static long GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            if (fib[n] != 0)
            {
                return fib[n];
            }
            fib[n]= GetFibonacci(n-1) + GetFibonacci(n-2);
            return fib[n];
        }
    }
}


//// without stop
//public static long Fib(int n)
//{
//    return Fib(n - 1) + Fib(n - 2);  // → STACK OVERFLOW!
//}