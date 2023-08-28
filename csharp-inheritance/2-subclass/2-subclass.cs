using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Returns True if the object is an instance of a class that inherits from the specified class
    /// </summary>
    /// <param name="derivedType"> The subclass </param>
    /// <param name="baseType"> The baseclass</param>
    /// <returns> True or False </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}