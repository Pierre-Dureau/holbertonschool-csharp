using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix and a scalar
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <param name="scalar"> The scalar </param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };
        if (matrix.GetLength(0) != 2 || matrix.GetLength(0) != 3)
            return new double[,] { { -1 } };

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                result[i,j] = matrix[i,j] * scalar;
            }
        }
    }
}

