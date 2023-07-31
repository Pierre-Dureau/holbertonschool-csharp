using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string name = "None";
        int max = -1;

        if (myList.Count == 0)
            return name;

        foreach (var item in myList)
        {
            if (item.Value > max)
            {
                max = item.Value;
                name = item.Key;
            }
        }

        return name;
    }
}