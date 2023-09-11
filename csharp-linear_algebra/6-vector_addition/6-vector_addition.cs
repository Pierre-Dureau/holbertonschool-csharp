using System;


class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int len1 = vector1.Length;
        int len2 = vector2.Length;

        if ((len1 != 2 && len1 != 3) || (len1 != len2))
        {
            return -1;
        }

        double[] resultVector = new double[len1];

        for (int i = 0; i < len1; i++)
        {
            resultVector[i] = vector1[i] + vector2[i];
        }

        return resultVector;
    }
}
