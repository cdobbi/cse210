using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(DateTime.Now, 60, 7);
        Running running2 = new Running(DateTime.Now, 60, 5);
        Cycling biking1 = new Cycling(DateTime.Now, 60, 10);
        Cycling biking2 = new Cycling(DateTime.Now, 60, 15);
        Swimming swimming1 = new Swimming(DateTime.Now, 60, 1);
        Swimming swimming2 = new Swimming(DateTime.Now, 60, 2);

        activities.Add(running1);
        activities.Add(running2);
        activities.Add(biking1);
        activities.Add(biking2);
        activities.Add(swimming1);
        activities.Add(swimming2);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
// The focus of the Foundation programs is to help you design and build the classes and work with the relationships among these classes. With that in mind, you do not need to create a menu system or a user interface. Instead, your Program.cs file should create the required objects, set their values, and display them as specified, without any user interaction.


// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine();
//         List<Video> videos = new List<Video>();
        
//         Video video1 = new Video { Title = "Rabbit Hurdle Jumping Contests", Author = "Bugs Bunny", LengthInSeconds = 180 };
//         video1.AddComment("Bunnicula Bunny", "I didn't know rabbits could jump that high!");
//         video1.AddComment("Lyra Lagamorph", "I'm so proud of my little bun.");
//         video1.AddComment("Catculus Intergrowls", "Cat's are a superior species.");
//         video1.AddComment("Rocky Balbunny", "Those are fighting words.");

//         Video video2 = new Video { Title = "Rabbit Care 101", Author = "The Velveteen Rabbit", LengthInSeconds = 240 };
//         video2.AddComment("Queen Lizzy", "Superb!");
//         video2.AddComment("Harli Harlequin", "If a kit were a wish, I would wish for infinite kits.");
//         video2.AddComment("Boa Constrictor", "Amen sister!");

//         Video video3 = new Video { Title = "Coat Color Genome Calculator", Author = "Professor Peter Cottontail", LengthInSeconds = 300 };        
//         video3.AddComment("Sir Hops-a-Lot", "I don't see any rounded tables.");
//         video3.AddComment("Conceptual Practice", "I don't have the patience for this.");
//         video3.AddComment("Reading RainBun", "This is the program that never ends. It just goes on and on my friends. Some person started writing it not knowing what it was, and they'll continue writing it forever just because. This is the program that never ends. It just goes on and on my friends. Some person....");

//         videos.Add(video1);
//         videos.Add(video2);
//         videos.Add(video3);

//         foreach (var video in videos)
//         {
//             video.DisplayInfo();
//             Console.WriteLine();
//         }
//     }       
// }