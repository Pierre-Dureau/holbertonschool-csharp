using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            int[] array;

            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }

            array = new int[size];

            if (size > 0)
            {
                Console.Write("0");
                array[0] = 0;
                for (int i = 1; i < size; i++)
                {
                    array[i] = i;
                    Console.Write($" {i}");
                }
            }

            Console.WriteLine("");
            return array;
        }
    }