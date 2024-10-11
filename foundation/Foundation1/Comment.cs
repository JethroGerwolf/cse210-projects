using System;
using System.Collections.Generic;
public class Comment
{
    public string _commenterName;
    public string _commentText;


    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _commentText = text;
    }


    public override string ToString()
    {
        return $"{_commenterName}: {_commentText}";
    }
}