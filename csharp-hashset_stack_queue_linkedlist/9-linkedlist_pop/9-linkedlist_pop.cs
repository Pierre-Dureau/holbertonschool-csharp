using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int first;

        if (myLList.Count == 0)
            return 0;

        first = myLList.First.Value;
        myLList.RemoveFirst();

        return first;
    }
}