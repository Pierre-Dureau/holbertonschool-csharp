using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int n = number % 10;

        Console.Write($"The last digit of {number} is {n} ");
        if (n > 5)
            System.Console.WriteLine("and is greater than 5");
        else if (n < 6)
            System.Console.WriteLine("and is less than 6");
        else
            System.Console.WriteLine("and is 0");
    }
}
