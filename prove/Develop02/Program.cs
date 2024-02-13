// For extra credit, I added two new prompts the program can randomly choose from

using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;
using System.IO;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Xml.Serialization;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        PromptGenerator PromptText = new PromptGenerator();
        Entry entry1 = new Entry();
        Console.WriteLine("Welcome to the Journal Program!");
        int selection = 0;
        string filename = "entries.txt";
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What do you want to do?");
            string input = Console.ReadLine();
            selection = int.Parse(input);
            if (selection == 1)
            {   
                journal1.addEntry(entry1);
            }
            else if (selection == 2)
            {
                journal1.DisplayAll();
            }
            else if (selection == 3)
            {
                journal1.SaveToFile(filename);
            }
            else if (selection == 4)
            {
                journal1.LoadFromFile(filename);
            }
            else
            {
            }
        } while (selection != 5);
    }


    public void Menu()
    {
    }
}