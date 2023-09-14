using System;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors
    /// </summary>
    /// <param name="vector1"> First vector </param>
    /// <param name="vector2"> Second vector </param>
    /// <returns> The resulting vector or -1 </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[1] { -1 };

        double cX = Math.Round(vector1[1] * vector2[2] - vector1[2] * vector2[1], 2);
        double cY = Math.Round(vector1[2] * vector2[0] - vector1[0] * vector2[2], 2);
        double cZ = Math.Round(vector1[0] * vector2[1] - vector1[1] * vector2[0], 2);

        return new double[3] {cX, cY, cZ};
    }
}
