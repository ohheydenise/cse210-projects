public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {this._name} \nJobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}