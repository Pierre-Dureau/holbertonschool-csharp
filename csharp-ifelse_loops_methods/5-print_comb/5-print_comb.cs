using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                Console.Write($"{i:D2}, ");
            }
            Console.Write("99\n");
        }
    }
}
