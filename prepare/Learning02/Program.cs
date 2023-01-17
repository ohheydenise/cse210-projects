// Zachary Williams
// 1.17.2023

using System;

class Program
{
    static void Main(string[] args)
    {
        Job zwJob1 = new Job();
        zwJob1._zwTitle = "Software Engineer";
        zwJob1._zwCompany = "Microsoft";
        zwJob1._zwStart = 2019;
        zwJob1._zwEnd = 2022;

        Job zwJob2 = new Job();
        zwJob2._zwTitle = "Manager";
        zwJob2._zwCompany = "Apple";
        zwJob2._zwStart = 2022;
        zwJob2._zwEnd = 2023;

        Resume zwMyResume = new Resume();
        zwMyResume._zwName = "Allison Rose";

        zwMyResume._zwJobs.Add(zwJob1);
        zwMyResume._zwJobs.Add(zwJob2);

        zwMyResume.zwDisplayResume();
    }
}