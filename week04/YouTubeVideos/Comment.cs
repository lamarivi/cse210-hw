using System;

class Comment
{
    private string userName;
    private string commentText;

    public Comment(string name, string text)
    {
        userName = name;
        commentText = text;
    }

    public string GetuserName() => userName;
    public string GetText() => commentText;
}

class Video
{
    private string title;
    private string author;
    private List<Comment> comments;

     public Video(string title, string author)
    {
        title = title;
        author = author;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public string GetTitle() => title;
    public string GetAuthor() => author;
}