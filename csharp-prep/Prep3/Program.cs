using System;

class Program
{
    static void Main(string[] args)
    {
        Random zw_rand = new Random();
        int zw_magic = zw_rand.Next(1, 101);
        int zw_guess = 0;

        int zw_count = 0;

        while (zw_guess != zw_magic) {
            Console.Write("What is your guess between 1 and 100? ");
            zw_guess = int.Parse(Console.ReadLine());

            if (zw_guess < zw_magic) {
                Console.WriteLine("Higher");
                zw_count++;
            }

            else if (zw_guess > zw_magic) {
                Console.WriteLine("Lower");
                zw_count++;
            }

            else {
                Console.WriteLine($"You got it! It only took you {zw_count} tries.");
            }
        }
    }
}