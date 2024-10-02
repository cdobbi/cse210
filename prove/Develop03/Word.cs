using System;
using System.Collections.Generic;
using System.Linq;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }   
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return !_isHidden;
    }
    public bool IsVisible()
    {
        return _isHidden;
    }
}

// A class for a Word will need a constructor as well. This constructor should accept the text of the word to save it as an attribute. In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). Notice that you should not need to pass in the visibility of the word. It can be set to be visible by default.