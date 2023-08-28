using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// returns True if the object is an int
    /// </summary>
    /// <param name="obj"> The obj </param>
    /// <returns> True or False </returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}
