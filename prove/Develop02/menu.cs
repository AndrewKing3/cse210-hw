using System;

class Menu
{
    
    public int ProcessMenu()
    {
    
        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries");
            Console.WriteLine("1. Create new Journal entry.");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. save journal to file");
            Console.WriteLine("4. Read journal from file");
            Console.WriteLine("5. Quit");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        
        }
        return input;
    }
}