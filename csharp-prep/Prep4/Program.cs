using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        bool input = true;
        string NumStr;
        double Num;
        double sum = 0;
        double average;
        double large=-9999;
        List<double> numbers = new List<double>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input)
        {
            Console.Write("Enter a number: ");
            NumStr = Console.ReadLine();
            Num = double.Parse(NumStr);

            if(Num > large)
            {
                large = Num;
            }


            if(Num == 0)
            {
                input = false;   
            }
            else
            {
                numbers.Add(Num);
            }
        }

        foreach(double value in numbers)
                {
                    sum = sum+value;
                }
        average = sum/numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"the largest number is {large}");

    }
}