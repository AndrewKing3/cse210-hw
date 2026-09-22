using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        int z = 30;

        if (x==10 && y==20 || z == 30){
            Console.WriteLine("X is 10 and y is 20, or z is 30");
        }
        else if (x>10){
            Console.WriteLine("X is larger than 10");
        }
        else{
            Console.WriteLine("X is less than 10");
        }

        
    }
}