public class Entry
{
    public string _date;
    public string _entryText;
    public string _randomTopic;

    public Entry(string date, string entryText, string randomTopic)
    {
        _date = date;
        _entryText = entryText;
        _randomTopic = randomTopic;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Topic: {_randomTopic}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}
