public class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string descrition, int points, bool complete, string goalType)
    {
        _name = name;
        _description = descrition;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        SetName();
        SetDescrition();
        SetPoints();
        _complete = false;
        _goalType = goalType;

    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
    }

    private void SetDescrition()
    {
        Console.WriteLine("What is the descrition for the goal?");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.WriteLine("How many points is it worth?");
        _points = int.Parse(Console.ReadLine());
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public string GetString()
    {
        return $"[]{_points} points - {_name}: {_description} ({_goalType}) ";
    }
}