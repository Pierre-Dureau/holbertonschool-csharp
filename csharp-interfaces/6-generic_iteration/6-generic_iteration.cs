using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> Represents an abstract base class </summary>
public abstract class Base
{
    /// <summary> Gets the name associated with the Base class. </summary>
    public string name { get; set;}

    /// <summary> Overrides the default ToString method </summary>
    /// <returns> String </returns>
    public override string ToString() => $"{name} is a {GetType()}";
}

/// <summary> Represents a contract defining interactive behavior. </summary>
public interface IInteractive
{
    /// <summary> Defines a method to interact with an object. </summary>
    void Interact();
}

/// <summary> Represents a contract for objects that can be broken. </summary>
public interface IBreakable
{
    /// <summary> Gets or sets the durability of an object. </summary>
    int durability { get; set; }

    /// <summary> Defines a method to break an object. </summary>
    void Break();
}

/// <summary> Represents a contract for objects that can be collected. </summary>
public interface ICollectable
{
    /// <summary> Gets or sets the state indicating whether an object has been collected. </summary>
    bool isCollected { get; set; }

    /// <summary> Defines a method to collect an object. </summary>
    void Collect();
}

/// <summary> Represents a class for creating a door that inherits properties from the Base class and implements interactive behavior. </summary>
public class Door : Base, IInteractive
{
    /// <summary> Initializes a new instance of the Door class with a default or provided name. </summary>
    /// <param name="name">The name associated with the door (default is "Door").</param>
    public Door(string name = "Door") => this.name = name;

    /// <summary> Implements the interaction behavior for the door. </summary>
    public void Interact() => System.Console.WriteLine($"You try to open the {name}. It's locked.");
}

/// <summary> Represents a class for creating a decoration that inherits properties from the Base class and implements interactive and breakable behavior. </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Gets or sets a value indicating whether the decoration is a quest item. </summary>
    public bool isQuestItem;

    /// <summary> Gets or sets the durability of the decoration. </summary>
    public int durability { get; set; }

    /// <summary> Initializes a new instance of the Decoration class with specified parameters. </summary>
    /// <param name="name">The name associated with the decoration (default is "Decoration").</param>
    /// <param name="durability">The durability value for the decoration (default is 1).</param>
    /// <param name="isQuestItem">Specifies whether the decoration is a quest item (default is false).</param>
    /// <exception cref="Exception">Thrown when the durability is less than or equal to 0.</exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> Handles the interaction behavior for the decoration. </summary>
    public void Interact()
    {
        if (durability <= 0)
            System.Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            System.Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            System.Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary> Implements the break behavior for the decoration. </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            System.Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            System.Console.WriteLine($"You smash the {name}. What a mess.");
        else
            System.Console.WriteLine($"The {name} is already broken.");
    }
}

/// <summary> Represents a class for creating a key that inherits properties from the Base class and implements collectable behavior. </summary>
public class Key : Base, ICollectable
{
    /// <summary> Gets or sets a value indicating whether the key has been collected. </summary>
    public bool isCollected { get; set; }

    /// <summary> Initializes a new instance of the Key class with specified parameters. </summary>
    /// <param name="name">The name associated with the key (default is "Key").</param>
    /// <param name="isCollected">Specifies whether the key has been collected (default is false).</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary> Implements the collection behavior for the key. </summary>
    public void Collect()
    {
        if (!isCollected)
            System.Console.WriteLine($"You pick up the {name}.");
        else
            System.Console.WriteLine($"You have already picked up the {name}.");

        isCollected = true;
    }
}

/// <summary> Represents a generic collection of objects using a custom linked list structure that implements IEnumerable. </summary>
/// <typeparam name="T">The type of elements in the collection.</typeparam>
public class Objs<T> : IEnumerable<T>
{
    private Node head;
    private Node tail;

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

    /// <summary> Adds a new node with the provided value to the collection. </summary>
    /// <param name="value">The value to be added to the collection.</param>
    public void Add(T value)
    {
        Node node = new Node(value);

        if (head == null)
            head = node;
        else
            tail.next = node;
        tail = node;
    }

    /// <summary> Returns an enumerator that iterates through the collection. </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        Node node = head;

        for (; node != null; node = node.next)
            yield return node.value;
    }

    /// <summary> Returns an enumerator that iterates through the collection. </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
