using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            fizzbuzzwriter();
        }
        static void fizzbuzzwriter()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool printed = false;
                if (i % 3 == 0)
                {
                    System.Console.Write("Fizz");
                    printed = true;
                }
                if (i % 5 == 0)
                {
                    System.Console.Write("Buzz");
                    printed = true;
                }
                if (printed == true)
                {
                    System.Console.Write("\n");
                } else
                {
                    System.Console.Write("{0}\n", i);
                }


            }
        }
    }
}
