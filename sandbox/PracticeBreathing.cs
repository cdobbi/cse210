// using System;
// using System.Collections.Generic;

// public class BreathingActivity : MindfulnessActivities
// {
//     public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
//     {
//     }
//     public void Run()
//     {
//         Console.WriteLine("Starting Breathing Activity...");
//         Console.WriteLine("You've chosen the Breathing Exercise. This will calm you by taking you through breathing in and out slowly. Let's get started on your breathing.");
//         Console.Write("How many seconds would you like to do the exercise? ");
//         if (int.TryParse(Console.ReadLine(), out int duration))
//         {
//             _duration = duration;
//             PerformBreathing();
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//         Console.WriteLine("Breathing Activity completed. You're a rockstar!");
//     }
//     public void PerformBreathing()
//     {
//         int elapsed = 0;
//         while (elapsed < _duration)
//         {
//             Console.WriteLine("Breathing in...");
//             Countdown(3);
//             elapsed += 3;

//             if (elapsed >= _duration) break;

//             Console.WriteLine("Breathing out...");
//             Countdown(3);
//             elapsed += 3;
//         }
//     }
//     private void Countdown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.Write(i + " ");
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine();
//     }
// }