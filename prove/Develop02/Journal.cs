using System;
using System.IO.Enumeration;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("press enter to return to menu");
        Console.ReadLine();
    }

    public void NewEntry(Prompt list)
    {
        Entry newEntry = new Entry();
        newEntry.CreateEntry();
        _entries.Add(newEntry);
    } 
    public void WriteToFile()
    {
        Console.WriteLine("What file do you want to save to?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile()
    {
        Console.WriteLine("what file do you want to read from?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry loadentry = new Entry();
            string[] parts = line.Split("#");
            loadentry._date = parts[0];
            loadentry._prompt = parts[1];
            loadentry._entry = parts[2];
            
            _entries.Add(loadentry);
        }
    }

}
