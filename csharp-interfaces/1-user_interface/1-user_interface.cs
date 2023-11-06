using System;

/// <summary> Represents an abstract base class </summary>
public abstract class Base
{
    /// <summary> Gets the name associated with the Base class. </summary>
    string name { get; }

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

/// <summary> Represents a test object that inherits properties from Base class and implements interaction, breakability, and collectability. </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> Defines the interaction behavior of the test object. </summary>
    public void Interact(){}

    /// <summary> Gets or sets the durability of the test object. </summary>
    public int durability { get; set; }

    /// <summary> Defines the break behavior of the test object. </summary>
    public void Break(){}

    /// <summary> Gets or sets the collection state of the test object. </summary>
    public bool isCollected { get; set; }

    /// <summary> Defines the collection behavior of the test object. </summary>
    public void Collect(){}

    /// <summary> Gets or sets the name associated with the TestObject. </summary>
    public string name { get; set; }
}
