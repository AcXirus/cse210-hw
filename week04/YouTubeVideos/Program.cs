using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Carol", "Can you explain classes next?"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Concepts", "Jane Doe", 900);
        video2.AddComment(new Comment("Dave", "This was tough but I learned a lot."));
        video2.AddComment(new Comment("Eve", "More videos like this please!"));
        video2.AddComment(new Comment("Frank", "Can you do a video on LINQ?"));
        videos.Add(video2);

        Video video3 = new Video("C# Projects for Beginners", "Emily Davis", 750);
        video3.AddComment(new Comment("George", "Thanks for the project ideas!"));
        video3.AddComment(new Comment("Hannah", "Loved the explanations."));
        video3.AddComment(new Comment("Ian", "What IDE do you recommend?"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
