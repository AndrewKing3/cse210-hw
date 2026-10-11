using System;
using System.IO.Enumeration;
using System.Xml.Serialization;

public class Prompt
{


    public string RandomPrompt()
    {

        List<string> prompts = ["how was your day?", "What did you learn today?", "What challenges did you overcome today?", "What was the best thing that happend today?", "What could you have done better today?"];
    
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }

}