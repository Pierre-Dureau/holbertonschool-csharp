using System;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the length of a given vector
    /// </summary>
    /// <param name="vector"> Array of double </param>
    /// <returns> The length or -1 if not a vector 2D or 3D </returns>
    public static double Magnitude(double[] vector)
    {
        int length = vector.Length;
        double n = 0;

        if (length != 2 && length != 3)
            return -1;

        foreach (var item in vector)
        {
            n += item * item;
        }

        return (Math.Round(Math.Sqrt(n), 2));
    }
}
