using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage in the class? ");
        float zw_percent = Single.Parse(Console.ReadLine());

        string zw_letter = "";
        string zw_sign = "";

        if (zw_percent >= 90) {
            zw_letter = "A";
        }

        else if (zw_percent >= 80) {
            zw_letter = "B";
        }

        else if (zw_percent >= 70) {
            zw_letter = "C";
        }

        else if (zw_percent >= 60) {
            zw_letter = "D";
        }

        else {
            zw_letter = "F";
        }

        if (zw_percent < 97 && zw_percent >= 60) {
            if (zw_percent % 10 >= 7) {
                zw_sign = "+";
            }

            else if (zw_percent % 10 < 3) {
                zw_sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {zw_letter}{zw_sign}");

        if (zw_percent >= 70) {
            Console.WriteLine("You're passing! Keep up the good work!");
        }

        else {
            Console.WriteLine("Looks like you're not doing too hot. No sweat, get 'em next time!");
        }
    }
}