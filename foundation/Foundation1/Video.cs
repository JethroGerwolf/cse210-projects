using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
   
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


    public void AddComment(string commenterName, string text)
    {
        _comments.Add(new Comment(commenterName, text));
    }


    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


    public override string ToString()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetNumberOfComments()}";
    }
}