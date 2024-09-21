public class Entry
{
    public string _date;
    public string _topic;
    public string _journalEntry;   

    public Entry(string date, string topic, string journalEntry)
    {
        _date = date;
        _topic = topic;
        _journalEntry = journalEntry;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date}|{_topic}|{_journalEntry}");
    }
}
