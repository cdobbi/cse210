public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video()
    {
        comments = new List<Comment>();
    }

    public void AddComment(string author, string text)
    {
        comments.Add(new Comment(author, text));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}
