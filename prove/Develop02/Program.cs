using System;
using System.Diagnostics.CodeAnalysis;


//Two things I added was waiting until the user presses enter to return to the menu after displaying the entries.
//the second one is the ability to add a new prompt.
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();
        Prompt list = new Prompt();

        int response = 0;

        while(response != 5)
        {
        response = myMenu.ProcessMenu();
        
        
        switch (response)
        {
            case 1:
                Console.WriteLine("Create");
                myJournal.NewEntry(list);
                break;
            case 2:
                Console.WriteLine("Display: ");
                myJournal.Display();
                break;
            case 3:
                Console.WriteLine("Save");
                myJournal.WriteToFile();
                break;
            case 4:
                Console.WriteLine("Write");
                myJournal.ReadFromFile();
                break;

        }

        }

        
    }

    
}