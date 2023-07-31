using System.Collections.Generic;
using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            if (i == 0)
                Console.Write($"{i}");
            else
                Console.Write($" {i}");
        }
        Console.WriteLine();
        return newList;
    }
}