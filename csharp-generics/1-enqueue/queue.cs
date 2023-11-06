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
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }

    /// <summary> Count the number of node in the queue </summary>
    /// <returns> Int </returns>
    public int Count() => count;
}

