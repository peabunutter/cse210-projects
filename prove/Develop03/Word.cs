using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic.FileIO;

public class Word
{
    public string _text;
    public bool _isHidden;

    Word(string text)
    {
        _text = text;
        if (IsHidden() == true)
        {
            
        }
    }
    private void Hide()
    {
        string text2 = "";
        foreach (char c in _text)
        {
            text2 = text2 + c;
        }
        _text = text2;
        _isHidden = true;
    }
    private void Show()
    {
        _isHidden = false;
    }
    private bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            Hide();
        }
        else
        {
            Show();
        }
        return _text;
    }
}