using System;

namespace DotnetApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(AddAgain(4, 5));
            Console.WriteLine(AddDuplicate(6, 7));
        }

        public static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Adding numbers...");
            return sum;
        }

        public static int AddAgain(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Adding numbers...");
            return sum;
        }

        public static int AddDuplicate(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Adding numbers...");
            return sum;
        }
    }
}

