public class Entry
{
    public string _date;
    public string _entryText;
    public string _randomTopic;
    public string Date;
    public string EntryText;
    public string RandomTopic;

    public Entry(string date, string entryText, string randomTopic)
    {
        _date = date;
        _entryText = entryText;
        _randomTopic = randomTopic;
        Date = date;
        EntryText = entryText;
        RandomTopic = randomTopic;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Topic: {_randomTopic}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Topic: {RandomTopic}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}
