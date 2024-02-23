using System.Diagnostics.CodeAnalysis;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        ShowCountDown(5);
        DateTime end = DT();
        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}