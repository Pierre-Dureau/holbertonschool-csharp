﻿using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;

        try
        {
            result = a / b;
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot divide by zero");
            result = 0;
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
