using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix
    /// </summary>
    /// <param name="matrix1"> First matrix </param>
    /// <param name="matrix2"> Second matrix </param>
    /// <returns> Return the resulting matrix or -1 </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check square matrix
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return new double[,] {{-1}};
        // Check same size
        if (matrix1.GetLength(0) != matrix2.GetLength(0))
            return new double[,] {{-1}};
        // Check size 2 or 3
        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
            return new double[,] {{-1}};

        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i,j] = matrix1[i,j] + matrix2[i,j];
            }
        }

        return result;
    }
}

