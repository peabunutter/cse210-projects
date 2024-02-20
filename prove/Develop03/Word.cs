using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic.FileIO;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        string _text2 = "";
        foreach (char c in _text)
        {
            _text2 = _text2 + "_";
        }
        _text = _text2;
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}