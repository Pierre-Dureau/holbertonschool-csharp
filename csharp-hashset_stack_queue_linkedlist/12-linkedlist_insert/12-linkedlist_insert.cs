using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode;
        LinkedListNode<int> current;

        if (myLList == null)
        {
            newNode = myLList.AddFirst(n);
            return newNode;
        }

        current = myLList.First;
        if (current.Value > n)
            newNode = myLList.AddBefore(current, n);
        else
        {
            while (current.Next != null && current.Next.Value < n)
                current = current.Next;
            newNode = myLList.AddAfter(current, n);
        }

        return newNode;
    }
}