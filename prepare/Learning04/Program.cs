using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Math myMath = new Math("Roberto Rodriguez", "Fractions","7.3","8-19");
        myMath.GetHomeworkList();

        Writing myWriting = new Writing("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        myWriting.GetWritingInfo();
    }
}