using System;
using System.Collections.Generic;
public class Comment
{
    public string Author { get; set; }
    public string CommentText { get; set; }
    public Comment(string author, string commentText)
    {
        Author = author;
        CommentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{Author}: {CommentText}");
    }
}
