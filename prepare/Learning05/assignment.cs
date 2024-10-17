using System;
using System.ComponentModel;

class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string Getsummery()
    {
        return $"{_studentName} - {_topic}";
    }
    public string getstudentname()
    {
        return _studentName;
    }
    public string getTopic()
    {
        return _topic;
    }
}