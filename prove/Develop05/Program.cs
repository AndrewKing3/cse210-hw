using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal goal = new BaseGoal("BaseGoal");
        Console.WriteLine(goal.GetString());
    }
}