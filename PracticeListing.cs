// // using System;
// // using System.Collections.Generic;

// // public class Listing : MindfulnessActivities
// // {
// //     private List<string> _prompts;
// //     public Listing(string name, string description, int duration) : base(name, description, duration)
// //     {
// //         _prompts = new List<string>
// //         {
// //             "List 5 things you can smell right now. ",
// //             "Who are the people that you appreciate? ",
// //             "List 12 ways to count down before Christmas. ",
// //             "List the 7 dwarves.",
// //             "Make a list of everything you've got done today. "
// //         };
// //     }
// //     protected override void RunActivity()
// //     {
// //         PerformListing();
// //     }

// //     private void PerformListing()
// //     {
// //         Random random = new Random();
// //         int elapsed = 0;

// //         string prompt = _prompts[random.Next(_prompts.Count)];
// //         Console.WriteLine(prompt);
// //         Countdown(5);

// //         List<string> userResponses = new List<string>();

// //         DateTime startTime = DateTime.Now;
// //         DateTime endTime = startTime.AddSeconds(_duration);

// //         while (DateTime.Now < endTime)
// //         {
// //             Console.Write("Enter an item: ");
// //             string response = Console.ReadLine();
// //             userResponses.Add(response);
// //         }
// //         Console.WriteLine($"You listed {userResponses.Count} items.");
// //     }
// // }