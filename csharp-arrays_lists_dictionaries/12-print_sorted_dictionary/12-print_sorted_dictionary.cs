using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorted = myDict.OrderBy(x => x.Key);

        foreach (var item in sorted)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}