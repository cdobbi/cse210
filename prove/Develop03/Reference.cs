using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string bookName, int chapterNumber, int startVerseNumber, int endVerseNumber)
    {
        _book = bookName;
        _chapter = chapterNumber;
        _startVerse = startVerseNumber;
        _endVerse = endVerseNumber;
    }
    public Reference(string bookName, int chapterNumber, int startVerseNumber)
    {
        
        _book = bookName;
        _chapter = chapterNumber;
        _startVerse = startVerseNumber;
        _endVerse = startVerseNumber;       
    }
    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}

// A class for a Reference should have two different constructors to account for cases where there is a single verse or multiple verses. Notice that you can have two different constructors as long as the parameter list is different. The first constructor would just receive a book, chapter, and verse, whereas the second would receive a book, chapter, start verse and end verse. (This ability to have multiple versions of a function, as long as the parameters are different is called Function Overloading, and it is possible with any function not just constructors.)
