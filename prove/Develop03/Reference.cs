using System;
public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;
    
    public Reference(string bookName, int chapterNumber, int startVerseNumber, int endVerseNumber)
    {
        book = bookName;
        chapter = chapterNumber;
        startVerse = startVerseNumber;
        endVerse = endVerseNumber;
    }
    public Reference(string bookName, int chapterNumber, int startVerseNumber)
    {
        
        book = bookName;
        chapter = chapterNumber;
        startVerse = startVerseNumber;
        endVerse = startVerseNumber;       
    }
    public string GetReference()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}

// A class for a Reference should have two different constructors to account for cases where there is a single verse or multiple verses. Notice that you can have two different constructors as long as the parameter list is different. The first constructor would just receive a book, chapter, and verse, whereas the second would receive a book, chapter, start verse and end verse. (This ability to have multiple versions of a function, as long as the parameters are different is called Function Overloading, and it is possible with any function not just constructors.)
