using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transpose a matrix
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <returns> The resulting matrix </returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] transposedMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}

