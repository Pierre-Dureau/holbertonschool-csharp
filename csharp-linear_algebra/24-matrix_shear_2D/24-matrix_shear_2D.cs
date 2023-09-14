using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <param name="direction"> The direction x or y </param>
    /// <param name="factor"> The factor</param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        if (direction != 'x' || direction != 'y')
            return new double[,] { { -1 } };

        double[,] shearedMatrix = new double[2, 2];
        double[,] shearMatrix = new double[2, 2] {
            {1, 0},
            {0, 1}
        };

        direction == 'x' ? shearedMatrix[1, 0] = factor : shearedMatrix[0, 1] = factor;

        shearedMatrix[0, 0] = Math.Round(matrix[0, 0] * shearMatrix[0, 0] + matrix[0, 1] * shearMatrix[1, 0], 2);
        shearedMatrix[0, 1] = Math.Round(matrix[0, 0] * shearMatrix[0, 1] + matrix[0, 1] * shearMatrix[1, 1], 2);
        shearedMatrix[1, 0] = Math.Round(matrix[1, 0] * shearMatrix[0, 0] + matrix[1, 1] * shearMatrix[1, 0], 2);
        shearedMatrix[1, 1] = Math.Round(matrix[1, 0] * shearMatrix[0, 1] + matrix[1, 1] * shearMatrix[1, 1], 2);

        return shearedMatrix;
    }
}
