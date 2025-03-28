using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

       Video v1 = new Video("C# Tutorial for begginners", "Bro Code");
        v1.AddComment(new Comment("Rita", "Great yo see new series, actually has C# in next semester. Thanks bro!"));
        v1.AddComment(new Comment("Martin", "Just started C# tutorial for beginners, it's very nice & easy!!! Thank You bro!!!"));
        v1.AddComment(new Comment("Stevan", "Your video tutorials are simply excellent,  Bro! Thank you very much!!"));
        videos.Add(v1);

        Video v2 = new Video("C# Clases", "Bro Code");
        v2.AddComment(new Comment("Zoe", "you are a legend, im studying it and my teachers explain it as if im already experienced. this is a huge help"));
        v2.AddComment(new Comment("Ben", "U dont understand how much i appreciate this"));
        v2.AddComment(new Comment("Alex", "Good job you are always explaining very clearly "));
        videos.Add(v2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"N° Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetuserName()}: {comment.GetText()}");
            }
        }
    }
}