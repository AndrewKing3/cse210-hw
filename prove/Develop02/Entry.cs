using System;


public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"({_date}) {_prompt}");
        Console.WriteLine(_entry);
    }

    public void CreateEntry()
    {
        Prompt prompt = new Prompt();


        _prompt = prompt.RandomPrompt();
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
        _date =  DateTime.Now.ToString(); 

    }
    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_entry}";
        return outputString;
    }


}