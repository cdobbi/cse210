using System;

public class BreathingActivity : Activity
{
    // public string _start;
    // public string _end;
    // private List<string> _questions;
    // private List<string> _prompts;

    public BreathingActivity(string activityName, string description, int duration, string start, string end, string questions, object prompt)
        : base(activityName, description, duration)
    {
        // _start = start;
        // _end = end;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("How long would you like to practice intentional breathing? Enter the duration in seconds:\n");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration; // Use the property to set the duration
            PerformBreathing();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        DisplayEndingMessage();
    }

    private void PerformBreathing()
    {
        Console.Write("\nBegin shortly ... ");
            ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.Write("\nBreathe in slowly ... ");
            // ShowCountDown(10);
            ShowSpinner(6);
            Console.Write($"\nBreathe out slowly ... ");
            // ShowCountDown(10);
            ShowSpinner(6);
            elapsed += 12;
        }
    }
}