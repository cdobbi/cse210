public class Entry
{
    public string _date;
    public string _topic;
    public string _journalEntry;
    

    public Entry(string date, string topic, string journalEntry)
    {
        _date = date;
        _topic = topic;
        _topic = journalEntry;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Topic: {_topic}");
        Console.WriteLine($"Journal entry: {_journalEntry}");
        Console.WriteLine();
    }
}
