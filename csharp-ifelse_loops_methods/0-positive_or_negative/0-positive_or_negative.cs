using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        
        if (number > 0)
            System.Console.WriteLine($"{number} is positive");
        else if (number < 0)
            System.Console.WriteLine($"{number} is negative");
        else
            System.Console.WriteLine("0 is zero");
    }
}