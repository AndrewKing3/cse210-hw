using System;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        StartMessage();
        string name = AskName();
        int FavNum = AskFavoriteNumber();
        int year = AskBirthYear();
        DisplayFavNumSquared(name,FavNum);
        Displayage(name,year);
    }


    static void StartMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }  

    static string AskName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int FavNum = int.Parse(Console.ReadLine());

        return FavNum;
    }

    static int AskBirthYear()
    {
        Console.Write("PLease enter the year you were born: ");
        int year = int.Parse(Console.ReadLine());

        return year;
    }

    static void DisplayFavNumSquared(string name, int favNum)
    {
        int square = favNum*favNum;
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    static void Displayage(string name, int year)
    {
       int age = 2026-year; 
       Console.WriteLine($"{name}, this year(2026) you will turn {age}.");
    }

    

}