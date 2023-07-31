using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        foreach (var item in myList)
        {
            result.Add(item % 2 == 0 ? true : false);
        }
        return result;
    }
}