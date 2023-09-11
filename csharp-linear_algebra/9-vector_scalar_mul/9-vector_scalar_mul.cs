using System;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiply a vector with a scalar
    /// </summary>
    /// <param name="vector"> The vector </param>
    /// <param name="scalar"> The scalar </param>
    /// <returns> The resulting vector or -1 </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int len1 = vector1.Length;

        if (len1 != 2 && len1 != 3)
            return new double[] {-1};

        double[] result = new double[len1];

        for (int i = 0; i < len1; i++)
            result[i] = vector1[i] * scalar;

        return result;
    }
}
