using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char let = 'a';

            for (; let <= 'z'; let++)
            {
                Console.Write(let);
            }
        }
    }
}
