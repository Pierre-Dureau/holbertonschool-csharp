using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix"> The matrix </param>
    /// <param name="angle">The angle in radians </param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] rotatedMatrix = new double[2, 2];

        rotatedMatrix[0, 0] = Math.Round(matrix[0, 0] * cosTheta + matrix[0, 1] * -sinTheta, 2);
        rotatedMatrix[0, 1] = Math.Round(matrix[0, 0] * sinTheta + matrix[0, 1] * cosTheta, 2);
        rotatedMatrix[1, 0] = Math.Round(matrix[1, 0] * cosTheta + matrix[1, 1] * -sinTheta, 2);
        rotatedMatrix[1, 1] = Math.Round(matrix[1, 0] * sinTheta + matrix[1, 1] * cosTheta, 2);

        return rotatedMatrix;
    }
}

