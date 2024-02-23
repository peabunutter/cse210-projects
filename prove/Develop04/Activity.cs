using System.Xml;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "Default activity description";
        _duration = 10;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine("how long do you want to participate in this activity?");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        _duration = seconds;
        DateTime end = DT();
        while (DateTime.Now < end)
        {
            Console.Write("x");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        DateTime end = DT();
        while (DateTime.Now < end)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
            if (seconds == 0)
            {
                break;
            }
        }
    }
    protected DateTime DT()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        return end;
    }
}