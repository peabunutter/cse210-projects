// for the stretch challenge I've made it so the program only picks words that are not hidden

using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(scriptureText);
        string referenceText = reference.GetDisplayText();
        string input;

        do
        {
            Console.WriteLine(referenceText);
            Console.WriteLine($" {scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Hit enter to continue or type 'quit' to quit");
            input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideRandomWords();
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        } while (input != "quit" || !scripture.IsCompletelyHidden());
        
        Console.WriteLine(referenceText);
        Console.WriteLine($" {scripture.GetDisplayText()}");
        Console.WriteLine();
        Console.WriteLine("Hit enter to continue or type 'quit' to quit");
        input = Console.ReadLine();
    }
}