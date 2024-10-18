using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivities
{
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Listing 5 things you can smell...",
            "Listing 5 things you can feel...",
            "Listing 5 things you can hear...",
            "Listing 5 things you can see..."
        };
    }

    public void Run()
    {
        Console.WriteLine("Starting Listing Activity...");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        List<string> userResponses = GetListFromUser();
        _count = userResponses.Count;
        Console.WriteLine($"You listed {_count} itmes.");
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        return _prompts[promptIndex];
    }

}