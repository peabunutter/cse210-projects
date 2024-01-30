using System;

public class PromptGenerator
{
    public int[] plist = {0, 1, 2, 3, 4};
    private Random number = new Random();

    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        int rand = plist[number.Next(0, plist.Length)];
        
        if (_prompts[0] == "")
        {
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");
        }

        string prompt = _prompts[rand];

        return prompt;
    }
}