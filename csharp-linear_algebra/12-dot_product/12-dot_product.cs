using System;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates dot product of either two 2D or two 3D vectors
    /// </summary>
    /// <param name="vector1"> The first vector </param>
    /// <param name="vector2"> The second vector </param>
    /// <returns> The result or -1 </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int len1 = vector1.Length;
        int len2 = vector2.Length;

        if ((len1 != 2 && len1 != 3) || (len1 != len2))
        {
            return new double[] {-1};
        }

        double[] result = new double[len1];

        for (int i = 0; i < len1; i++)
        {
            result[i] = vector1[i] * vector2[i];
        }

        return result;
    }
}
