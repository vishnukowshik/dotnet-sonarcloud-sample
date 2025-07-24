using System;

namespace DotnetApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
        }

        public static int Add(int a, int b) => a + b;
    }
}

