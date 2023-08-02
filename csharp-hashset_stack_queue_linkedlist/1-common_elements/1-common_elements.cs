using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (var item in list1)
        {
            foreach (var item2 in list2)
            {
                if (item == item2)
                {
                    newList.Add(item);
                    break;
                }
            }
        }

        return newList;
    }
}