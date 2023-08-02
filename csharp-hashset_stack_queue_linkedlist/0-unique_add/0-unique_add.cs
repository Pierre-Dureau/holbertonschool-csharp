using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        int check = 0;
        
        for (int i = 0; i < myList.Count; i++)
        {
            for (int j = i + 1; j < myList.Count; j++)
            {
                if (myList[i] == myList[j])
                    check = 1;
            }

            if (check == 0)
                sum += myList[i];
            else
                check = 0;
        }

        return sum;
    }
}