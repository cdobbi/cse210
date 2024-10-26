using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    // private List<string> _usedPrompts;
    private List<string> _questions;
    private Random _random;
    public ReflectingActivity(string activityName, string description, int duration, List<string> prompts, List<string> questions)
        : base(activityName, description, duration)
    {
        _prompts = prompts;
        // _usedPrompts = usedPrompts;
        _questions = questions;
        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Enter the duration in seconds(at least 20): ");

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
        ShowSpinner(2);
        
        int elapsed = 5;
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);


        while (elapsed < Duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            // Console.Write("Next question: ");
            // string reflecton = Console.ReadLine();
            ShowSpinner(5);
            elapsed += 5;
        }

        // spinnerThread.Abort();
    }
}

