using System;

public class Job
{
    public string _Job;
    public string _Company;
    public int _YearStart;
    public int _YearEnd;

    public void Display()
    {
        Console.WriteLine($"{_Job} ({_Company}) {_YearStart}-{_YearEnd}");
    }
}