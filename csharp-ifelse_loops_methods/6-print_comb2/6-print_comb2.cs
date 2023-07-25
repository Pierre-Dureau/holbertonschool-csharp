using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 80; i++)
            {
                if (i / 10 < i % 10)
                    Console.Write($"{i:D2}, ");
            }
            Console.WriteLine("89");
        }
    }
}
