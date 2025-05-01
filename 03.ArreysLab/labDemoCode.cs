//namespace _01.labdemocode
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5];
//            Console.WriteLine(numbers.Length);
//        }

//    }
//}

//namespace _01.labdemocode
//{
//    internal class Program
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5] { 1, 13, -5, 10, 100 };
//            Console.Writeine(numbers.length);
//        }

//    }
//}

//namespace _01.labdemocode
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] numbers = new int[] { 1, 13, -5, 10, 100, 107 };
//            console.writeline(numbers.length);
//        }

//    }
//}

//namespace _01.labdemocode
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] numbers = new int[] { 1, 13, -5, 10, 100, 107 };
//            console.writeline(numbers[2]);

//            numbers[2] = 44;
//            console.writeline(numbers[2]);
//        }

//    }
//}

//namespace _01.labdemocode
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] numbers = new int[] { 1, 13, -5, 10, 100, 107 };
//            console.writeline(numbers[2]);

//            numbers[2] = 44;
//            console.writeline(numbers[2]);
//        }

//    }
//}

//namespace _01.labdemocode
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] numbers = new int[] { 1, 13, -5, 10, 100, 107 };
//            console.writeline(numbers[2]);

//            numbers[2] = 44;
//            console.writeline(numbers[^2]);
//        }

//    }
//}

//using static system.runtime.interopservices.javascript.jstype;
//static void main(string[] args)
//{
//    int[] numbers = new int[10];

//    for (int i = 0; i < numbers.length; i++)
//    {
//        numbers[i] = i;
//    }
//    console.writeline(numbers);
//}

//using static system.runtime.interopservices.javascript.jstype;
//static void main(string[] args)
//{
//    int[] numbers = new int[10];

//    for (int i = 1; i < numbers.length; i++)
//    {
//        numbers[i - 1] = i;
//    }
//    numbers[2] = numbers[2] + numbers[1];
//    console.writeline(numbers);
//}


//internal class program
//{
//    static void main(string[] args)
//    {
//        int[] numbers = new int[10];

//        for (int i = 0; i < numbers.length; i++)
//        {
//            numbers[i] = i;
//        }
//        console.writeline(numbers[numbers.length - 2]);
////}

//internal class program
//    {
//        static void main(string[] args)
//        {
//            int count = int.parse(console.readline());
//            int[] numbers = new int[count];

//            for (int i = 0; i < numbers.length; i++)
//            {
//                int number = int.parse(console.readline());
//                numbers[i] = number;
//            }
//        }
//    }



//    internal class program
//        {
//            static void main(string[] args)
//            {
//                int count = int.parse(console.readline());
//                int[] numbers = new int[count];

//                for (int i = 0; i < numbers.length; i++)
//                {
//                    int number = int.parse(console.readline());
//                    numbers[i] = number;
//                }

//                for (int i = 0; i < numbers.length; i++)
//                {
//                    console.write($"{numbers[i]}"); // int32
//                }
//            }


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string values = Console.ReadLine();
//        string[] items = values.Split(',');
//        int[] numbers = new int[items.Length];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = int.Parse(items[i]);
//        }
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string values = Console.ReadLine();
//        string[] items = values.Split(); // Defoult
//        int[] numbers = new int[items.Length];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = int.Parse(items[i]);
//        }
//    }
//}


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string values = Console.ReadLine();
//        string[] items = values.Split(); // Defoult
//        int[] numbers = new int[items.Length];

//        for (int i = 0; i < items.Length; i++)
//        {
//            numbers[i] = int.Parse(items[i]);
//        }
//    }
//}

//string values = Console.ReadLine();
//string[] items = values.Split();
//int[] arr = new int[items.Length];
//for (int i = 0; i < items.Length; i++)
//    arr[i] = int.Parse(items[i]);


//var inputLine = Console.ReadLine();
//string[] items = inputLine.Split(", ");
//int[] arr = items.Select(int.Parse).ToArray();

//using System.Linq;

//int[] arr = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToArray(); // int,double,float

//int[] arr = Console.ReadLine().Split(", ");  // strings


////printing arrayes on the Console


//for (int i = 0; i < items.Length; i++)
//{
//    numbers[i] = int.Parse(items[i]);
//}


//string[] arr = { "one", "two" };
////== new string [2] {"one","two"};
////Process all array elements

//for (int index = 0; index < arr.Length; index++) 
//{
//    //Print each element on a separate line
//    Console.WriteLine("arr[{0}] = {1}",index, arr[index]);
//}

//using System.Globalization;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 2, 3, 4 };

//        for (int i = 0; i< numbers.Length; i++)
//        {
//            if (i == numbers.Length -1)
//            {
//                Console.Write($"{numbers[i]}");
//            }
//            Console.Write($"{numbers[i]}, ");
//        }
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 2, 3, 4 };
//        string result = string.Join(", ", numbers);
//        Console.WriteLine(result);
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] words = { "I", "am", "very", "nice", "person" };
//        string result = string.Join("! ", words);
//        Console.WriteLine(result);
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] words = { "I", "am", "very", "nice", "person" };
//        Console.WriteLine(string.Join("|", words));

//    }
//}


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(string.Join("&", new string[] { "I", "am", "very", "nice", "person" }));

//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "I", "am", "very", "nice", "person" };

//        Console.WriteLine(string.Join("\r\n", names)); //new line

//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "I", "am", "very", "nice", "person" };

//        Console.WriteLine(string.Join("\t", names)); //Tabulation between

//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "I", "am", "very", "nice", "person" };

//        Console.Write(string.Join("\t", names)); 
//        Console.WriteLine(!);//WILL BE ON SAME LINE

//    }
//}


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "I", "am", "very", "nice", "person", "and", "I","am","very", "happy" };

//        foreach (string name in names)
//        {
//            Console.WriteLine(name); // can not change, read only
//        }

//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {


//        int[] numbers = { 1, 2, 3, 4, 5 };

//        foreach (int number in numbers)
//        {
//            Console.WriteLine(number); // can not change, read only
//        }

//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = new int[10];
//        numbers = new int[3];
//    }
//}







