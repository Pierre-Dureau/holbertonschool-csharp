using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;

        foreach (var item in myLList)
        {
            if (i == index)
            {
                myLList.Remove(item);
                break;
            }
            i++;
        }
    }
}