using System;

public class PromptGenerator
{
    // public int[] plist = {0, 1, 2, 3, 4};
    // private Random number = new Random();

    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        // int rand = plist[number.Next(0, plist.Length)];
        
        List<string> Prompts = new List<string>();
        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");
        Prompts.Add("What is one thing that inspipred you today?");
        Prompts.Add("What is one recreational activity you did today?");

        Random random = new Random();
        int rand = random.Next(Prompts.Count);

        string prompt = Prompts[rand];

        return prompt;
    }
}