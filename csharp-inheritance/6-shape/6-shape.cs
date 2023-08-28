using System;

/// <summary>
/// Shape class
/// </summary>
public class Shape
{
    /// <summary>
    /// Not implemented
    /// </summary>
    /// <returns> Not implemented </returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Get / Set the width
    /// </summary>
    public int Width 
    {
        get => width;
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>
    /// Get / Set the height
    /// </summary>
    public int Height
    {
        get => height;
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
