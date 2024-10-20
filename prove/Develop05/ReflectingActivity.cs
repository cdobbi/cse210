using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;
    public ReflectingActivity(string activityName, string description, int duration, List<string> prompts, List<string> questions)
        : base(activityName, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Enter the duration in seconds: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
            PerformReflecting();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        DisplayEndingMessage();
    }

    private void PerformReflecting()
    {
        Console.Write("\nBegin shortly ... ");
        ShowSpinner(5);
        
        int elapsed = 0;
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        while (elapsed < Duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            Console.Write("Your reflection: ");
            string reflecton = Console.ReadLine();
            // ShowSpinner(5);
            elapsed += 5;
        }

        // spinnerThread.Abort();
    }
}

