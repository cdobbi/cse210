using System;
using System.Collections.Generic;

public class Reflection : MindfulnessActivities
{
    public Reflection(string v) : base(v)
    {
    }

    public void PerformReflection()
    {
        Console.WriteLine("Reflecting on the day...");
        Console.WriteLine("What went well?");
        Console.WriteLine("What could have gone better?");
        Console.WriteLine("What are you grateful for?");
    }

}