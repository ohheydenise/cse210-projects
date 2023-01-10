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