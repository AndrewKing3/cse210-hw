using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        String LetterGrade;
        String Symbol = "";
        Console.WriteLine("What percenatge did you get?");
        string GradeStr = Console.ReadLine();
        int GradeInt = int.Parse(GradeStr);

        if(GradeInt >= 90)
        LetterGrade = "A";
        else if(GradeInt < 90 && GradeInt >= 80)
        LetterGrade = "B";
        else if(GradeInt < 80 && GradeInt >= 70)
        LetterGrade = "C";
        else
        LetterGrade = "F";

        if((GradeInt % 10) >= 5 && GradeInt > 70)
        Symbol = "+";
        
        Console.WriteLine($"You got a(n) {LetterGrade}{Symbol}.");


    }
}