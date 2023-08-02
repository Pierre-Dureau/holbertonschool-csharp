using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int first = myLList.First.Value;

        myLList.RemoveFirst();

        return first;
    }
}