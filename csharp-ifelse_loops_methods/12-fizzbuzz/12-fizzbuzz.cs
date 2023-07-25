using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i != 1)
                    Console.Write(" ");
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                if (i % 5 != 0 && i % 3 != 0)
                    Console.Write(i);
            }
            Console.WriteLine("");
        }
    }
}
