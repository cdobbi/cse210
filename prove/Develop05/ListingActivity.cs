using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListingActivity(string activityName, string description, int duration, int count, List<string> prompts)
        : base(activityName, description, duration)
    {
        // Here we set any variables specific to the ListingActivity class
        _count = 0;
        _prompts = prompts;
        _random = new Random();
    }

    public int GetCount()
    {
        return _count;
    }

    public void Run()
    {
        DisplayStartingMessage();  // Use the property to access _description
        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration; // Use the property to set the duration
            PerformListing();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        DisplayEndingMessage();
    }
    
    // Method to get a list of responses from the user
    private void PerformListing()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration); // Use the property to get the duration

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        // Thread spinnerThread = new Thread(() => ShowSpinnerUntilSpacebar());
        // spinnerThread.Start();

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key ==ConsoleKey.Spacebar)
            {
                break;
            }

            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items.");
    }

    // private void ShowSpinnerUntilSpacebar()
    // {
    //     while (true)
    //     {
    //         ShowSpinner(1);
    //     }
    // }
}
