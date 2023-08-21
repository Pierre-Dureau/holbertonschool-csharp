using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            try {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i,j] /= num;
                    }
                }
            } catch (DivideByZeroException) {
                System.Console.WriteLine("Num cannot be 0");
                return null;
            }

            return matrix;
        }
    }
}
