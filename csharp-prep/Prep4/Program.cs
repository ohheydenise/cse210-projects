using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> zw_nums = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        float zw_sum = 0;

        while (zw_nums.IndexOf(0) == -1) {
            Console.Write("Please enter a number: ");
            int zw_num_user = Convert.ToInt32(Console.ReadLine());
            zw_nums.Add(zw_num_user);
            zw_sum += zw_num_user;
        }

        float zw_length = zw_nums.Count() - 1;
        float zw_average = zw_sum / zw_length;
        int zw_highest = zw_nums.Max();
        Console.WriteLine($"The sum is: {zw_sum}");
        Console.WriteLine($"The average is: {zw_average}");
        Console.WriteLine($"The largest number is: {zw_highest}");
    }
}