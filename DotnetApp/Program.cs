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

            // ❌ Unused variable
            int unused = 100;

            // ❌ Potential null reference
            string input = null;
            Console.WriteLine(input.ToString()); // This will throw

            // ❌ Dead code
            if (false)
            {
                Console.WriteLine("This will never run");
            }

            // ❌ Hardcoded credentials (security hotspot)
            string password = "P@ssw0rd123";

            // ❌ Syntax error (commented to not break the build)
            // some error

            // ❌ Duplicate logic
            Console.WriteLine(Subtract(10, 5));
            Console.WriteLine(SubtractAgain(20, 10));
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

        public static int Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtracting numbers...");
            return result;
        }

        public static int SubtractAgain(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtracting numbers...");
            return result;
        }
    }
}


