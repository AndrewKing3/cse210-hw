using System;


class Scripture
{
    private List<Word> _scripture = new List<Word>();
    private Refrence _refrence;

  
    public Scripture(Refrence refrence, string scripture)
    {

        String[] scriptureList = scripture.Split(" "); 
        foreach(string word in scriptureList)
        {
            Word newWord = new Word(word);
            _scripture.Add(newWord);
        }

        _refrence = refrence;
    }


    public void PrintScriptureList()
    {

        Console.Write($"{_refrence.DisplayRefrence()} ");
        foreach(Word word in _scripture)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }    

    public void HideWords(int amount)
    {
        for (int i = 0; i < amount;)
        {
            
            Random random = new Random();
            int randomIndex = random.Next(_scripture.Count);
            Word word = _scripture[randomIndex];

            if (!word.IsHidden())
            {
                word.Hide();
                i++;
            }
            if (AllHidden())
            {
                break;
            }

        }
        
    }

    public bool AllHidden()
    {
        foreach (Word word in _scripture)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    






}
