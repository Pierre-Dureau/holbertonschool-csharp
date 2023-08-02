using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;

        if (n > myLList.Count)
            return 0;
        
        foreach (var item in myLList)
        {
            if (i == n)
                return item;
            i++;
        }

        return 0;
    }
}