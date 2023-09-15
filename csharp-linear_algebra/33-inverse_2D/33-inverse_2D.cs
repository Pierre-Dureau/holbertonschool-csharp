using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1, 1] { { -1 } };

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
            return new double[1, 1] { { -1 } };

        determinant = 1 / determinant;

        return new double[2,2] {
            {Math.Round(matrix[1,1] * determinant, 2), Math.Round(-matrix[0,1]  * determinant, 2)},
            {Math.Round(-matrix[1,0]  * determinant, 2), Math.Round(matrix[0,0]  * determinant, 2)}
        };
    }
}

