using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 1 World!");

        Console.Write("What is your first name? ");
        string zw_first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string zw_last = Console.ReadLine();

        Console.WriteLine($"Your name is {zw_last}, {zw_first} {zw_last}.");
    }
}