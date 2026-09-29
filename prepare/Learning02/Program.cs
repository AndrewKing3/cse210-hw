using System;

class Program
{
    static void Main(string[] args)
    {
        Job JobOne = new Job();
        JobOne._Job = "Software Engineer";
        JobOne._Company = "Microsoft";
        JobOne._YearStart = 2019;
        JobOne._YearEnd = 2022;

        Job JobTwo = new Job();
        JobTwo._Job = "Manager";
        JobTwo._Company = "Apple";
        JobTwo._YearStart = 2022;
        JobTwo._YearEnd = 2023;

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(JobOne);
        resume._jobs.Add(JobTwo);

        resume.Display();
    }
}