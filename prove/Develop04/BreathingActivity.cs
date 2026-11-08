using System.Runtime.InteropServices;

class BreathingActivity : BaseActivity
{
    

   
    public BreathingActivity(): base("Breathing Activity", "this activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }






    public int RunActivity()
    {

        StartActivity();
        StartTimer();
        while (!HasTimerExpired())
        {
            Console.Clear();
            RunCountDownMessage("Breath in", 4);
            Console.Clear();
            RunCountDownMessage("Breath out", 6);
        }   
        
         int duration = EndActivity();
        return duration;
    }



}