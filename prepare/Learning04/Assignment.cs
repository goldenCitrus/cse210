public class Assignment
{

public Assignment(string studentName, string topic)
{
    _studentName = studentName;
    _topic = topic;
}

protected string _studentName;
protected string _topic;

public void GetSummary()
{
    Console.WriteLine($"{_studentName} - {_topic}");
}
}