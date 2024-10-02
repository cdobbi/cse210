using System;
using System.Collections.Generic;
using System.Linq;

public class Words
{
    private List<string[]> words;
    public Words(List<string> verses)
    {
        words = verses.Select(v => v.Split(' ')).ToList();
    }
    public string GetWords()
    {
        return string.Join("\n", words.Select(w => string.Join(" ", w)));
    }
    public void HideRandomWord()
    {
        foreach (var wordArray in words)
        {
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] != new string('_', wordArray[i].Length))
                {
                    wordArray[i] = new string('_', wordArray[i].Length);
                    return;
                }
            }
        }
    }
}

// A class for a Word will need a constructor as well. This constructor should accept the text of the word to save it as an attribute. In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). Notice that you should not need to pass in the visibility of the word. It can be set to be visible by default.