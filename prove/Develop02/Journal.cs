using System;

public class Journal
{
    
    DateTime day = DateTime.Now;
    public List<string> _entries = new List<string>();
    PromptGenerator journalCreation = new PromptGenerator();
    string filename = "entries.txt";
    
    public void addEntry(Entry newEntry)
    {
        string dayText = day.ToShortDateString();
        Entry entry1 = new Entry()
        {
            _date = dayText,
            _promptText = journalCreation.GetRandomPrompt(),
        };
        entry1.Display();

        string append = $"{entry1._date}\n{entry1._promptText}\n{entry1._entryText}\n|";

        _entries.Add(append);
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
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            foreach (string entry in parts)
            {
                _entries.Add(entry);
            }
        }
    }
}