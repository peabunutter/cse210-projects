using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }
}