using System;

/// <summary>
/// class Determinant
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double Determinant(double[,] matrix)
    {
        // Check square matrix
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] {{-1}};
        // Check size 2 or 3
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return new double[,] {{-1}};

        if (matrix.GetLength(0) == 2)
            return matrix[0, 0] * matrix[1, 1] + matrix[0, 1] * matrix[1, 0];

        double first = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] + matrix[1, 2] * matrix[2, 1]);
        double secnd = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] + matrix[1, 2] * matrix[2, 0]);
        double third = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] + matrix[1, 1] * matrix[2, 0]);

        return first - secnd + third;
    }
}

