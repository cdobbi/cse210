using System;
using System.Collections.Generic;

public class BreathingActivity : MindfulnessActivities
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        Console.WriteLine("Starting Breathing Activity...");
        PerformBreathing();
    }
    public void PerformBreathing()
    {
        Console.WriteLine("Breathing in...");
        Console.WriteLine("Breathing out...");
    }
}