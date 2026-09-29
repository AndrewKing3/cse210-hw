using System;

class Program
{
    static void Main(string[] args)
    {
        bool correct;
        string magicStr;
        int magicInt;
        string guessStr;
        int guessInt;
        int count;
        string again = "y";
        

        while(again == "y"){

            count = 1;
            correct = false;

            Console.Write("What is the magic number?");
            magicStr = Console.ReadLine();
            magicInt = int.Parse(magicStr);
        
            while(!correct){
            
            
                Console.Write("What is your guess?");
                guessStr = Console.ReadLine();
                guessInt = int.Parse(guessStr);
                if(guessInt < magicInt)
                {
                    Console.Write("Higher");
                }
                else if(guessInt > magicInt)
                {
                    Console.Write("Lower");
                }
                else
                {
                    Console.Write($"That is the magic number! it took you {count} guesses");
                    correct = true;
                }
                count++;
                Console.WriteLine();
            }

            Console.Write("do you want to play again?(y/n)");
            again = Console.ReadLine();
        }

    }
}