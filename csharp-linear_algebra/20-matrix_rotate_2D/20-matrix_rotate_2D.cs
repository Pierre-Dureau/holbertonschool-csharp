using System;


class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] rotatedMatrix = new double[2, 2];

        rotatedMatrix[0, 0] = cosTheta * matrix[0, 0] - sinTheta * matrix[1, 0];
        rotatedMatrix[0, 1] = cosTheta * matrix[0, 1] - sinTheta * matrix[1, 1];
        rotatedMatrix[1, 0] = sinTheta * matrix[0, 0] + cosTheta * matrix[1, 0];
        rotatedMatrix[1, 1] = sinTheta * matrix[0, 1] + cosTheta * matrix[1, 1];

        return rotatedMatrix;
    }
}

