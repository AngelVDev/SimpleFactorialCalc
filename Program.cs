using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculator");

            Console.Write("Enter a non-negative integer: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(number);
            
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
