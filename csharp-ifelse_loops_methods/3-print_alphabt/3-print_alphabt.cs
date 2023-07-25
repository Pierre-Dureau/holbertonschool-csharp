using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char let = 'a';

            for (; let <= 'z'; let++)
            {
                if (let != 'e' && let != 'q')
                    Console.Write(let);
            }
        }
    }
}
