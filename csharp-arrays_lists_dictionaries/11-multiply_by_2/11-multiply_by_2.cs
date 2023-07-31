using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);

        foreach (var key in keys)
        {
            myDict[key] *= 2;
        }

        return myDict;
    }
}