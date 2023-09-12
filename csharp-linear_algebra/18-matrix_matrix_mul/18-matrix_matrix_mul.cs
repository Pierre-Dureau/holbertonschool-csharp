using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply 2 matrix
    /// </summary>
    /// <param name="matrix1"> First matrix </param>
    /// <param name="matrix2"> Second matrix </param>
    /// <returns> The resulting matrix or -1 </returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix2.GetLength(1); i++)
        {
            for (int j = 0; j < matrix1.GetLength(0); j++)
            {
                result[j,i] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[j,i] += matrix1[j,k] * matrix2[k,i];
                }
            }
        }

        return result;
    }
}

