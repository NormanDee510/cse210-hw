using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating comments
        Comment comment1 = new Comment("Brian", "Great video, really enjoyed it!");
        Comment comment2 = new Comment("Mkhululi", "Very informative, thanks for sharing.");
        Comment comment3 = new Comment("Tawanda", "Nice editing and cool content!");
        Comment comment4 = new Comment("Nashe", "Could use more details on the topic.");

        // Creating videos and assigning comments
        Video video1 = new Video("Learning C# Basics", "John Mosh", 600);
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);

        Video video2 = new Video("Advanced C# Concepts", "Michael Knight", 1200);
        video2.Comments.Add(comment4);
        video2.Comments.Add(comment1);
        video2.Comments.Add(comment2);

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2 };

        // Iterating through videos and display details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length / 60} minutes and {video.Length % 60} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
