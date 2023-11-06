using System;

/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the element
    /// </summary>
    /// <returns> The type </returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
