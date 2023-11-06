using System;

/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count = 0;

    public class Node
    {
        T value = null;
        Node next = null;

        Node(T value) => this.value = value;
    }


    /// <summary>
    /// Returns the type of the element
    /// </summary>
    /// <returns> The type </returns>
    public Type CheckType() => return typeof(T);

    public void Enqueue(T item)
    {
        Node node = new Node(item);

        if (!head)
            head = node;
        else
        {
            Node temp = head;
            while (temp.next)
                temp = temp.next;
            temp.next = node;
        }
        count++;
    }

    public int Count() => return count;
}

