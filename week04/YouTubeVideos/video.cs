using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    public List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
