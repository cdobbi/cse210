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
        DisplayStartingMessage();  // Use the property to access _description
        Console.Write("How long would you like to practice intentional breathing? Enter the duration in seconds: \n");
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
        int elapsed = 0;
        while (elapsed < Duration)
        {

            Console.WriteLine("\nBreathe in ... \n");
            // ShowCountDown(10);
            ShowSpinner(5);
            Console.WriteLine("\nBreathe out ...\n");
            // ShowCountDown(10);
            ShowSpinner(5);
            elapsed += 10;
        }
    }
}