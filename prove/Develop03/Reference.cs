public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Reference(string _book, int _chapter, int verse)
    // {
    // }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string fullReference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        return fullReference;
    }
}