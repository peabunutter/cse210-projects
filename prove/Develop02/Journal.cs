using System;

public class Journal
{
    
    DateTime day = DateTime.Now;
    public List<Entry> _entries;
    PromptGenerator journalCreationPG = new PromptGenerator();
    Journal journalCreationJ = new Journal();
    
    public void addEntry(Entry newEntry)
    {
        string dayText = day.ToShortDateString();
        Entry entry1 = new Entry()
        {
            _date = dayText,
            _promptText = journalCreationPG.GetRandomPrompt(),
            _entryText = Console.ReadLine(),
        };

        journalCreationJ._entries.Add(entry1);
    }
    public void DisplayAll()
    {
        foreach (var item in _entries)
        {
            Console.WriteLine(item);
        }
    }
    public void SaveToFile(string file)
    {
        string filename = "entries.txt";
        using (StreamWriter outputFile = new(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = "entries.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

        }
    }
}