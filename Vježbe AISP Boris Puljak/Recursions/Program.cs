using System;

namespace Recursions
{
    class Program
    {
        static void Main()
        {
            int result = Factorial(6);
            Console.WriteLine($"Factorial of 6: {result}");

            result = Fibonacci(6);
            Console.WriteLine($"Fibonacci of 6 (Recursive): {result}");

            result = FibonacciIter(6);
            Console.WriteLine($"Fibonacci of 6 (Iterative): {result}");

            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciIter(int n)
        {
            if (n <= 1) return n;

            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}
