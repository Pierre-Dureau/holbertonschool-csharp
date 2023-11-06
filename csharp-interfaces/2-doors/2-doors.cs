using System;

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
