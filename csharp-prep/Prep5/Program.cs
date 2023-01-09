using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string zw_name = PromptUserName();
        int zw_num = PromptUserNumber();
        int zw_square = SquareNumber(zw_num);
        DisplayResult(zw_name, zw_square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string zw_name = Console.ReadLine();
        return zw_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string zw_input = Console.ReadLine();
        int zw_num = int.Parse(zw_input);
        return zw_num;
    }

    static int SquareNumber(int zw_user_num)
    {
        int zw_square = zw_user_num * zw_user_num;
        return zw_square;
    }

    static void DisplayResult(string zw_user_name, int zw_square_num)
    {
        Console.WriteLine($"{zw_user_name}, the square of your number is {zw_square_num}");
    }
}