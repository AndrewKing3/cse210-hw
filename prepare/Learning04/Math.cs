class Math : Assignment
{
    private string _textbookSection;
    private string _problem;


    public Math(string name, string topic, string textbook, string problem):base(name,topic)
    {
        _textbookSection = textbook;
        _problem = problem;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine(GetSummary());
        Console.WriteLine($"Section {_textbookSection} Problems {_problem}");
    }
}