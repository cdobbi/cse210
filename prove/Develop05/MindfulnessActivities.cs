using System;
using System.Collections.Generic;
using System.Threading;

public class MindfulnessActivities
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public MindfulnessActivities(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string Name
    {
        get { return _name;}
        set { _name = value;}
    }
    public string Descripiton
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
        // }
        // public class GetBreathing
        // {
        //     public string Breathing { get; set; }
        // }
        // public class GetListing
        // {
        //     public string Listing { get; set; }
        // }
        // public class GetStretch
        // {
        //     public string Stretch { get; set; }
        // }
        // public class GetReflection
        // {
        //     public string Reflection { get; set; }
        // }
        // public class GetSleep
        // {
        //     public string Sleep { get; set; }

        //     public void PerformSleep()
        //     {
        //         Console.WriteLine("Going to sleep for a second...");

        //         Thread.Sleep(1000);

        //         Console.WriteLine("I'm back!!");
        //         Console.Write("+");

        //         Thread.Sleep(500);

        //         Console.Write("\b \b"); // Erase the + character
        //         Console.Write("-"); // Replace it with the - character

        //         DateTime startTime = DateTime.Now;
        //         DateTime futureTime = startTime.AddSeconds(5);

        //         Thread.Sleep(3000);

        //         DateTime currentTime = DateTime.Now;
        //         if (currentTime < futureTime)
        //         {
        //             Console.WriteLine("We have not arrived at our future time yet...");
        //         }
        //     }
        // }
    }
}

