using System;
using System.Collections.Generic;
using System.Threading;

public class MindfulnessActivities
{
}
//     protected string _name;
//     protected string _description;
//     protected int _duration;

//     public MindfulnessActivities(string name, string description, int duration)
//     {
//         _name = name;
//         _description = description;
//         _duration = duration;
//     }
//     public void StartActivity()
//     {
//         Console.WriteLine($"Starting {_name}... ");
//         Console.WriteLine(description);
//         Console.WriteLine("Enter the duration in seconds: ");
//         if (int.TryParse(Console.ReadLine(), out in duration))
//         {
//             _duration = duration;
//             RunActivity();
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please try again. ");
//         }
//     }

//     protected virtual void RunActivity()
//     {
//     }
//     protected void Countdown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.Write(i + " ");
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine();
//     }
//     public void EndActivity()
//     {
//         Console.WriteLine($"{_name} completed. Have a great day!");
//     }
// }