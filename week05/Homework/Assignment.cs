using System;


public class Assignment
{
    private string _studentsName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentsName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentsName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentsName} - {_topic}";
    }
}