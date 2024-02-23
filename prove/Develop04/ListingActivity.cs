using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count = 0;
    private string p1 = "Who are people that you appreciate?";
    private string p2 = "What are personal strengths of yours?";
    private string p3 = "Who are people that you ahve helped this week?";
    private string p4 = "When have you felt the Holy Ghost this month?";
    private string p5 = "Who are some of your personal heroes?";

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> {p1, p2, p3, p4, p5};
    }
    public void Run()
    {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        _duration += 5;
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        ShowCountDown(5);
        _duration -= 5;
        Console.WriteLine("");
        DateTime end = DT();
        while (DateTime.Now < end)
        {
            Console.Write(">");
            Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int randPrompt = random.Next(_prompts.Count);
        string prompt = $"--{_prompts[randPrompt]}--";
        Console.WriteLine(prompt);
    }
}