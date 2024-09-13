public class Entry
{
    public string Date;
    public string EntryText;
    public string RandomTopic;

    public Entry(string date, string entryText, string randomTopic)
    {
        Date = date;
        EntryText = entryText;
        RandomTopic = randomTopic;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Topic: {RandomTopic}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}
