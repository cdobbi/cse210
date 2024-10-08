using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        Video video = new Video
        {
            Title = "Lagamorph Hurdle Jumping Contests",
            Author = "Bugs Bunny",
            LengthInSeconds = 300
        };

        video.AddComment("Sally Forth", "These are so fun to watch!");
        video.AddComment("Bunnicula Bunny", "I didn't know rabbits could jump so high!");

        Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

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
    