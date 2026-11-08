using System;
using System.Net.Security;

class Program// for the above and beyond I record the total time spent in each activity
{
    static void Main(string[] args)
    {

    

        Menu myMenu = new Menu();
        BreathingActivity breathActivity = new BreathingActivity();
        ReflectionActivity refActivity = new ReflectionActivity();
        ListingActivity listActivity = new ListingActivity();

        int response = 0;
        int duration = 0;
        while (response != 4)
        {
            response = myMenu.ProcessMenu();

            switch (response)
            {
                case 1:
                    duration = breathActivity.RunActivity();
                    myMenu.UpdateCount(duration,0,0);
                break;
                case 2:;
                    duration = refActivity.RunActivity();
                    myMenu.UpdateCount(0,duration,0);
                break;
                case 3:
                    duration = listActivity.RunActivity();
                    myMenu.UpdateCount(0,0,duration);
                break;
            }

            
        }
    }
}