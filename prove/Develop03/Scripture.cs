using System;
using System.Collections.Generic;
public class Scripture
{
    private string _reference;
    private List<word> _words = new List<word>();
    private Random random = new Random();
    public Scripture(string referenceText, string text)
    {
        _reference = referenceText;
        _words = new List<string>(text.Split(' '));
    }
    
    public string Get_reference()
    {
        return _reference;
    }

    public string GetText()
    {
        return string.Join(" ", _words);
    }

    public void HideRandomWord()
    {
        int randomIndex = random.Next(_words.Count);
        while (_words[randomIndex] == new string('_', _words[randomIndex].Length))
        {
            randomIndex = random.Next(_words.Count);
        }
        _words[randomIndex] = new string('_', _words[randomIndex].Length);
    }
}

// A class for a Scripture will need a constructor that accepts both a _reference and the text of the scripture. If the Scripture class internally stores a List of Word objects, the first thought would be to pass a List<Word> variable to the constructor. While this could work, it would have some downsides. First, it would expose the internal storage of the Scripture to the person using the class (losing the benefits of encapsulation). Second, it would require the person using the class to do the work of splitting their text into the list, the way this class expects it. Not only is this extra work, but it also breaks the principle of encapsulation, and will limit your ability to change your class in the future.

// Instead of passing in a list of _words, it would better align with the principle of encapsulation to pass in a string that is the text of the scripture. Then, the constructor would have the responsibility of creating the list, and splitting up the _words in the string to create Word objects for each one and put them in the list.

// While including the logic of creating the word list may seem like a lot of work for the constructor, it is helpful to encapsulate this logic in the Scripture class so that other code does not have to worry about the internal storage of the Scripture. This would enable the program to be easily changed in the future, if a different implementation choice were made.