using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Basics of Piano in 5 minutes!", "JulioPlays", 300);
        video1.AddComments(new Comment("Jhonny", "Coolest video I've ever seen!"));
        video1.AddComments(new Comment("Mia", "This made my day! Thank you!"));
        video1.AddComments(new Comment("Ava", "That was great! I understand that better now!"));
        videos.Add(video1);
        
        Video video2 = new Video("Viking Braid Tutorial", "Crown & Confidence", 923);
        video2.AddComments(new Comment("Susie", "Great tips! Extremely helpful."));
        video2.AddComments(new Comment("Gwen", "Can't wait to try out this hairstyle! So cute!"));
        video2.AddComments(new Comment("Betsy", "What a great video!"));
        videos.Add(video2);

        Video video3 = new Video("Family Game Night Gets Silly!", "Everyday Moments", 537);
        video3.AddComments(new Comment("Sophi", "How cute! I love this!"));
        video3.AddComments(new Comment("Michael", "Thank you for the videos!"));
        video3.AddComments(new Comment("Lucas", "This helped me so much!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Time: {video.GetLength()}");
            Console.WriteLine("");

            Console.WriteLine("----Comments----");
            video.DisplayAllComments();
            Console.WriteLine("");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("");
        }
    }
}