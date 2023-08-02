using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;

        foreach (var item in myLList)
        {
            if (item == value)
                return i;
            i++;
        }

        return -1;
    }
}