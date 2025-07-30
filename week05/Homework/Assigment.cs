using System.Dynamic;

public class Assigment
{
    private string _studentName;
    private string _topic;

    public Assigment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    protected string GetStudentName()
    {
        return _studentName;
    }
}