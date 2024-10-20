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
        DisplayStartingMessage();
        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
            PerformListing();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        DisplayEndingMessage();
    }
    
    private void PerformListing()
    {
        Console.Write("Begin shortly ... ");
        ShowSpinner(5);
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

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

            Console.Write("Input entries here: ");
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
