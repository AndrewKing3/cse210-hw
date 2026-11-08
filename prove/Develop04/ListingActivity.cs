class ListingActivity : BaseActivity
{
    List<string> _prompts = new List<string>
{
    "When have you felt the Holy Ghost this month?",
    "When have you felt especially close to God recently?",
    "When have you seen an answer to a prayer?",
    "When have you felt guided in a decision?",
    "When have you helped someone this week?",
    "When has someone helped you recently?",
    "When have you felt grateful this month?",
    "When have you felt peace during a difficult situation?",
    "When have you learned something important about yourself?",
    "When have you shown kindness to someone?",
    "When have you received kindness from someone?",
    "When have you felt genuinely happy recently?",
    "When have you overcome a challenge lately?",
    "When have you stepped outside your comfort zone?",
    "When have you made someone smile?",
    "When have you felt proud of your efforts?",
    "When have you learned from a mistake?",
    "When have you felt inspired?",
    "When have you been a good example to someone?",
    "When have you strengthened a relationship?",
    "When have you accomplished a goal?",
    "When have you felt loved or appreciated?",
    "When have you noticed beauty in everyday life?",
    "When have you exercised faith?",
    "When have you felt hopeful about the future?",
    "When have you shown patience?",
    "When have you served without expecting anything in return?",
    "When have you felt courage in a difficult moment?",
    "When have you learned something new?",
    "When have you taken time to reflect on your life?"
};

    public ListingActivity()
        : base("Listing Activity",
              "This activity will help you reflect on times in your lfe when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public int RunActivity()
    {
        StartActivity();


        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(prompt);
        RunCountDownMessage("You may begin in: ", 5);

        int count = 0;
        StartTimer();

        while (!HasTimerExpired())
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items");

        int duration = EndActivity();
        return duration;
    }
}