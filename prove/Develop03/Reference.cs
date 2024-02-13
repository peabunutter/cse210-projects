public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    Reference(string book, int chapter, int verse)
    {
    }
    Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = "Proverbs";
        chapter = 3;
        startVerse = 5;
        endVerse = 6;
        Console.WriteLine($"{book} {chapter}: {startVerse}-{endVerse}");
    }
    public string GetDisplayText()
    {
        
        return "placeholder return";
    }
}