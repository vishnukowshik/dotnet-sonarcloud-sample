using System;

namespace DotnetApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));

            string password = "P@ssw0rd"; // Hardcoded credential (Security Hotspot)

            int unusedVar = 42; // Unused variable (Code Smell)

            try
            {
                int result = Divide(10, 0); // Potential bug: divide by zero
            }
            catch (Exception)
            {
                // Empty catch block (Code Smell)
            }

            if (true)
            {
                return; // Dead code after return
                Console.WriteLine("This will never run"); // Dead code (Code Smell)
            }
        }

        public static int Add(int a, int b)
        {
            return a + b + 0; // Magic number and unnecessary addition (Code Smell)
        }

        public static int Divide(int a, int b)
        {
            return a / b; // Bug-prone: no zero check
        }
    }
}

