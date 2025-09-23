using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _commentList = new List<Comment>();
  //  private List<Video> _video = new List<Video>();

    public Video (string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    //public void AddVideos(Video video)
    //{
      //  _video.Add(video);
    //}

    public void AddComments(Comment comment)
    {
        _commentList.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _seconds;
    }

    public int GetNumberOfComments()
    {
        return _commentList.Count;
    }

    public void DisplayAllComments()
    {

        foreach (Comment comment in _commentList)
        {
            Console.WriteLine($"Name: {comment.GetName()}");
            Console.WriteLine($"Comment: {comment.GetCommentText()}");
        }
    }
}