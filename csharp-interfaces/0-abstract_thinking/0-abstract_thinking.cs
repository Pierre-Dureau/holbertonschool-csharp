using System;

/// <summary> Represents an abstract base class </summary>
public abstract class Base
{
    /// <summary> Gets or sets the name associated with the Base class. </summary>
    public string name;

    /// <summary> Overrides the default ToString method </summary>
    /// <returns> String </returns>
    public override string ToString() => $"{name} is a {GetType()}";
}
