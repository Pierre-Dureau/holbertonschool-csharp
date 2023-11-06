using System;

/// <summary> Represents a generic queue data structure. </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count = 0;

    /// <summary> Represents a node </summary>
    public class Node
    {
        /// <summary> Value of any type </summary>
        public T value = default(T);
        /// <summary> Next node </summary>
        public Node next = null;

        /// <summary> Constructor of Node class </summary>
        /// <param name="value"> Any type </param>
        public Node(T value) => this.value = value;
    }


    /// <summary> Returns the type of the element </summary>
    /// <returns> The type </returns>
    public Type CheckType() => typeof(T);

    /// <summary> Enqueue a node </summary>
    /// <param name="item"> Any type </param>
    public void Enqueue(T item)
    {
        Node node = new Node(item);

        if (head == null)
            head = node;
        else
            tail.next = node;
        tail = node;
        count++;
    }

    /// <summary> Dequeue the head </summary>
    /// <returns> Value of the node </returns>
    public T Dequeue()
    {
        if (Count() == 0)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    /// <summary> Returns the value of the first node </summary>
    /// <returns> Any type </returns>
    public T Peek()
    {
        if (Count() == 0)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
            return head.value;
    }

    /// <summary> Prints the queue </summary>
    public void Print()
    {
        if (Count() == 0)
            System.Console.WriteLine("Queue is empty");
        else
        {
            Node node = head;
            for (; node != null; node = node.next)
                System.Console.WriteLine(node.value);
        }
    }

    /// <summary> Concatenates all values in the queue only if the queue is of type String or Char </summary>
    /// <returns> String </returns>
    public string Concatenate()
    {
        Node node = head;
        string str = "";

        if (Count() == 0)
        {
            System.Console.WriteLine("Queue is empty");
            return null;
        }
        else if (CheckType() == typeof(string))
        {
            for (; node != null; node = node.next)
                str += node.value + " ";
            return str;
        }
        else if (CheckType() == typeof(char))
        {
            for (; node != null; node = node.next)
                str += node.value;
            return str;
        }
        else
        {
            System.Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
    }

    /// <summary> Count the number of node in the queue </summary>
    /// <returns> Int </returns>
    public int Count() => count;
}


