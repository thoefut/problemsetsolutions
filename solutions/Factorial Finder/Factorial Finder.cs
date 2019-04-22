/*
 * Factorial Finder
 * The factorial of a positive integer n is defined as the product of the sequence , n-1, n-2, ...1 and the factorial of 0 is defined as being 1. Solve this using both loops and recursion.
 * 
 * Input = number n from which to calculate n!
 * Output = n! calculated both using recursive and iterative methods
 */

using System;

namespace Factorial_Finder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer n to calculate n!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Using recursive factorial n! = " + Factorial_Finder.RecursiveFactorial(n));
            Console.WriteLine("Using iterative factorial n! = " + Factorial_Finder.IterativeFactorial(n));
        }
    }
    public static class Factorial_Finder
    {
        //Tail recursion!
        public static decimal RecursiveFactorial(int n, decimal leftover=1)
        {
            if (n == 0) { return 1; }
            if (n == 1) { return leftover; }
            if (n > 1)
            {
                return RecursiveFactorial(n - 1, leftover*n);
            }
            return -1;
        }
        public static decimal IterativeFactorial(int n)
        {
            if (n == 0) { return 1; }
            if (n >= 1)
            {
                decimal fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            return -1;
        }
    }
}

