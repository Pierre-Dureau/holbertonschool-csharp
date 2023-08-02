using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int n = aStack.Count;

        Console.WriteLine($"Number of items: {n}");

        if (n > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        if (!aStack.Contains(search))
            Console.WriteLine($"Stack contains \"{search}\": False");
        else
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
            while (aStack.Pop() != search)
                continue;
        }

        aStack.Push(newItem);
        
        return aStack;
    }
}