using System;
using System.Collections.Generic;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array
    /// </summary>
    /// <param name="obj"> The obj </param>
    /// <returns> True or False </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        // obj is Int32[]
        // obj.GetType() == typeof(Int32[])
        return (obj.GetType().IsArray);
    }
}
