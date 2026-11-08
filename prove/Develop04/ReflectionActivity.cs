using System.Diagnostics;

class ReflectionActivity : BaseActivity
{

    private List<string> _promptList = new List<string>
    {
        "Think of a time when you did something really difficult",
        "Think of a time when you overcame a fear",
        "Think of a challenge that seemed impossible at first",
        "Think of a time when you helped someone in need",
        "Think of a time when you made a mistake",
        "Think of a time when you felt proud of yourself",
        "Think of a time when you had to be patient"
    };

    private List<string> _questions = new List<string>
    {
        "How did it feel when it was complete?",
        "What was the hardest part?",
        "What were you thinking during that experience?",
        "What did you learn from it?",
        "Would you do anything differently?",
        "What helped you get through it?",
        "How did the experience change you?",
        "What surprised you the most?",
        "What are you most proud of?",
        "What did you discover about yourself?",
        "How did others affect the experience?",
        "What emotions do you remember most clearly?",
        "What motivated you to keep going?",
        "What advice would you give your past self?",
        "How do you feel about it now?",
        "What was the most rewarding part?",
        "What challenge did you overcome?",
        "What would you tell someone facing a similar situation?",
        "What strengths did you use?",
        "Why is this memory significant to you?"
    };

    public ReflectionActivity(): base("Reflecting Activity","This activity will help you reflect on times in your lfe when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    } 

    public int RunActivity()
    {

        Random random = new Random();
        int index = random.Next(_promptList.Count);
        string prompt = _promptList[index];
        StartActivity();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        RunCountDownMessage("You may begin in: ", 5);
        StartTimer();
        Console.Clear();
        while (!HasTimerExpired())
        {
            Random rando = new Random();
            int indx = rando.Next(_questions.Count);
            string question = _questions[indx];

            RunSpinnerMessage(question, 10);
        }

        int duration = EndActivity();
        return duration;
    }

}