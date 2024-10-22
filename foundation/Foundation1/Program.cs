using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video { Title = "Rabbit Hurdle Jumping Contests", Author = "Bugs Bunny", LengthInSeconds = 180 };
        video1.AddComment("Bunnicula Bunny", "I didn't know rabbits could jump that high!");
        video1.AddComment("Lyra Lagamorph", "I'm so proud of my little bun.");
        video1.AddComment("Catculus Intergrowls", "Cat's are a superior species.");
        video1.AddComment("Rocky Balbunny", "Those are fighting words.");

        Video video2 = new Video { Title = "Rabbit Care 101", Author = "The Velveteen Rabbit", LengthInSeconds = 240 };
        video2.AddComment("Queen Lizzy", "Superb!");
        video2.AddComment("Harli Harlequin", "If a kit were a wish, I would wish for infinite kits.");
        video2.AddComment("Boa Constrictor", "Amen sister!");

        Video video3 = new Video { Title = "Coat Color Genome Calculator", Author = "Professor Peter Cottontail", LengthInSeconds = 300 };        
        video3.AddComment("Sir Hops-a-Lot", "I don't see any rounded tables.");
        video3.AddComment("Conceptual Practice", "I don't have the patience for this.");
        video3.AddComment("Reading RainBun", "This is the program that never ends. It just goes on and on my friends. Some person started writing it not knowing what it was, and they'll continue writing it forever just because. This is the program that never ends. It just goes on and on my friends. Some person....");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }       
}


// class Video
// Responsibilites: track title, author, and length in seconds of each video.
// Behaviors: has the responsibility to store a list of comments.
// State: a method to return a number of comments.

// class Comments
// Responsibilites: track the author/name of person making the comment and the comment text.
// Behaviors: has the responsibility to store a list of comments.
// State: void method to add a comment to the list of comments.
  
// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
    