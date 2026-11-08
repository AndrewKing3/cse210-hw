class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;

        
    }

   


    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message}     ");
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Console.Write("\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(seconds);
        Console.WriteLine(message);
        while(DateTime.Now < endTime)
        {

            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("x");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        ObtainDuration();
        Console.Clear();
        RunCountDownMessage("Get ready", 5);
    }

    public int EndActivity()
    {
        
        RunSpinnerMessage("Well Done!!", 5);
        RunSpinnerMessage($"You have completed another {_duration} seconds of the {_name}.", 5);
        return _duration;
    }
}


