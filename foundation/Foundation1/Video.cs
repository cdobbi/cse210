public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string author, string text)
    {
        comments.Add(new Comment(author, text ));
    }
    public int GetCommentCount()
    {
        return comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Video: {Title}");
        Console.WriteLine($"By: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}
