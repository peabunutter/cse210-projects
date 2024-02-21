using System.Net.Quic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private List<int> _choice = new List<int>();

    Random random = new Random();
    public Scripture(string text)
    {
        string[] textSection = text.Split(" ");
        foreach (string textWord in textSection)
        {
            Word word = new Word(textWord);
            _words.Add(word);
        }
    }
    public void HideRandomWords()
    {
        while (_choice.Count != 3)
        {
            int rand = random.Next(_words.Count);
            if (!_words[rand].IsHidden())
            {
                _words[rand].Hide();
                _choice.Add(rand);
            }
        }
        _choice.Clear();
    }
    public string GetDisplayText()
    {
        string output = "";
        foreach (Word word in _words)
        {
            output = $"{output} {word.GetDisplayText()}";
        }
        return output;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word item in _words)
        {
            if (!item.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}