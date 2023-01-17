// Zachary Williams
// 1.17.2023

using System;

public class Resume
{
    public string _zwName;
    public List<Job> _zwJobs = new List<Job>();

    public void zwDisplayResume()
    {
        Console.WriteLine($"Name: {this._zwName}\nJobs:");

        foreach (Job zwJob in _zwJobs)
        {
            zwJob.zwDisplayJob();
        }
    }
}