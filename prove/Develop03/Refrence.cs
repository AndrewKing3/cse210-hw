using System;
using System.Collections.Concurrent;
using System.Data;

class Refrence
{
    private string _book;
    private int _chapter;

    private int _verse;

    private int _endVerse;

    public Refrence(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
      public Refrence(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    

    public string DisplayRefrence()
    {
       if(_endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }

        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

}