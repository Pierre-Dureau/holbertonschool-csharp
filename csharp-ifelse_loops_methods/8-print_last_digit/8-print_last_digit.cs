using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        number = number % 10;
        if (number < 0)
            number = number * -1;
        Console.Write(number);
        return number;
    }
}