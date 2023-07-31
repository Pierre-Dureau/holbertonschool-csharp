using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int [,] newMatrix = new int[myMatrix.GetLength(0),myMatrix.GetLength(0)];

        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(0); j++)
            {
                newMatrix[i,j] = myMatrix[i,j] * myMatrix[i,j];
            }
        }

        return newMatrix;
    }
}