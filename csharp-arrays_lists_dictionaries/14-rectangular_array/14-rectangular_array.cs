using System;

class Program
{
    static void Main(string[] args)
    {
        int [,] array = new int[5,5] {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 1, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0}
        };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j != 4)
                    Console.Write($"{array[i,j]} ");
                else
                    Console.Write($"{array[i,j]}");
            }
            Console.WriteLine();
        }
    }
}