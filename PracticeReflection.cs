// using System;
// using System.Collections.Generic;
// using System.Threading

// public class Reflection : MindfulnessActivities
// {
//     private List<string> _prompts;
//     private List<string> _questions;
//     public Reflection(string name, string description, int duration) : base(name, description, duration)
//     {
//         _prompts = new List<string>
//         {
//             "Who are the people that made a difference for you today?",
//             "Name three of your strengths",
//             "What are three things you are grateful for?",
//             "What are you looking forward to?",
//             "What makes you awesome?"
//         };

//         _questions = new List<string>
//         {
//             "What was your favorite part of that? ",
//             "How can you use that to help another? ",
//             "What can be done to improve on this next time? ",
//             "Why was this experience meaningful to you? ",
//             "What was your favorite word in that? ",
//         };
//     }
//     public void Run()
//     {
        
//         Console.WriteLine("This is the Reflection Exercise. This will steer you to reflect on your life and your strengths. Let's get started.");
//         Console.Write("How many seconds would you like to do this? ");
//         if (int.TryParse(Console.ReadLine(), out int duration))
//         {
//             _duration = duration;
//             PerformReflection();
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//         Console.WriteLine("Reflection Activity completed. Have a fantastic day!");
//     }
//     private void PerformReflection()
//     {
//         Random random = new Random();
//         int elapsed = 0;

//         string prompt = _prompts[random.Next(_prompts.Count)];
//         Console.WriteLine(prompt);

//         while (elapsed < _duration)
//         {
//             string question = _questions[random.Next(_questions.Count)];
//             Console.WriteLine(question);
//             Countdown(5);
//             elapsed += 5;
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