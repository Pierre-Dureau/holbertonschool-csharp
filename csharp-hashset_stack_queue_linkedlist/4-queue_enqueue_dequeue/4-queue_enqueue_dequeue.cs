using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int n = aQueue.Count;

        Console.WriteLine($"Number of items: {n}");

        if (n > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        if (!aQueue.Contains(search))
            Console.WriteLine($"Queue contains \"{search}\": False");
        else
        {
            Console.WriteLine($"Queue contains \"{search}\": True");
            while (aQueue.Dequeue() != search)
                continue;
        }
        
        aQueue.Enqueue(newItem);

        return aQueue;
    }
}