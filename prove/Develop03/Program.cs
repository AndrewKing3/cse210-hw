using System;

class Program
{
    static void Main(string[] args)
    {
    
        Refrence refrence = new Refrence("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(refrence, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths." );
        
       while (!scripture.AllHidden())
        {
            Console.Clear();

            scripture.PrintScriptureList();

            Console.WriteLine();
            Console.Write("Press Enter to remove word, type 'q' to quit");

            string answer = Console.ReadLine();

            if (answer == "q")
            {
                break;
            }

            scripture.HideWords(2);
        }




    }
}
