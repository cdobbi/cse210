public class Entry
{
    public string _date;
    public string _topic;
    public string _journalEntry;
    

    public Entry(string _date, string _topic, string _journalEntry)
    {
        _date = date;
        _topic = topic;
        _topic = journalEntry;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Topic: {topic}");
        Console.WriteLine($"Journal entry: {journalEntry}");
        Console.WriteLine();
    }
}
