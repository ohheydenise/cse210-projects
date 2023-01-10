public class Job
{
    public string _zwTitle;
    public string _zwCompany;
    public int _zwStart;
    public int _zwEnd;

    public void zwDisplayJob()
    {
        Console.WriteLine($"{this._zwTitle} ({this._zwCompany}) {this._zwStart}-{this._zwEnd}");
    }
}