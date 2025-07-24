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
            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(MultiplyAgain(5, 6));

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
            string username = "admin";
            string password = "P@ssw0rd123";

            // ❌ Duplicate logic
            Console.WriteLine(Subtract(10, 5));
            Console.WriteLine(SubtractAgain(20, 10));
            Console.WriteLine(SubtractDuplicate(30, 15));

            // ❌ Commented-out code (smell)
            // Console.WriteLine("This is commented code");

            // ❌ Empty catch block
            try
            {
                int x = 5 / 0;
            }
            catch (Exception)
            {
                // nothing here
            }

            // ❌ Unused method
            HelperMethod();
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

        public static int SubtractDuplicate(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtracting numbers...");
            return result;
        }

        public static int Multiply(int a, int b)
        {
            int product = a * b;
            Console.WriteLine("Multiplying numbers...");
            return product;
        }

        public static int MultiplyAgain(int a, int b)
        {
            int product = a * b;
            Console.WriteLine("Multiplying numbers...");
            return product;
        }

        // ❌ Unused method
        public static void HelperMethod()
        {
            Console.WriteLine("This method is not called");
        }
    }
}



