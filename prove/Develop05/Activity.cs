using System;
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nYou've chosen: {_activityName}\nDescription: {_description}\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nEnding {_activityName}. Great work today! You can continue the activities or press '4' to quit.\n");
    
    }
    protected void ShowSpinner(int seconds)
    {
        // protected void ShowCountDown(int seconds)
        // {
        //     for (int i = seconds; i > 0; i--)
        //     {
        //         Console.Write(i);
        //         System.Threading.Thread.Sleep(1000);
        //     }
        // }
        // }
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        // for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}
